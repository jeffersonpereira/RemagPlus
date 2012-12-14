using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;


namespace RemagLib
{

    public partial class remag_funcionario
    {
        public remag_funcionario()
        {
            
            this.optante = true;
        }

        public decimal SalarioAlterado { get; set; }

        public remag_empresa Empresa
        {
            get { return this.remag_empresa; }
            set { this.remag_empresa.empresa_id = value.empresa_id; }
        }

        public remag_municipio Municipio
        {
            get { return this.remag_municipio; }
            set { this.remag_municipio = value; }
        }

        public remag_cbo CBO
        {
            get { return this.remag_cbo; }
            set { this.remag_cbo = value; }
        }


        public DateTime DataAdmissao
        {
            get { return this.data_admissao; }
            set
            {
                SetDataOpcaoFGTS(value);
                this.data_admissao = value;
            }

        }

        private void SetDataOpcaoFGTS(DateTime admissao)
        {
            if (data_admissao != null && data_admissao < new DateTime(1967, 01, 01))
            {
                this.data_opcao = admissao;
                this.optante = true;
            }
        }

        public remag_categoria Categoria
        {
            get { return this.remag_categoria; }
            set { this.remag_categoria = value; }
        }

        public remag_codigo_movimentacao Movimentacao
        {
            get { return this.remag_codigo_movimentacao; }
            set { this.remag_codigo_movimentacao.movimentacao_id = value.movimentacao_id; }
        }


        public remag_admissao_alfanumerica AdmissaoAlfa
        {
            get { return this.remag_admissao_alfanumerica; }
            set { this.remag_admissao_alfanumerica = value; }
        }

        public remag_admissao_numerica AdmissaoNumerica
        {
            get { return this.remag_admissao_numerica; }
            set { this.remag_admissao_numerica = value; }
        }


        /// <summary>
        /// Retorna se o funcionário está ativo
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool IsAtivo(DateTime date)
        {
            bool ativo = true;
            if (this.data_demissao.HasValue)
            {
                if (this.data_demissao.Value <= date)
                {
                    ativo = false;
                }
            }
            return ativo;
        }

    }
}
