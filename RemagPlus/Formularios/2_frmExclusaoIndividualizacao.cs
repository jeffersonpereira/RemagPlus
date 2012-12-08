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
    public partial class frmExclusaoIndividualizacao : Form
    {
        public frmExclusaoIndividualizacao()
        {
            InitializeComponent();
        }

        private void CarregarInformacoes()
        { 
           // Globals.DataContext.remag_individualizacao.Where(i=>i.remag_funcionario.empresa_id==Globals.Empresa.empresa_id)
        }
    }
}
