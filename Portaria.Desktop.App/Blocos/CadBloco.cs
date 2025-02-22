﻿using Portaria.Business.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Desktop.Framework.Forms;
using System;

namespace Portaria.Blocos
{
    public partial class CadBloco : MaterialPortariaFormWindow
    {
        private Bloco bloco;

        public Bloco Bloco
        {
            get
            {
                return bloco;
            }

            set
            {
                bloco = value;
                bsBloco.DataSource = bloco;
            }
        }
        public CadBloco()
        {
            InitializeComponent();
            Bloco = new Bloco();
        }

        public CadBloco(Bloco bloco)
        {
            InitializeComponent();
            Bloco = bloco;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            var blocoBus = new BlocoBus(SessaoAtual.Sessao);
            blocoBus.InserirOuAtualizar(Bloco);

            Close();
        }
    }
}
