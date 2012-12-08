using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using RemagLib;

namespace RemagPlus.Formularios
{
    public partial class frmAlteracaoSalarial : Form
    {
        public frmAlteracaoSalarial()
        {
            InitializeComponent();
        }


        private void radioButtonPorFaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPorFaixa.Checked)
            {
                this.groupBoxFaixa.Enabled = true;
            }
            else
            {
                this.textBoxValorI.Clear();
                this.textBoxValorF.Clear();
                this.groupBoxFaixa.Enabled = false;
            }
        }

        private void Alterar()
        {
            DataEntities dataContext = new DataEntities();
            List<remag_funcionario> funcionario = dataContext.GetFuncionarioDados(Globals.Empresa).ToList();
            if (this.radioButtonPorFaixa.Checked)
            {
                funcionario = dataContext.GetFuncionarioDados(Globals.Empresa,decimal.Parse(this.textBoxValorI.Text), decimal.Parse(this.textBoxValorF.Text)).ToList();
            }
            else if (this.radioButtonIndividual.Checked)
            {
                funcionario = dataContext.GetFuncionarioDados(Globals.Empresa, this.TextBoxPis.Text).ToList();
            }
            foreach (remag_funcionario f in funcionario)
            {
                remag_funcionario fu = dataContext.remag_funcionario.FirstOrDefault(fun => fun.funcionario_id == f.funcionario_id);
                if (this.radioButtonSalarioMinimo.Checked)
                {
                    f.remuneracao = dataContext.GetSalarioMinimo(Convert.ToDateTime(this.TextBoxVigenciaValor.Text)) * int.Parse(this.textBoxQtd.Text);
                }
                else
                {
                    f.remuneracao = decimal.Parse(this.TextBoxVigenciaValor.Text);
                }

            }
            if (dataContext.SaveChanges() > 0)
            {
                MessageBox.Show("Salário alterado com sucesso!", Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTodos.Checked)
            {
                this.groupBoxFaixa.Enabled = false;
            }
        }

        private void radioButtonValor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonValor.Checked)
            {
                this.labelTituloVigenciaValor.Text = "Valor";
                this.TextBoxVigenciaValor.Mask = string.Empty;
                this.textBoxQtd.Enabled = false;
            }
        }

        private void radioButtonIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonIndividual.Checked)
            {
                this.TextBoxPis.Enabled = true;
                this.TextBoxPis.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                this.groupBoxFaixa.Enabled = false;
            }
            else
            {
                this.TextBoxPis.Enabled = false;
            }
        }

        private void radioButtonPorFaixa_CheckedChanged_1(object sender, EventArgs e)
        {
           if(this.radioButtonPorFaixa.Checked)
            {
                this.groupBoxFaixa.Enabled = true;
            }
        }

        private void radioButtonSalarioMinimo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSalarioMinimo.Checked)
            {
                this.labelTituloVigenciaValor.Text = "Vigência";
                this.TextBoxVigenciaValor.Mask = "00/00/0000";
                this.textBoxQtd.Enabled = true;
            }
        }
    }
}
