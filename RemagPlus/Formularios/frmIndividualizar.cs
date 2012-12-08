using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using System.Data.Common;
using RemagLib;


namespace RemagPlus
{
    public partial class IndividualizarForm : Form
    {
        DataEntities dataContext;
        public IndividualizarForm()
        {
            InitializeComponent();
            dataContext = new DataEntities();
        }

        private void IndividualizarForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Pis/Pasep",100,HorizontalAlignment.Center);
            listView1.Columns.Add("Nome", 180, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor JAM", 90, HorizontalAlignment.Right);
            listView1.Columns.Add("Valor Depósito", 90, HorizontalAlignment.Right);
            listView1.Columns.Add("Valor Depósito 13°", 100, HorizontalAlignment.Right);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            this.TextBoxRecolhimento.Text = DateTime.Today.ToString();
            this.txtCompetencia.Text = DateTime.Today.ToString("MM/yyyy");
        }
        private void Individualizar(DateTime competencia,DateTime recolhimento)
        {
            decimal totalRemuneracao;
            IList<remag_funcionario> funcionario = dataContext.GetFuncionarioDados(Globals.Empresa, competencia.ToLastDay(), out totalRemuneracao);
            this.progressBar1.Maximum = funcionario.Count;
            int controle = 1;
            listView1.Items.Clear();
            decimal jamValor = Convert.ToDecimal(this.textBoxJam.Text);
            decimal depositoValor = Convert.ToDecimal(this.textBoxDeposito.Text);
            decimal deposito13Valor = Convert.ToDecimal(this.textBoxDeposito13.Text);
            decimal jamTotal = decimal.Zero;
            decimal depositoTotal = decimal.Zero;
            decimal deposito13Total = decimal.Zero;
            foreach (remag_funcionario f in funcionario.ToList())
            {
                decimal jam = decimal.Zero;
                decimal deposito=decimal.Zero;
                decimal deposito13=decimal.Zero;
                decimal base_calc = decimal.Zero;
                if (this.radioButtonNormal.Checked)
                {
                    dataContext.Individualiza(f, totalRemuneracao, depositoValor, deposito13Valor, jamValor, out jam, out deposito, out deposito13);
                    base_calc = f.remuneracao;
                }
                else if (this.radioButtonRateio.Checked)
                {
                    dataContext.Individualiza(depositoValor, deposito13Valor, jamValor, funcionario.Count, out jam, out deposito, out deposito13);
                    base_calc = f.remuneracao;
                }
                else if (this.radioButtonSalarioMinimo.Checked)
                {
                    dataContext.Individualiza(competencia, depositoValor, deposito13Valor, jamValor, out jam, out deposito, out deposito13);
                    base_calc = dataContext.GetSalarioMinimo(competencia) * decimal.Parse(this.textBoxQtd.Text);
                }
                if (controle == 1)
                {
                    if ((depositoValor / funcionario.Count) < 0.01M)
                    {
                        deposito += depositoValor;
                    }
                    if ((deposito13Valor / funcionario.Count) < 0.01M)
                    {
                        deposito13 += deposito13Valor;
                    }
                    if ((jamValor / funcionario.Count) < 0.01M)
                    {
                        jam += jamValor;
                    }
                }
                jamTotal += jam;
                depositoTotal += deposito;
                deposito13Total += deposito13;
                //TODO: Verifica se o valor individualizado é igual ao informado, se não for põe a diferença para o ultimo funcionário
                if (controle == funcionario.Count)
                {
                    if (!jamTotal.Equals(jamValor) || !depositoTotal.Equals(depositoValor) || !deposito13Total.Equals(deposito13Valor))
                    {
                        if (jamTotal < jamValor)
                        {
                            jam += decimal.Subtract(jamValor, jamTotal);
                        }
                        else
                        {
                            jam -= decimal.Subtract(jamTotal, jamValor);
                        }
                        if (depositoTotal < depositoValor)
                        {
                            deposito += decimal.Subtract(depositoValor, depositoTotal);
                        }
                        else
                        {
                            deposito -= decimal.Subtract(depositoTotal, depositoValor);
                        }
                        if (deposito13Total < deposito13Valor)
                        {
                            deposito13 += decimal.Subtract(deposito13Valor, deposito13Total);
                        }
                        else
                        {
                            deposito13 -= decimal.Subtract(deposito13Total, deposito13Valor);
                        }
                    }

                }
                AddIndivividualizacao(f, jam, deposito, deposito13, base_calc, this.radioButtonSalarioMinimo.Checked, this.radioButtonRateio.Checked, this.radioButtonNormal.Checked, competencia.ToString("MM/yyyy"), recolhimento);
                ListViewItem item = this.listView1.Items.Add(f.pis);
                    item.SubItems.Add(f.nome);
                    item.SubItems.Add(jam.ToString("c"));
                    item.SubItems.Add(deposito.ToString("c"));
                    item.SubItems.Add(deposito13.ToString("c"));
                this.progressBar1.Value = controle;
                 controle++;
            }
            if (dataContext.SaveChanges() > 0)
            {
                MessageBox.Show("Individualização realizada com sucesso", Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddIndivividualizacao(remag_funcionario funcionario, decimal jam, decimal deposito, decimal deposito13, decimal baseCalculo, bool isSalarioMinimo, bool isRateio, bool isNormal,string competencia,DateTime recolhimento)
        {
            remag_individualizacao ind = new remag_individualizacao
            {
                valor_jam=jam,
                valor_deposito=deposito,
                valor_deposito13=deposito13,
                base_calculo=baseCalculo,
                salario_minimo=isSalarioMinimo,
                rateio=isRateio,
                proporcional=isNormal,
                competencia=competencia,
                data_recolhimento=recolhimento,
                remag_funcionario=funcionario,
                data_individualizacao=DateTime.Today
            };
            dataContext.AddToremag_individualizacao(ind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime competencia;
            DateTime recolhimento;
            if (DateTime.TryParse(this.txtCompetencia.Text, out competencia) && DateTime.TryParse(this.TextBoxRecolhimento.Text, out recolhimento))
            {
                Individualizar(competencia,recolhimento);
            }
            else
            {
                MessageBox.Show("Data de recolhimento ou competência não correspondem a uma data válida.","Remag Plus",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime competencia;
            DateTime recolhimento;
            if (DateTime.TryParse(this.txtCompetencia.Text, out competencia) && DateTime.TryParse(this.TextBoxRecolhimento.Text, out recolhimento))
            {
                Desfazer(competencia,recolhimento);
            }
            else
            {
                MessageBox.Show("Data de recolhimento ou competência não correspondem a uma data válida.", "Remag Plus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Desfazer(DateTime competencia,DateTime recolhimento)
        {
            string mensagem = string.Empty;
            int registros=dataContext.DeleteIndividualizacao(Globals.Empresa, competencia, recolhimento);
            if (registros>0)
            {
                MessageBox.Show(string.Format("{0} registros foram excluídos de seu banco de dados.", registros));
            }
            else
            {
                MessageBox.Show("Nenhum registro foi excluído.");
            }
        }

        private void radioButtonSalarioMinimo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSalarioMinimo.Checked)
            {
                this.textBoxQtd.Enabled = true;
                MessageBox.Show("Para este opção é necessário informar a quatidade de salários mínimos.");
            }
            else
            {
                this.textBoxQtd.Enabled = false;
            }
        }

     }
}
