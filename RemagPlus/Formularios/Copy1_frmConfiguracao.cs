using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;

namespace RemagPlus.Formularios
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
            LocalizaConfiguracao();
        }

        public string Remag
        {
            get { return textBoxRemag.Text;}
        }

        public string Sefip
        {
            get{return this.textBoxSefip.Text;}
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
        public TipoOperacao operacao;
        private void LocalizaConfiguracao()
        {
            remag_configuracao config = Globals.DataContext.remag_configuracao.FirstOrDefault(c => c.sefip != null || c.remag != null);
            if (config != null)
            {
                this.textBoxRemag.Text = config.remag;
                this.textBoxSefip.Text = config.sefip;
                operacao = TipoOperacao.Editando;
            }
            else
            {
                operacao = TipoOperacao.Adicionando;
            }
        }
    }
}
