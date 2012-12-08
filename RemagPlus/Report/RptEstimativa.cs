using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using RemagLib;
using RemagPlus.Classes;

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
            this.bindingSourceEstimativa.DataSource=GetEstimativa(funcionario, dataI, dataF, isRemuneracao);
        }

        public IList<Estimativa> GetEstimativa(List<remag_funcionario> funcionario, DateTime dataI, DateTime dataF, bool isRemuneracao)
        {
            DataEntities dataContext = new DataEntities();
            List<Estimativa> estimativa = new List<Estimativa>();
            DateTime dt = dataI;
            foreach (remag_funcionario fu in funcionario)
            {
                dataI = dt;
                if (fu.data_admissao.ToFirstDay() > dataI)
                {
                    dataI = fu.data_admissao.ToFirstDay();
                }
                while (dataI <= dataF)
                {
                    if (!fu.IsAtivo(dataI))
                    {
                        break;
                    }
                    decimal base_calc = decimal.Zero;
                    if (isRemuneracao)
                    {
                        base_calc = fu.remuneracao;
                    }
                    else
                    {
                        base_calc = dataContext.GetSalarioMinimo(dataI);
                    }
                    decimal valor = base_calc * 0.08M;
                    Estimativa est = new Estimativa(fu, dataI, valor, base_calc);
                    estimativa.Add(est);
                    dataI = dataI.AddMonths(1);
                }
            }
            return estimativa;
        }

    }
}
