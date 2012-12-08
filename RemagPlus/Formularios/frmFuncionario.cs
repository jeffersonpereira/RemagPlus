using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using RemagPlus.Formularios;
using Validates;
using RemagLib;

namespace RemagPlus.Formularios
{
    public partial class frmFuncionario : BaseForm
    {

        public frmFuncionario()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceFuncionario, "remag_funcionario");
            Configura();
        }


        protected override void Pesquisa()
        {
            Pesquisa<remag_funcionario> pesquisa = new Pesquisa<remag_funcionario>(dataContext, "remag_funcionario", new string[] { "pis", "nome" }, new int[] { 100, 250 }, new string[] { "Pis/Pasep", "Nome" }, "Funcionário", true,Globals.Empresa,true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceFuncionario.DataSource = pesquisa._entity;
                    if (pesquisa._entity != null)
                    {
                        HabilitarDesabilitaBotoes();
                    }
                }
                pesquisa.Close();
            }
        }

        #region Lookups
        private void Configura()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_funcionario)dataSource).Municipio = value;
            };
            this.pesquisaControlCidade.Bind<remag_municipio>(dataContext, "Município", "remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setMunicipio, false);

            SetValue<remag_categoria> setCategoria = delegate(object dataSource, remag_categoria value)
            {
                ((remag_funcionario)dataSource).Categoria = value;
            };
            this.pesquisaControlCategoria.Bind<remag_categoria>(dataContext, "Categoria SEFIP", "remag_categoria", new string[] { "descricao", "categoria_id" }, new string[] { "Descrição", "Categoria" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setCategoria, false);

            SetValue<remag_cbo> setCbo = delegate(object dataSource, remag_cbo value)
            {
                ((remag_funcionario)dataSource).CBO = value;
            };
            this.pesquisaControlCbo.Bind<remag_cbo>(dataContext, "Classificação Brasileira de Ocupação", "remag_cbo", new string[] { "descricao", "cbo" }, new string[] { "Descrição", "CBO" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setCbo, false);

            SetValue<remag_admissao_numerica> setAdmissaoNumerica = delegate(object dataSource, remag_admissao_numerica value)
            {
                ((remag_funcionario)dataSource).AdmissaoNumerica = value;
            };
            this.pesquisaControlAdmissaoNumerica.Bind<remag_admissao_numerica>(dataContext, "Código de Admissão Numerico", "remag_admissao_numerica", new string[] { "descricao", "codigo" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setAdmissaoNumerica, false);

            SetValue<remag_admissao_alfanumerica> setAdmissaoAlfanumerica = delegate(object dataSource, remag_admissao_alfanumerica value)
            {
                ((remag_funcionario)dataSource).AdmissaoAlfa = value;
            };
            this.pesquisaControlAdmissaoAlfa.Bind<remag_admissao_alfanumerica>(dataContext, "Código de Admissão Alfanumerico", "remag_admissao_alfanumerica", new string[] { "descricao", "codigo" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setAdmissaoAlfanumerica, false);

            SetValue<remag_codigo_movimentacao> setMovimentacao = delegate(object dataSource, remag_codigo_movimentacao value)
            {
                ((remag_funcionario)dataSource).Movimentacao = value;
            };
            this.pesquisaControlMovimento.Bind<remag_codigo_movimentacao>(dataContext, "Código de Movimentação", "remag_codigo_movimentacao", new string[] { "descricao", "codigo_movimentacao" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setMovimentacao, false);
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.CheckState == CheckState.Checked)
            {
                remag_funcionario funcionario = (remag_funcionario)this.bindingSourceFuncionario.Current;
                if (funcionario != null)
                {
                    this.bindingSourceIndividualizacao.DataSource = funcionario.remag_individualizacao;
                    decimal jam = funcionario.remag_individualizacao.Select(i => i.valor_jam).DefaultIfEmpty(decimal.Zero).Sum();
                    decimal deposito = funcionario.remag_individualizacao.Select(i => i.valor_deposito).DefaultIfEmpty(decimal.Zero).Sum();
                    decimal deposito13 = funcionario.remag_individualizacao.Select(i => i.valor_deposito13).DefaultIfEmpty(decimal.Zero).Sum();

                    this.labelJam.Text = jam.ToString("c");
                    this.labelDeposito.Text = deposito.ToString("c");
                    this.labelDeposito13.Text = deposito13.ToString("c");
                }
            }
            else
            {
                this.dataGridView1.DataSource = null;
                this.labelJam.Text = decimal.Zero.ToString("c");
                this.labelDeposito.Text = decimal.Zero.ToString("c");
                this.labelDeposito13.Text = decimal.Zero.ToString("c");
            }
        }


        private void NextControl(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !key.Shift, true, true, true);
            }
        }

        protected override List<string>  GetErros()
        {
            List<string> mensagens = new List<string>();

            remag_funcionario funcionario = this.bindingSourceFuncionario.Current as remag_funcionario;
            if (string.IsNullOrEmpty(funcionario.pis))
            {
                mensagens.Add("Campo Pis/Pasep é obrigatório.");
            }
            if (!Docs.ValidaPIS(funcionario.pis))
            {
                mensagens.Add("Pis/Pasep não é válido.");
            }
            if (string.IsNullOrEmpty(funcionario.ctps) || string.IsNullOrEmpty(funcionario.serie))
            {
                mensagens.Add("CTPS e Série são obrigatórios.");
            }
            if (funcionario.Municipio==null)
            {
                mensagens.Add("Município é obrigatório.");
            }
            if (funcionario.CBO == null)
            {
                mensagens.Add("CBO é obrigatório.");
            }
            if (funcionario.Municipio == null)
            {
                mensagens.Add("Município é obrigatório.");
            }
            if (funcionario.Categoria == null)
            {
                mensagens.Add("Categoria é obrigatória.");
            }
            if (funcionario.AdmissaoNumerica == null)
            {
                mensagens.Add("Código de Admissão Numerica é obrigatório.");
            }
            if (funcionario.AdmissaoAlfa == null)
            {
                mensagens.Add("Código de Admissão Alfa Numerica é obrigatório.");
            }
            if (funcionario.Movimentacao != null && !funcionario.data_demissao.HasValue)
            {
                mensagens.Add("Você informou uma movimentação, mas não informou uma data de movimentação.");
            }
            if (funcionario.Movimentacao == null && funcionario.data_demissao.HasValue)
            {
                mensagens.Add("Você informou uma data  de movimentação, mas não informou uma movimentação.");
            }
            if (dataContext.remag_funcionario.Any(f => f.pis == funcionario.pis && f.empresa_id == Globals.Empresa.empresa_id))
            {
                mensagens.Add("Já existe um funcionário com este PIS.");
            }
            return mensagens;
        }

        private bool IsValores(remag_funcionario funcionario)
        {
            return Globals.DataContext.remag_individualizacao.FirstOrDefault(i => i.funcionario_id == funcionario.funcionario_id)!=null;
        }

    }
}
