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
    public partial class frmCBO : BaseForm
    {
        public frmCBO()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceCBO, "remag_cbo");
        }
        
        protected override void Pesquisa()
        {
            Pesquisa<remag_cbo> pesquisa = new Pesquisa<remag_cbo>(dataContext, "remag_cbo", new string[] { "cbo","descricao"}, new int[] { 100, 250 }, new string[] {"CBO","Descrição"}, "Classificação Brasileira de Ocupação",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceCBO.DataSource = pesquisa._entity;
                    if (pesquisa._entity != null)
                    {
                        HabilitarDesabilitaBotoes();
                    }
                }
            }
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }
    }
}
