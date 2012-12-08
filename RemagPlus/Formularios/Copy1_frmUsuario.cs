using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using System.ComponentModel.DataAnnotations;


namespace RemagPlus.Formularios
{
    
    public partial class frmUsuario : Form
    {
        Funcoes _funcao;
        Controles _controle;
        public frmUsuario()
        {
            InitializeComponent();
            _controle = new Controles();
            _funcao = new Funcoes();
        }
        TipoOperacao operacao;
 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceUsuario.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Adicionando);
        }
        private void Insert()
        {
            remag_usuario cbo = (remag_usuario)this.bindingSourceUsuario.Current;
            Crud<remag_usuario>.New(cbo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             _controle.HabilitaDesabilitaControles(this, TipoOperacao.Editando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Editando);
        }

        private void Editar()
        {
            this.bindingSourceUsuario.EndEdit();
            Crud<remag_usuario>.Update((remag_usuario)this.bindingSourceUsuario.Current);
        }
        private void Update()
        {
            this.bindingSourceUsuario.EndEdit();
            Crud<remag_usuario>.Update((remag_usuario)this.bindingSourceUsuario.Current);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Valido())
            {
                if (operacao == TipoOperacao.Adicionando)
                {
                    Insert();
                }
                else if (operacao == TipoOperacao.Editando)
                {
                    Update();
                }
                if (Crud<remag_usuario>.SaveAll())
                {
                    _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                    _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Salvando);
                    this.bindingSourceUsuario.Clear();
                    if (MessageBox.Show(Mensagens.Salvo + " Deseja continuar inserindo?", Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Insert();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bindingSourceUsuario.CancelEdit();
            this.bindingSourceUsuario.ResetAllowNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Cancelando);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }
        private void Pesquisa()
        {
            Pesquisa<remag_usuario> pesquisa = new Pesquisa<remag_usuario>("remag_usuario", new string[] { "login", "nome" }, new int[] { 100, 250 }, new string[] { "Login", "Nome" }, "Usuário", true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceUsuario.DataSource = pesquisa._entity;
                    _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
                    _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Pesquisando);
                }
            }

        }
        #region Validação
        private bool Valido()
        {
            List<string> erros = ValidatedData.IsValid((remag_usuario)this.bindingSourceUsuario.Current);
            bool valido = (erros.Count>0);
            string error = string.Empty;
            if (!valido)
            {
                foreach (string message in erros)
                {
                    error += message + "\n";
                }
                MessageBox.Show(error);
            }
            return valido;
        }

        #endregion
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
