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
    public partial class frmCBO : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle;
        public frmCBO()
        {
            InitializeComponent();
            _controle = new Controles();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Navegando);
        }
        
        private void Pesquisa()
        {
            Pesquisa<remag_cbo> pesquisa = new Pesquisa<remag_cbo>("remag_cbo", new string[] { "cbo","descricao"}, new int[] { 100, 250 }, new string[] {"CBO","Descrição"}, "Classificação Brasileira de Ocupação",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceCBO.DataSource = pesquisa._entity;
                }
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Pesquisando);
            }
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        TipoOperacao operacao;
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceCBO.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Adicionando);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(operacao==TipoOperacao.Adicionando)
            {
                Insert();
            }
            else if(operacao==TipoOperacao.Editando)
            {
                Update();
            }
            if (Crud<remag_cbo>.SaveAll())
            {
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Salvando);
                this.bindingSourceCBO.Clear();
                if (MessageBox.Show(Mensagens.Salvo + " Deseja continuar inserindo?", Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Insert();
                }
            }

        }

        private void Update()
        {
            this.bindingSourceCBO.EndEdit();
            Crud<remag_cbo>.Update((remag_cbo)this.bindingSourceCBO.Current);
        }

        private void Insert()
        {
            remag_cbo cbo = (remag_cbo)this.bindingSourceCBO.Current;
            Crud<remag_cbo>.New(cbo);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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
            Crud<remag_cbo>.Delete((remag_cbo)this.bindingSourceCBO.Current);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Excluindo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceCBO.CancelEdit();
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceCBO.ResetAllowNew();
            }
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Cancelando);
        }

    }
}
