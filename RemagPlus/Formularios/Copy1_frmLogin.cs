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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int tentativas=3;
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = string.Empty;
            if (Security.IsAutenticate(this.textBoxLogin.Text, this.textBoxSenha.Text, out mensagem) && this.DialogResult == DialogResult.OK)
            {
                  MessageBox.Show(mensagem, Mensagens.Titulo);
            }
            else if (tentativas >0)
            {
                tentativas--;
                MessageBox.Show(string.Format("Dados incorretos, você tem mais {0} oportunidade(s), após isso o sistema será encerrado.",tentativas), Mensagens.Titulo);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.No;
                MessageBox.Show("Não foi possível realizar a autenticação.", Mensagens.Titulo);
            }
        }
    }
}
