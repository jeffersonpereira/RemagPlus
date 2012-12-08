using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;

namespace RemagPlus.Formularios
{
    public partial class frmSalarioMinimo : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle = new Controles();
        TipoOperacao operacao;
        public frmSalarioMinimo()
        {
            InitializeComponent();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Navegando);
        }
        private void Pesquisa()
        {
            Pesquisa<remag_salario_minimo> pesquisa = new Pesquisa<remag_salario_minimo>("remag_salario_minimo", new string[] { "cbo", "descricao" }, new int[] { 100, 250 }, new string[] { "CBO", "Descrição" }, "Classificação Brasileira de Ocupação", true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceSalarioMinimo.DataSource = pesquisa._entity;
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
            this.bindingSourceSalarioMinimo.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Adicionando);
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
            if (Crud<remag_salario_minimo>.SaveAll())
            {
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Salvando);
                this.bindingSourceSalarioMinimo.Clear();
                MessageBox.Show(Mensagens.Salvo, Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Update()
        {
            this.bindingSourceSalarioMinimo.EndEdit();
            Crud<remag_salario_minimo>.Update((remag_salario_minimo)this.bindingSourceSalarioMinimo.Current);
        }

        private void Insert()
        {
            remag_salario_minimo salario = (remag_salario_minimo)this.bindingSourceSalarioMinimo.Current;
            Crud<remag_salario_minimo>.New (salario);
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
            Crud<remag_salario_minimo>.Delete((remag_salario_minimo)this.bindingSourceSalarioMinimo.Current);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Excluindo);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceSalarioMinimo.CancelEdit();
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceSalarioMinimo.ResetAllowNew();
            }
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
