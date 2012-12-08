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
    public partial class frmEmpresa : BaseForm
    {

        public frmEmpresa()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceEmpresa, "remag_empresa");
            ConfiguraBindingSource();
            this.bindingSourceEmpresa.DataSource = dataContext.remag_empresa.FirstOrDefault(e => e.empresa_id == Globals.Empresa.empresa_id);
        }

        protected override void Pesquisa()
        {
            Pesquisa<remag_empresa> pesquisa = new Pesquisa<remag_empresa>(dataContext, "remag_empresa", new string[] { "cnpj", "razao_social" }, new int[] { 100, 250 }, new string[] { "CNPJ", "Razão Social" }, "Empresa",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceEmpresa.DataSource = pesquisa._entity;
                }
                pesquisa.Close();
            }
        }



        #region Configura Binding Source
        private void ConfiguraBindingSource()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_empresa)dataSource).Municipio = value;
            };
            this.pesquisaControlCidade.Bind<remag_municipio>(dataContext,"Município", "remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 50 }, this.bindingSourceEmpresa, setMunicipio, false);

            SetValue<remag_responsavel> setResponsavel = delegate(object dataSource, remag_responsavel value)
            {
                ((remag_empresa)dataSource).Responsavel = value;
            };
            this.pesquisaControlResponsavel.Bind<remag_responsavel>(dataContext, "Responsável", "remag_responsavel", new string[] { "nome", "cnpj_cei_cpf" }, new string[] { "Nome", "Inscrição" }, new int[] { 250, 100 }, this.bindingSourceEmpresa, setResponsavel, false);

            SetValue<remag_categoria_empregador> setCategoria = delegate(object dataSource, remag_categoria_empregador value)
            {
                ((remag_empresa)dataSource).CategoriaEmpresa = value;
            };
            this.pesquisaControlCategoriaEmpresa.Bind<remag_categoria_empregador>(dataContext, "Categoria da Empresa", "remag_categoria_empregador", new string[] { "descricao", "categoria_empregador_id" }, new string[] { "Descrição", "Código" }, new int[] { 300, 60 }, this.bindingSourceEmpresa, setCategoria, false);
        }
        #endregion

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

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            base.HabilitarDesabilitaBotoes();
        }

    }
}
