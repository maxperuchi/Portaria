﻿using Portaria.Core.Model;
using Portaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Portaria.Log;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Business.Cadastro;
using Portaria.Core;

namespace Portaria.Business
{
    public class ReservaBus : IPortariaBus<Reserva>
    {
        private PortariaContext bd;
        private Sessao sessao;

        public ReservaBus(Sessao sessao)
        {
            bd = new PortariaContext();
            this.sessao = sessao;
        }

        public ReservaBus(Sessao sessao, PortariaContext bd)
        {
            this.bd = bd;
            this.sessao = sessao;
        }

        public IEnumerable<Reserva> Todos()
        {
            return bd.Reservas;
        }

        public void InserirOuAtualizar(Reserva entidade)
        {
            try
            {
                ValidarReserva(entidade);

                var r = bd.Reservas.Where(i => i.Id == entidade.Id).FirstOrDefault();

                if (r == null)
                {
                    entidade.DataHora = DateTime.Now;
                    entidade.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();
                    entidade.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                    entidade.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();
                    entidade.Unidade = bd.Unidades.Where(q => q.Id == entidade.Unidade.Id).FirstOrDefault();

                    bd.Reservas.Add(entidade);
                    bd.SaveChanges();

                    PortariaLog.Logar(entidade.Id, string.Empty, PortariaLog.SerializarEntidade(entidade), entidade.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Inserir);
                    return;
                }

                var ro = bd.Reservas.AsNoTracking().Where(i => i.Id == entidade.Id).FirstOrDefault();
                var entidadeOriginal = PortariaLog.SerializarEntidade(ro);

                r.DataHora = DateTime.Now;
                r.DataHoraFim = entidade.DataHoraFim;
                r.DataHoraInicio = entidade.DataHoraInicio;
                r.Local = bd.Locais.Where(l => l.Id == entidade.Local.Id).FirstOrDefault();
                r.Pessoa = bd.Pessoas.Where(p => p.Id == entidade.Pessoa.Id).FirstOrDefault();
                r.Sessao = bd.Sessoes.Where(s => s.Id == sessao.Id).FirstOrDefault();
                r.Unidade = bd.Unidades.Where(q => q.Id == entidade.Unidade.Id).FirstOrDefault();

                bd.SaveChanges();

                PortariaLog.Logar(r.Id, entidadeOriginal, PortariaLog.SerializarEntidade(r), r.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Alterar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidarReserva(Reserva reserva)
        {
            var configuracaoBus = new ConfiguracaoBus(sessao, bd);

            bool semRestricaoAntecedencia = false;
            int diasAntecedencia = 0;
            bool.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.SemRestricaoAntecedencia), out semRestricaoAntecedencia);
            int.TryParse(configuracaoBus.BuscarValor(Core.TipoConfiguracao.PrazoAntecedenciaReservaDias), out diasAntecedencia);

            if (!semRestricaoAntecedencia)
            {
                var dataLimite = DateTime.Now.AddDays(diasAntecedencia);
                if (reserva.DataHoraInicio > dataLimite)
                {
                    var dataDisponivel = reserva.DataHoraInicio.AddDays(-diasAntecedencia);
                    throw new Exception(string.Format("O prazo máximo de antecedência para reserva é de {0} dias. Você poderá efetuar para a data {1} somente a partir de {2}.",
                        diasAntecedencia, reserva.DataHoraInicio.ToString("dd/MM/yyyy HH:mm"), dataDisponivel.ToString("dd/MM/yyyy HH:mm")));
                }
            }

            if (reserva.Pessoa == null)
            {
                throw new Exception("Você precisa selecionar uma pessoa para efetuar a reserva.");
            }

            if (reserva.Unidade == null)
            {
                throw new Exception("Você precisa selecionar uma unidade para efetuar a reserva.");
            }

            if (reserva.Unidade.Inadimplente)
            {
                throw new Exception("Esta unidade não está autorizada a efetuar reservas.");
            }

            if (reserva.DataHoraFim == null || reserva.DataHoraInicio == null || reserva.DataHoraFim == DateTime.MinValue || reserva.DataHoraInicio == DateTime.MinValue)
            {
                throw new Exception("Você precisa informar a data início e fim da reserva.");
            }

            if (reserva.DataHoraInicio >= reserva.DataHoraFim)
            {
                throw new Exception("A data do fim da reserva deve ser posterior a data de início.");
            }

            var reservasLocal = bd.Reservas.Where(r => r.Local.Id == reserva.Local.Id);

            foreach (var item in reservasLocal)
            {
                if (reserva.DataHoraInicio.Between(item.DataHoraInicio, item.DataHoraFim)
                    || reserva.DataHoraFim.Between(item.DataHoraInicio, item.DataHoraFim))
                {
                    throw new Exception(string.Format("Este local já está reservado para {0} entre {1} e {2}.",
                        item.Pessoa.Nome, item.DataHoraInicio.ToString("dd/MM/yyyy HH:mm"), item.DataHoraFim.ToString("dd/MM/yyyy HH:mm")));
                }
            }
        }

        public Reserva BuscarPorId(int id)
        {
            return bd.Reservas.FirstOrDefault(r => r.Id == id);
        }

        public void Remover(Reserva entidade)
        {
            try
            {
                var r = bd.Reservas.FirstOrDefault(i => i.Id == entidade.Id);

                if (r != null)
                {
                    var ent = PortariaLog.SerializarEntidade(r);

                    bd.Reservas.Remove(r);
                    bd.SaveChanges();

                    PortariaLog.Logar(r.Id, string.Empty, ent, r.TipoEntidade, sessao.Id, Core.Model.Log.TipoAlteracao.Excluir);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            bd.Dispose();
        }
    }
}
