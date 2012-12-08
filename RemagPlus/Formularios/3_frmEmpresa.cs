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
    public partial class frmEmpresa : Form
    {
        Funcoes _funcao = new Funcoes();
        Controles _controle = new Controles();
        public frmEmpresa()
        {
            InitializeComponent();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
            ConfiguraBindingSource();
            this.btnEditar.Enabled = true;
            this.bindingSourceEmpresa.DataSource = Globals.Empresa;
        }

        TipoOperacao operacao;
        private void Pesquisa()
        {
            Pesquisa<remag_empresa> pesquisa = new Pesquisa<remag_empresa>("remag_empresa", new string[] { "cnpj", "razao_social" }, new int[] { 100, 250 }, new string[] { "CNPJ", "Razão Social" }, "Empresa",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceEmpresa.DataSource = pesquisa._entity;
                }
                pesquisa.Close();
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Pesquisando);
            }
        }

        private void Update()
        {
            this.bindingSourceEmpresa.EndEdit();
            remag_empresa empresa = (remag_empresa)this.bindingSourceEmpresa.Current;
            if(IsValid(empresa))
            {
                Crud<remag_empresa>.Update(empresa);
            }
        }

        private void Insert()
        {
            remag_empresa empresa = (remag_empresa)this.bindingSourceEmpresa.Current;
            if (IsValid(empresa))
            {
                Crud<remag_empresa>.New(empresa);
            }
        }

        private void Excluir()
        {
            Crud<remag_empresa>.Delete((remag_empresa)this.bindingSourceEmpresa.Current);
            _controle.HabilitaDesabilitaButtons(this.toolStrip1, TipoOperacao.Excluindo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Adicionando)
            {
                Insert();
            }
            else if (operacao == TipoOperacao.Editando)
            {
                Update();
            }
            if (Crud<remag_empresa>.SaveAll())
            {
                _controle.HabilitaDesabilitaControles(this, TipoOperacao.Salvando);
                MessageBox.Show(Mensagens.Salvo);
                this.bindingSourceEmpresa.Clear();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceEmpresa.AddNew();
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Adicionando);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = TipoOperacao.Editando;
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Editando);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Configura Binding Source
        private void ConfiguraBindingSource()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_empresa)dataSource).Municipio = value;
            };
            this.pesquisaControlCidade.Bind<remag_municipio>("remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 50 }, this.bindingSourceEmpresa, setMunicipio,false);

            SetValue<remag_responsavel> setResponsavel = delegate(object dataSource, remag_responsavel value)
            {
                ((remag_empresa)dataSource).Responsavel = value;
            };
            this.pesquisaControlResponsavel.Bind<remag_responsavel>("remag_responsavel", new string[] { "nome", "cnpj_cei_cpf" }, new string[] { "Nome", "Inscrição" }, new int[] { 250, 100 }, this.bindingSourceEmpresa, setResponsavel,false);

            SetValue<remag_categoria_empregador> setCategoria = delegate(object dataSource, remag_categoria_empregador value)
            {
                ((remag_empresa)dataSource).CategoriaEmpresa = value;
            };
            this.pesquisaControlCategoriaEmpresa.Bind<remag_categoria_empregador>("remag_categoria_empregador", new string[] { "descricao", "categoria_empregador_id" }, new string[] { "Descrição", "Código" }, new int[] { 300, 60 }, this.bindingSourceEmpresa, setCategoria,false);
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (operacao == TipoOperacao.Editando)
            {
                this.bindingSourceEmpresa.CancelEdit();
            }
            else if (operacao == TipoOperacao.Adicionando)
            {
                this.bindingSourceEmpresa.ResetAllowNew();
            }
            _controle.HabilitaDesabilitaControles(this, TipoOperacao.Navegando);
        }

        private bool IsValid(remag_empresa empresa)
        {
            List<string> mensagens = new List<string>();
            bool valido = true;
            if (empresa.Municipio == null)
            {
                mensagens.Add("Município é obrigatório.");
                valido = false;
            }
            if (empresa.Responsavel == null)
            {
                mensagens.Add("Responsável é obrigatório.");
                valido = false;
            }
            if (empresa.CategoriaEmpresa == null)
            {
                mensagens.Add("Categoria da Empresa é obrigatória.");
                valido = false;
            }
            if (empresa.fpas == 0)
            {
                mensagens.Add("FPAS deve ser diferente de zero.");
                valido = false;
            }
            if (empresa.cnae == 0)
            {
                mensagens.Add("CNAE Fiscal deve ser diferente de zero.");
                valido = false;
            }
            if (string.IsNullOrEmpty(empresa.cnpj))
            {
                mensagens.Add("CNPJ é orbigatório.");
                valido = false; 
            }
            if (string.IsNullOrEmpty(empresa.razao_social))
            {
                mensagens.Add("Razão Social é orbigatória.");
                valido = false;
            }
            if (!valido)
            {
                string erro = string.Empty;
                foreach (string msn in mensagens)
                {
                    erro += msn + "\n";
                }
                MessageBox.Show(erro, "Remag Plus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valido;
        }

    }
}
