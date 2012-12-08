using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace RemagPlus.Report
{
    public partial class RptEstimativa : DevExpress.XtraReports.UI.XtraReport
    {
        public RptEstimativa()
        {
            InitializeComponent();
        }

        public RptEstimativa(List<remag_funcionario> funcionario, DateTime dataI, DateTime dataF, bool isRemuneracao, decimal qtd):this()
        {
            Funcoes function = new Funcoes();
            this.bindingSourceEstimativa.DataSource=function.GetEstimativa(funcionario, dataI, dataF, isRemuneracao);
        }

    }
}
