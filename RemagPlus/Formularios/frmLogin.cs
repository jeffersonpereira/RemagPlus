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
    public partial class frmLogin : Form
    {
        DataEntities dataContext;
        public frmLogin()
        {
            InitializeComponent();
            dataContext = new DataEntities();
        }
        int tentativas=3;
        private void button1_Click(object sender, EventArgs e)
        {
            CriarDB();
            string mensagem = string.Empty;
            if (Security.IsAutenticate(dataContext, this.textBoxLogin.Text, this.textBoxSenha.Text, out mensagem) && this.DialogResult == DialogResult.OK)
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

        private void CriarDB()
        {
            if (!dataContext.DatabaseExists())
            {
                MessageBox.Show("Banco de dados não existe.\nAguarde enquanto o sistema cria obanco de dados e preenche as tabelas padrões.", Mensagens.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataContext.CreateDatabase();
                frmPreencheTabelas form = new frmPreencheTabelas(dataContext);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataContext.CriarDadosPadroes();
                }
            }
        }
    }
}
