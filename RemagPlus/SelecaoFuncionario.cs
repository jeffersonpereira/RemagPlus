using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagLib;

namespace RemagPlus.Formularios
{
    public partial class SelecaoFuncionario : UserControl
    {
        public SelecaoFuncionario()
        {
            InitializeComponent();
        }

        DataEntities _dataContext;
        public void Bind(DataEntities dataContext)
        {
            _dataContext = dataContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaFuncionario form = new frmPesquisaFuncionario(_dataContext);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Funcionario = form.Funcionarios;
                this.bindingSource1.DataSource = Funcionario;
            }
        }

        public IList<remag_funcionario> Funcionario { get; set; }
    }
}
