﻿using System;
using System.Collections.Generic;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Funcionario : IEntidade, IBiometria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Fone { get; set; }

        public string Descricao { get; set; }

        public string Documento { get; set; }

        public bool AutorizadaSemPresenca { get; set; }

        public bool ControleAcessoAutorizado { get; set; }

        public string Frequencia { get; set; }

        public DateTime? HorarioEntrada { get; set; }

        public DateTime? HorarioSaida { get; set; }

        public string Biometria { get; set; }

        public byte[] Foto { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Unidade Unidade { get; set; }


        public string TipoEntidade
        {
            get { return typeof(Funcionario).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return Nome;
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}
