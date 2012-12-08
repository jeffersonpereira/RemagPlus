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
    public partial class frmPesquisa: Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        public frmPesquisa(string titulo)
        {
            this.Text = titulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecutaPesquisa();
        }

        public virtual void ExecutaPesquisa()
        { }

        public object _entity;
        public void Seleciona()
        {
            _entity = null;
           _entity= listViewPesquisa.SelectedItems[0].Tag;
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleciona();
        }

        private void listViewPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seleciona();
            this.DialogResult = DialogResult.OK;
        }

    }
}
