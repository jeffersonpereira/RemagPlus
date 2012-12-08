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
    public partial class frmCategoria : BaseForm
    {
        
        public frmCategoria()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceCategoria, "remag_categoria");
        }

        protected override void Pesquisa()
        {
            Pesquisa<remag_categoria> pesquisa = new Pesquisa<remag_categoria>(dataContext,"remag_categoria", new string[] { "tipo", "descricao" }, new int[] { 100, 250 }, new string[] { "Categoria", "Descrição" }, "Categoria",true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceCategoria.DataSource = pesquisa._entity;
                }
            }

        }
      
    }
}
