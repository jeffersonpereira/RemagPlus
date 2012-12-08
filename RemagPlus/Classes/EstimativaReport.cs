using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemagLib;

namespace RemagPlus.Classes
{
    public class EstimativaReport
    {
        protected remag_funcionario funcionario;
        protected DateTime competencia;
        protected decimal valor;
        protected decimal base_calculo;
        public EstimativaReport(remag_funcionario funcionario, DateTime competencia, decimal valor,decimal base_calculo)
        {
            this.funcionario = funcionario;
            this.competencia = competencia;
            this.valor = valor;
        }

        public virtual remag_funcionario Funcionario
        {
            get { return funcionario; }
        }

        public virtual DateTime Competencia
        {
            get { return competencia; }
        }

        public virtual decimal Valor
        {
            get { return valor; }
        }

        public virtual decimal BaseCalculo
        {
            get { return base_calculo; }
        }
    }

    public class Estimativa : EstimativaReport
    {
        public Estimativa(remag_funcionario funcionario, DateTime competencia, decimal valor, decimal base_calculo)
            : base(funcionario, competencia, valor, base_calculo)
        { }
    }
}
