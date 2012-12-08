using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using RemagPlus.Classes;
using RemagLib;

namespace RemagPlus.Report
{
    public partial class RptSalarioMinimo : DevExpress.XtraReports.UI.XtraReport
    {
        public RptSalarioMinimo()
        {
            InitializeComponent();
        }

        public RptSalarioMinimo(List<remag_salario_minimo> salario)
        {
            this.bindingSourceSalarioMinimo.DataSource = salario;
        }

    }
}
