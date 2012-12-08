using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Report;

namespace RemagPlus.Formularios
{
    public partial class frmRptEstimativa : Form
    {
        public frmRptEstimativa()
        {
            InitializeComponent();
        }

        private void radioButtonSalarioMinimo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSalarioMinimo.Checked)
            {
                this.textBoxQtd.Enabled = true;
                MessageBox.Show("Para esta opção é necessário que a tabela de salário mínimo esteja preenchida corretamente.", "Remag Plus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.textBoxQtd.Enabled = false;
            }
        }

        private void radioButtonFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFuncionario.Checked)
            {
                this.maskedTextBoxFuncionario.Enabled = true;
                this.maskedTextBoxFuncionario.Mask = "0.000.000.000-0";
                this.maskedTextBoxFuncionario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                this.maskedTextBoxFuncionario.Enabled = false;
                this.maskedTextBoxFuncionario.Mask = string.Empty;
                this.maskedTextBoxFuncionario.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<remag_funcionario> funcionario = new List<remag_funcionario>();
            Funcoes function = new Funcoes();
            if (this.radioButtonFuncionario.Checked)
            {
                funcionario.AddRange(function.GetFuncionarioDados(this.maskedTextBoxFuncionario.Text).ToList());
            }
            else
            {
                funcionario = function.GetFuncionarioDados(DateTime.Parse("01/" + this.maskedTextBox1.Text), DateTime.Parse("01/"+ this.maskedTextBox2.Text)).ToList();
            }
            RptEstimativa report = new RptEstimativa(funcionario, DateTime.Parse(this.maskedTextBox1.Text), DateTime.Parse(this.maskedTextBox2.Text),this.radioButtonRemuneracao.Checked,decimal.Parse(this.textBoxQtd.Text));
            report.ShowPreview();
        }
    }
}
