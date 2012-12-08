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
    public partial class frmRptListaFuncionario : Form
    {
        public frmRptListaFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            DataEntities dataContext = new DataEntities();
            IList<remag_funcionario> funcionario = dataContext.GetFuncionarioDados(Globals.Empresa, this.radioButtonAtivo.Checked, this.radioButtonInativo.Checked, this.radioButtonNome.Checked, this.radioButtonPis.Checked);
            RptListaFuncionario lista = new RptListaFuncionario(funcionario);
            lista.ShowPreview();
        }
    }
}
