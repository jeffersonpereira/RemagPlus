using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections;
using System.Collections.Generic;
using RemagPlus.Classes;

namespace RemagPlus
{
    public partial class RptListaFuncionario : DevExpress.XtraReports.UI.XtraReport
    {
        public RptListaFuncionario()
        {
            InitializeComponent();
        }

        public RptListaFuncionario(IList<remag_funcionario> funcionario):this()
        {
            this.bindingSourceFuncionario.DataSource = funcionario;
        }

    }

}
