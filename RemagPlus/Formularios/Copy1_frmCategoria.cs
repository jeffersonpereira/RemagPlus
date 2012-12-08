using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;

namespace RemagPlus
{
    public partial class frmCategoria : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle = new Controles();
        public frmCategoria()
        {
            InitializeComponent();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Navegando);
        }

        TipoOperacao operacao;
        private void Pesquisa()
        {
            Pesquisa<remag_categoria> pesquisa = new Pesquisa<remag_categoria>("remag_categoria", new string[] { "tipo", "descricao" }, new int[] { 100, 250 }, new string[] { "Categoria", "Descrição" }, "Categoria",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceCategoria.DataSource = pesquisa._entity;
                }
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Pesquisando);
            }

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceCategoria.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Adicionando);
        }

        private void Update()
        {
            this.bindingSourceCategoria.EndEdit();
            Crud < remag_categoria>.Update((remag_categoria)this.bindingSourceCategoria.Current);
        }

        private void Insert()
        {
            remag_categoria categoria = (remag_categoria)this.bindingSourceCategoria.Current;
            Crud<remag_categoria>.New(categoria);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Editando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Editando);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = TipoOperacao.Excluindo;
            if (MessageBox.Show(Mensagens.PerguntaExclusao, Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Excluir();
            }
        }

        private void Excluir()
        {
            Crud<remag_categoria>.Delete((remag_categoria)this.bindingSourceCategoria.Current);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Excluindo);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Adicionando)
            {
                Insert();
            }
            else if (operacao == TipoOperacao.Editando)
            {
                Update();
            }
            if (Crud<remag_categoria>.SaveAll())
            {
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Salvando);
                this.bindingSourceCategoria.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceCategoria.CancelEdit();
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceCategoria.ResetAllowNew();
            }
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
        }
        
    }
}
