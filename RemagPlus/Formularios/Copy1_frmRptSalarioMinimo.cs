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
    public partial class frmRptSalarioMinimo : Form
    {
        public frmRptSalarioMinimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcoes function =new Funcoes();
            List<remag_salario_minimo> salario = new List<remag_salario_minimo>();
            if (this.radioButtonTodos.Checked)
            {
                salario = function.GetSalarioMinimo();
            }
            else
            {
                salario = function.GetSalarioMinimo(Convert.ToDateTime(this.TextBoxDataI.Text), Convert.ToDateTime(this.TextBoxDataF.Text));
            }
            RptSalarioMinimo report = new RptSalarioMinimo(salario);
            report.ShowPreview();
        }
    }
}
