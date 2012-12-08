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

namespace RemagPlus.Formularios
{
    public partial class frmFuncionario : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle = new Controles();
        public frmFuncionario()
        {
            InitializeComponent();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            Configura();
        }

        TipoOperacao operacao;
        private void Pesquisa()
        {
            Pesquisa<remag_funcionario> pesquisa = new Pesquisa<remag_funcionario>("remag_funcionario", new string[] { "pis", "nome" }, new int[] { 100, 250 }, new string[] { "Pis/Pasep", "Nome" }, "Funcionário", true,Globals.Empresa,true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceFuncionario.DataSource = pesquisa._entity;
                    _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
                }
                pesquisa.Close();
            }
        }

        private void Update()
        {
            this.bindingSourceFuncionario.EndEdit();
            Crud<remag_funcionario>.Update((remag_funcionario)this.bindingSourceFuncionario.Current);
        }

        private void Insert()
        {
            remag_funcionario funcionario = (remag_funcionario)this.bindingSourceFuncionario.Current;
            funcionario.Empresa = Globals.Empresa;
            if (IsValid(funcionario))
            {
                Crud<remag_funcionario>.New(funcionario);
            }
        }

        private void Excluir()
        {
            remag_funcionario funcionario = (remag_funcionario)this.bindingSourceFuncionario.Current;
            if (!IsValores(funcionario))
            {
                Crud<remag_funcionario>.Delete(funcionario);
                this.bindingSourceFuncionario.Clear();
                _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Excluindo);
            }
            else
            {
                MessageBox.Show("Operação não permitida! Existem individualizações para este funcionário.",Mensagens.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceFuncionario.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
            this.tabControl1.TabIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Editando);
            operacao = TipoOperacao.Editando;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClearDateMovimentacion();
            if (operacao == TipoOperacao.Adicionando)
            {
                Insert();
            }
            else if (operacao == TipoOperacao.Editando)
            {
                Update();
            }
            remag_funcionario funcionario = (remag_funcionario)this.bindingSourceFuncionario.Current;
            if(IsValid(funcionario))
            {
                if (Crud<remag_funcionario>.SaveAll())
                {
                    _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
                    MessageBox.Show(Mensagens.Salvo, Mensagens.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.bindingSourceFuncionario.Clear();
                    this.btnNovo.Enabled = true;
                    this.btnPesquisa.Enabled = true;
                    this.tabControl1.TabIndex = 0;
                }
            }
        }

        private void ClearDateMovimentacion()
        {
            if (((remag_funcionario)this.bindingSourceFuncionario.Current).remag_codigo_movimentacao == null)
            {
                ((remag_funcionario)this.bindingSourceFuncionario.Current).data_demissao = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = TipoOperacao.Excluindo;
            if (MessageBox.Show(Mensagens.PerguntaExclusao, Mensagens.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Excluir();
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Lookups
        private void Configura()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_funcionario)dataSource).Municipio = value;
            };
            this.pesquisaControlCidade.Bind<remag_municipio>("remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setMunicipio,false);

            SetValue<remag_categoria> setCategoria = delegate(object dataSource, remag_categoria value)
            {
                ((remag_funcionario)dataSource).Categoria = value;
            };
            this.pesquisaControlCategoria.Bind<remag_categoria>("remag_categoria", new string[] { "descricao", "categoria_id" }, new string[] { "Descrição", "Categoria" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setCategoria,false);

            SetValue<remag_cbo> setCbo = delegate(object dataSource, remag_cbo value)
            {
                ((remag_funcionario)dataSource).CBO = value;
            };
            this.pesquisaControlCbo.Bind<remag_cbo>("remag_cbo", new string[] { "descricao", "cbo" }, new string[] { "Descrição", "CBO" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setCbo,false);

            SetValue<remag_admissao_numerica> setAdmissaoNumerica = delegate(object dataSource, remag_admissao_numerica value)
            {
                ((remag_funcionario)dataSource).AdmissaoNumerica = value;
            };
            this.pesquisaControlAdmissaoNumerica.Bind<remag_admissao_numerica>("remag_admissao_numerica", new string[] { "descricao", "codigo" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setAdmissaoNumerica, false);

            SetValue<remag_admissao_alfanumerica> setAdmissaoAlfanumerica = delegate(object dataSource, remag_admissao_alfanumerica value)
            {
                ((remag_funcionario)dataSource).AdmissaoAlfa = value;
            };
            this.pesquisaControlAdmissaoAlfa.Bind<remag_admissao_alfanumerica>("remag_admissao_alfanumerica", new string[] { "descricao", "codigo" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setAdmissaoAlfanumerica,false);

            SetValue<remag_codigo_movimentacao> setMovimentacao = delegate(object dataSource, remag_codigo_movimentacao value)
            {
                ((remag_funcionario)dataSource).Movimentacao = value;
            };
            this.pesquisaControlMovimento.Bind<remag_codigo_movimentacao>("remag_codigo_movimentacao", new string[] { "descricao", "codigo_movimentacao" }, new string[] { "Descrição", "Código" }, new int[] { 300, 50 }, this.bindingSourceFuncionario, setMovimentacao,false);
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.CheckState == CheckState.Checked)
            {
                Funcoes function = new Funcoes();
                List<remag_individualizacao> salario = function.GetIndividualizacao(((remag_funcionario)this.bindingSourceFuncionario.Current).pis);
                this.bindingSourceIndividualizacao.DataSource = salario;
                decimal jam=decimal.Zero;
                decimal deposito=decimal.Zero;
                decimal deposito13=decimal.Zero;
                foreach (remag_individualizacao ind in salario)
                {
                    jam += ind.valor_jam;
                    deposito += ind.valor_deposito;
                    deposito13 += ind.valor_deposito13;
                }

                this.labelJam.Text = jam.ToString("c");
                this.labelDeposito.Text = deposito.ToString("c");
                this.labelDeposito13.Text = deposito13.ToString("c");
            }
            else
            {
                this.dataGridView1.DataSource = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceFuncionario.CancelEdit();
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Cancelando);
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceFuncionario.ResetAllowNew();
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            }
            this.btnPesquisa.Enabled = true;
        }

        private void NextControl(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !key.Shift, true, true, true);
            }
        }

        private bool IsValid(remag_funcionario funcionario)
        {
            List<string> mensagens = new List<string>();
            bool valido=true;
            if (string.IsNullOrEmpty(funcionario.pis))
            {
                mensagens.Add("Campo Pis/Pasep é obrigatório.");
                valido=false;
            }
            if (!Docs.ValidaPIS(funcionario.pis))
            {
                mensagens.Add("Pis/Pasep não é válido.");
                valido=false;
            }
            if (string.IsNullOrEmpty(funcionario.ctps) || string.IsNullOrEmpty(funcionario.serie))
            {
                mensagens.Add("CTPS e Série são obrigatórios.");
                valido = false;
            }
            if (funcionario.Municipio==null)
            {
                mensagens.Add("Município é obrigatório.");
                valido = false;
            }
            if (funcionario.CBO == null)
            {
                mensagens.Add("CBO é obrigatório.");
                valido = false;
            }
            if (funcionario.Municipio == null)
            {
                mensagens.Add("Município é obrigatório.");
                valido = false;
            }
            if (funcionario.Categoria == null)
            {
                mensagens.Add("Categoria é obrigatória.");
                valido = false;
            }
            if (funcionario.AdmissaoNumerica == null)
            {
                mensagens.Add("Código de Admissão Numerica é obrigatório.");
                valido = false;
            }
            if (funcionario.AdmissaoAlfa == null)
            {
                mensagens.Add("Código de Admissão Alfa Numerica é obrigatório.");
                valido = false;
            }
            if (funcionario.Movimentacao != null && !funcionario.data_demissao.HasValue)
            {
                mensagens.Add("Você informou uma movimentação, mas não informou uma data de movimentação.");
                valido = false;
            }
            if (funcionario.Movimentacao == null && funcionario.data_demissao.HasValue)
            {
                mensagens.Add("Você informou uma data  de movimentação, mas não informou uma movimentação.");
                valido = false;
            }
            if (!valido)
            {
                string erro = string.Empty;
                foreach (string msn in mensagens)
                {
                    erro += msn + "\n";
                }
                MessageBox.Show(erro,"Remag Plus",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            return valido;
        }

        private bool IsValores(remag_funcionario funcionario)
        {
            return Globals.DataContext.remag_individualizacao.FirstOrDefault(i => i.funcionario_id == funcionario.funcionario_id)!=null;
        }

    }
}
