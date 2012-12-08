using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemagPlus.Formularios
{
    public partial class frmConsultaValor : Form
    {
        public frmConsultaValor()
        {
            InitializeComponent();
            ConfigListView();
        }

        private void ConfigListView()
        {
            this.listViewConsulta.Columns.Add("Pis/Pasep", 80, HorizontalAlignment.Right);
            this.listViewConsulta.Columns.Add("Funcionário", 250, HorizontalAlignment.Left);
            this.listViewConsulta.Columns.Add("Competência", 150, HorizontalAlignment.Left);
            this.listViewConsulta.Columns.Add("Recolhimento", 150, HorizontalAlignment.Left);
            this.listViewConsulta.Columns.Add("JAM", 80, HorizontalAlignment.Right);
            this.listViewConsulta.Columns.Add("Depósito", 80, HorizontalAlignment.Right);
            this.listViewConsulta.Columns.Add("Deposíto 13°", 80, HorizontalAlignment.Right);
            this.listViewConsulta.FullRowSelect = true;
            this.listViewConsulta.View = View.Details;
            this.labelDeposito.Text = "0,00";
            this.labelDeposito13.Text = "0,00";
            this.labelJam.Text = "0,00";
        }

        private void DoConsulta()
        {
            Funcoes function = new Funcoes();
            List<remag_individualizacao> individualizacao = new List<remag_individualizacao>();
            if (radioButtonGeral.Checked)
            {
                individualizacao = function.GetIndividualizacao();
            }
            else if (radioButtonFuncionario.Checked)
            {
                individualizacao = function.GetIndividualizacao(TextBoxPesquisa.Text);
            }
            else if (radioButtonDataRecolhimento.Checked)
            {
                individualizacao = function.GetIndividualizacao(Convert.ToDateTime(TextBoxPesquisa.Text));
            }
            else if (radioButtonCompetencia.Checked)
            {
                individualizacao = function.GetIndividualizacao(TextBoxPesquisa.Text,true);
            }
            decimal jam = decimal.Zero;
            decimal deposito = decimal.Zero;
            decimal deposito13 = decimal.Zero;
            this.listViewConsulta.Items.Clear();
            foreach (remag_individualizacao ind in individualizacao)
            {
                ListViewItem item = this.listViewConsulta.Items.Add(ind.remag_funcionario.pis);
                item.SubItems.Add(ind.remag_funcionario.nome);
                item.SubItems.Add(ind.competencia);
                item.SubItems.Add(ind.data_recolhimento.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ind.valor_jam.ToString("c"));
                item.SubItems.Add(ind.valor_deposito.ToString("c"));
                item.SubItems.Add(ind.valor_deposito13.ToString("c"));
                jam += ind.valor_jam;
                deposito += ind.valor_deposito;
                deposito13 += ind.valor_deposito13;
            }
            this.labelDeposito.Text = deposito.ToString("c");
            this.labelDeposito13.Text = deposito13.ToString("c");
            this.labelJam.Text = jam.ToString("c");
        }

        private void ChangedRadionButton(object sender, EventArgs e)
        {
            if (radioButtonGeral.Checked)
            {
                this.labelTitulo.Text = "Geral";
                this.TextBoxPesquisa.Mask = string.Empty;
                this.TextBoxPesquisa.Enabled = false;
            }
            else if (radioButtonFuncionario.Checked)
            {
                this.TextBoxPesquisa.Enabled = true;
                this.TextBoxPesquisa.Mask = "0.000.000.000-0";
                this.TextBoxPesquisa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                this.labelTitulo.Text = "Pis/Pasep";
            }
            else if (radioButtonDataRecolhimento.Checked)
            {
                this.TextBoxPesquisa.Enabled = true;
                this.TextBoxPesquisa.Mask = "00/00/0000";
                this.labelTitulo.Text = "Data de Recolhimento";
            }
            else if (radioButtonCompetencia.Checked)
            {
                this.TextBoxPesquisa.Enabled = true;
                this.TextBoxPesquisa.Mask = "00/0000";
                this.labelTitulo.Text = "Competência";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoConsulta();
        }
    }
}
