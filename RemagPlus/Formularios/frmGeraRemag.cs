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
    public partial class frmGeraRemag : Form
    {
        public frmGeraRemag()
        {
            InitializeComponent();
            PreencheCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminho.Text = saveFileDialog1.FileName;
            }
        }
        private void GerarAqruivo()
        {
            DateTime competencia;
            DateTime recolhimento;
            if (!string.IsNullOrEmpty(this.textBoxCaminho.Text))
            {
                if (DateTime.TryParse(this.textBoxCompetencia.Text, out competencia) && DateTime.TryParse(this.textBoxRecolhimento.Text, out recolhimento))
                {
                    DataEntities dataContext = new DataEntities();
                    decimal valor;
                    List<remag_funcionario> funcionario = dataContext.GetFuncionarioDados(Globals.Empresa, competencia.ToLastDay(), out valor).ToList();
                    string mensagem = string.Empty;
                    ArquivoRemag remag = new ArquivoRemag(competencia, recolhimento, this.textBoxCaminho.Text, funcionario.OrderBy<remag_funcionario,string>(f=>f.pis), out mensagem);
                    remag_configuracao config = dataContext.GetConfiguracao();
                    if (config != null)
                    {
                        if (!string.IsNullOrEmpty(config.remag))
                        {
                            if (MessageBox.Show("Deseja validar o arquivo agora?", Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("FGTS.EXE", config.remag);
                            }
                        }
                    }
                    MessageBox.Show(mensagem, Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data de recolhimento ou competência não correspondem a uma data válida.", Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um local para a gravação do arquivo.", Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencheCombo()
        {
            List<ComboPreenchido> combo = new List<ComboPreenchido>();
            combo.Add(new ComboPreenchido(027, "027 - Parcelamento Administrativo"));
            this.comboBoxCodigo.DataSource = combo;
            this.comboBoxCodigo.DisplayMember = "Descricao";
            this.comboBoxCodigo.ValueMember = "Codigo";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GerarAqruivo();
        }
    }
}
