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
    public partial class RptIndividualizacao : DevExpress.XtraReports.UI.XtraReport
    {
        public RptIndividualizacao()
        {
            InitializeComponent();
        }

        public RptIndividualizacao(IList<remag_individualizacao> individualizacao)
            : this()
        {
            this.bindingSource1.DataSource = individualizacao;
        }

    }
}
