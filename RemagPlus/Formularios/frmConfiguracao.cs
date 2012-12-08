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
    public partial class frmConfiguracao : Form
    {
        DataEntities dataContext;
        public frmConfiguracao()
        {
            InitializeComponent();
            dataContext = new DataEntities();
            LocalizaConfiguracao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxSefip.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialogRemag.ShowDialog() == DialogResult.OK)
            {
                this.textBoxRemag.Text = openFileDialogRemag.FileName;
            }
        }

        private void LocalizaConfiguracao()
        {
            remag_configuracao config = dataContext.remag_configuracao.FirstOrDefault(c => c.sefip != null || c.remag != null);
            if (config == null)
            {
                config = new remag_configuracao();
                dataContext.AddToremag_configuracao(config);
            }

            this.bindingSource1.DataSource = config;
        }

        private void frmConfiguracao_FormClosed(object sender, FormClosedEventArgs e)
        {
            remag_configuracao config = this.bindingSource1.Current as remag_configuracao;
            if (!string.IsNullOrWhiteSpace(config.sefip) || !string.IsNullOrWhiteSpace(config.remag))
            {
                dataContext.SaveChanges();
            }
        }
    }
}
