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
    public partial class frmResponsavel : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle = new Controles();
        public frmResponsavel()
        {
            InitializeComponent();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            Configura();
        }

        TipoOperacao operacao;
        private void Pesquisa()
        {
            Pesquisa<remag_responsavel> pesquisa = new Pesquisa<remag_responsavel>("remag_responsavel", new string[] { "cnpj_cei_cpf", "nome" }, new int[] { 100, 250 }, new string[] { "Inscrição", "Nome" }, "Responsável",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceResponsavel.DataSource = pesquisa.Entity;
                    _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
                }
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void Update()
        {
            this.bindingSourceResponsavel.EndEdit();
            remag_responsavel responsavel = (remag_responsavel)this.bindingSourceResponsavel.Current;
           Crud<remag_responsavel>.Update(responsavel);
        }

        private void Insert()
        {
            remag_responsavel reponsavel = (remag_responsavel)this.bindingSourceResponsavel.Current;
            Crud<remag_responsavel>.New(reponsavel);
        }

        private void Excluir()
        {
            Crud<remag_responsavel>.Delete((remag_responsavel)this.bindingSourceResponsavel.Current);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceResponsavel.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             operacao = TipoOperacao.Editando;
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Editando);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = TipoOperacao.Excluindo;
            if (MessageBox.Show(Mensagens.PerguntaExclusao, Mensagens.Titulo, MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Excluir();
            }
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
            if (Crud<remag_responsavel>.SaveAll())
            {
                MessageBox.Show(Mensagens.Salvo, Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Salvando);
                this.bindingSourceResponsavel.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Configura()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_responsavel)dataSource).Municipio = value;
            };
            this.pesquisaControlCidade.Bind<remag_municipio>("remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 100 }, this.bindingSourceResponsavel, setMunicipio,false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceResponsavel.CancelEdit();
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceResponsavel.ResetAllowNew();
            }
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
        }

      }
}
