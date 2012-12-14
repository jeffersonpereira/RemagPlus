using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RemagPlus.Classes;
using System.Threading;
using RemagLib;

namespace RemagPlus.Formularios
{
    public partial class frmSelecionaEmpresa : Form
    {
        public frmSelecionaEmpresa()
        {
            InitializeComponent();
            Empresas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Empresas()
        {
            this.comboBox1.DataSource = new DataEntities().remag_empresa.ToList();
            this.comboBox1.DisplayMember = "razao_social";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.Empresa = (remag_empresa)this.comboBox1.SelectedItem;
            Close();
        }

    }
}
