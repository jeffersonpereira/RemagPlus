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
    public partial class frmSalarioMinimo : BaseForm
    {
        public frmSalarioMinimo()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceSalarioMinimo, "remag_salario_minimo");
        }

        protected override void Pesquisa()
        {
            Pesquisa<remag_salario_minimo> pesquisa = new Pesquisa<remag_salario_minimo>(dataContext, "remag_salario_minimo", new string[] { "valor", "vogencia" }, new int[] { 100, 250 }, new string[] { "Valor", "Vigência" }, "Salário Mínimo", true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceSalarioMinimo.DataSource = pesquisa._entity;
                    if (pesquisa._entity != null)
                    {
                        HabilitarDesabilitaBotoes();
                    }
                }
            }

        }
     
    }
}
