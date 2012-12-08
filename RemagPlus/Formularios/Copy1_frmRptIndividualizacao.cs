using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Report;
using RemagPlus.Classes;

namespace RemagPlus.Formularios
{
    public partial class frmRptIndividualizacao : Form
    {
        public frmRptIndividualizacao()
        {
            InitializeComponent();
        }

        private void RadioButtonSelected(object sender, EventArgs e)
        {
            if (this.radioButtonCompetencia.Checked)
            {
                this.TextBoxConteudo.Mask = "00/0000";
                this.TextBoxConteudo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else if (this.radioButtonRecolhimento.Checked)
            {
                this.TextBoxConteudo.Mask = "00/00/0000";
                this.TextBoxConteudo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else if (this.radioButtonFuncionario.Checked)
            {
                this.TextBoxConteudo.Mask = "0.000.000.000-0";
                this.TextBoxConteudo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else if(this.radioButtonTodos.Checked)
            {
                this.TextBoxConteudo.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcoes function = new Funcoes();
            List<remag_individualizacao> individualizacao = new List<remag_individualizacao>();
            if (this.radioButtonFuncionario.Checked)
            {
                individualizacao = function.GetIndividualizacao(this.TextBoxConteudo.Text).ToList();
            }
            else if (this.radioButtonRecolhimento.Checked)
            {
                individualizacao = function.GetIndividualizacao(Convert.ToDateTime(this.TextBoxConteudo.Text)).ToList();
            }
            else if (this.radioButtonTodos.Checked)
            {
                individualizacao = function.GetIndividualizacao().ToList();
            }
            else if (this.radioButtonCompetencia.Checked)
            {
                individualizacao = function.GetIndividualizacao(this.TextBoxConteudo.Text,true).ToList();
            }
            if (individualizacao.Count > 0)
            {
                RptIndividualizacao report = new RptIndividualizacao(individualizacao);
                report.ShowPreview();
            }
            else
            {
                MessageBox.Show("Não foram feitas individualizações na competência e data de recolhimento informada.","Remag Plus",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
         
      }
    }
}
