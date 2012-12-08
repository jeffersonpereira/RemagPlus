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

namespace RemagPlus
{
    public partial class TelaGeraSefip : Form
    {
        public TelaGeraSefip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminho.Text = saveFileDialog1.FileName;
             
            }
        }

        private void GerarAqruivo()
        {
            string mensagem = string.Empty;
            DataEntities dataContext = new DataEntities();
            decimal valor;
            DateTime competencia;
            if (DateTime.TryParse(this.textBoxCompetencia.Text, out competencia))
            {
                List<remag_funcionario> funcionario = dataContext.GetFuncionarioDados(Globals.Empresa, competencia.ToFirstDay(), out valor).ToList();
                string dtAtrasoInss = this.radioButtonInssPrazo.Checked ? this.textBoxDtInss.Text : "00000000";
                string modalidade = (string)this.comboBoxModalidade.SelectedValue;
                int codPagamento = Convert.ToInt32(this.textBoxCodPagamento.Text);
                int codRecolhimento = Convert.ToInt32(this.comboBoxCodigo.SelectedValue);
                DateTime data;
                if (DateTime.TryParse(this.TextBoxData.Text, out data))
                {
                    data = Convert.ToDateTime(this.TextBoxData.Text);
                    ArquivoSefip sefip = new ArquivoSefip(competencia, funcionario, codRecolhimento, this.radioButtonInssAtraso.Checked, dtAtrasoInss, GetIndicado(), data, this.textBoxCaminho.Text, modalidade, codPagamento, out mensagem);
                    MessageBox.Show(mensagem, Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    remag_configuracao config = dataContext.GetConfiguracao();
                    if (config != null)
                    {
                        if (!string.IsNullOrEmpty(config.sefip))
                        {
                            if (MessageBox.Show("Deseja validar o arquivo agora?", Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start("sefip.exe", config.sefip);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Data de Recolhimento do FGTS é inválida.","RemagPlus",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Competência inválida.", "RemagPlus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IndicadorFGTS GetIndicado()
        {
            if (this.radioButtonFgtsPrazo.Checked)
            {
                return IndicadorFGTS.GRF_Prazo;
            }
            else if (this.radioButtonFgtsPrazo.Checked)
            {
                return IndicadorFGTS.GRF_Atraso;
            }
            else if (this.radioButtonFgtsAtrasoAcaoFiscal.Checked)
            {
                return IndicadorFGTS.GRF_Atraso_Acao_Fiscal;
            }
            else if (this.radioButtonIndividualizacao.Checked)
            {
                return IndicadorFGTS.Individualizacao;
            }
            else if (this.radioButtonIndividualizacaoAcaoFiscal.Checked)
            {
                return IndicadorFGTS.Individualizacao_Acao_Fiscal;
            }
            return IndicadorFGTS.GRF_Atraso;
        }

        private void PreencheCombo()
        {
           
            this.comboBoxCodigo.DataSource = Globals.CodigoRecolhimento;
            this.comboBoxCodigo.DisplayMember = "Descricao";
            this.comboBoxCodigo.ValueMember = "Codigo";

            this.comboBoxModalidade.DataSource = Globals.Modalidade;
            this.comboBoxModalidade.DisplayMember = "Descricao";
            this.comboBoxModalidade.ValueMember = "nome";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GerarAqruivo();
        }

        private void TelaGeraSefip_Load(object sender, EventArgs e)
        {
            PreencheCombo();
        }
    }
}
