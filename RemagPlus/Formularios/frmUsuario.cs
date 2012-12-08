using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using System.ComponentModel.DataAnnotations;
using RemagLib;


namespace RemagPlus.Formularios
{
    
    public partial class frmUsuario : BaseForm
    {

        public frmUsuario()
        {
            InitializeComponent();
            base.SetBindindSource(this.bindingSourceUsuario, "remag_usuario");
        }
 

        protected override void Pesquisa()
        {
            Pesquisa<remag_usuario> pesquisa = new Pesquisa<remag_usuario>(dataContext, "remag_usuario", new string[] { "login", "nome" }, new int[] { 100, 250 }, new string[] { "Login", "Nome" }, "Usuário", true);
            if (pesquisa.ShowDialog() == DialogResult.OK)
            {
                if (pesquisa._entity != null)
                {
                    this.bindingSourceUsuario.DataSource = pesquisa._entity;
                    if (pesquisa._entity != null)
                    {
                        HabilitarDesabilitaBotoes();
                    }

                }
            }

        }
        #region Validação
        private bool Valido()
        {
            List<string> erros = ValidatedData.IsValid((remag_usuario)this.bindingSourceUsuario.Current);
            bool valido = (erros.Count>0);
            string error = string.Empty;
            if (!valido)
            {
                foreach (string message in erros)
                {
                    error += message + "\n";
                }
                MessageBox.Show(error);
            }
            return valido;
        }

        #endregion
    }
}
