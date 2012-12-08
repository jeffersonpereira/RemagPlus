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
    public partial class frmResponsavel : BaseForm
    {
        public frmResponsavel()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceResponsavel, "remag_responsavel");
        }

        protected override void Pesquisa()
        {
            Pesquisa<remag_responsavel> pesquisa = new Pesquisa<remag_responsavel>(dataContext, "remag_responsavel", new string[] { "cnpj_cei_cpf", "nome" }, new int[] { 100, 250 }, new string[] { "Inscrição", "Nome" }, "Responsável",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceResponsavel.DataSource = pesquisa.Entity;
                    if (pesquisa._entity != null)
                    {
                        HabilitarDesabilitaBotoes();
                    }
                }
            }
        }

        private void Configura()
        {
            SetValue<remag_municipio> setMunicipio = delegate(object dataSource, remag_municipio value)
            {
                ((remag_responsavel)dataSource).Municipio = value;
            };
            this.pesquisaControl1.Bind<remag_municipio>(dataContext,"Município", "remag_municipio", new string[] { "nome", "uf" }, new string[] { "Nome", "UF" }, new int[] { 300, 100 }, this.bindingSourceResponsavel, setMunicipio, false);
        }

        private void frmResponsavel_Load(object sender, EventArgs e)
        {
            Configura();
        }

      }
}
