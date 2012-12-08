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

        //public remag_empresa Empresa
        //{
        //    get
        //    {
        //        if (this.remag_empresaReference.IsLoaded)
        //        {
        //            this.remag_empresaReference.Load();
        //        }
        //        return this.remag_empresa;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("Empresa");
        //        if (value == null)
        //        {
        //            this.remag_empresaReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_empresa = Globals.DataContext.LoadKey<remag_empresa>("empresa_id", value.empresa_id);
        //        }
        //        this.OnPropertyChanged("Empresa");
        //    }
        //}

        public remag_empresa Empresa
        {
            get { return this.remag_empresa; }
            set { this.remag_empresa.empresa_id = value.empresa_id; }
        }

        //public remag_municipio Municipio
        //{
        //    get
        //    {
        //        if (this.remag_municipioReference.IsLoaded)
        //        {
        //            this.remag_municipioReference.Load();
        //        }
        //        return this.remag_municipio;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("Municipio");
        //        if (value == null)
        //        {
        //            this.remag_municipioReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_municipio.municipio_id = Globals.DataContext.LoadKey<remag_municipio>("municipio_id", value.municipio_id);
        //        }
        //        this.OnPropertyChanged("Municipio");
        //    }
        //}

        public remag_municipio Municipio
        {
            get { return this.remag_municipio; }
            set { this.remag_municipio = value; }
        }

        public remag_cbo CBO
        {
            get { return this.remag_cbo; }
            set { this.remag_cbo.cbo_id = value.cbo_id; }
        }

        //public remag_cbo CBO
        //{
        //    get
        //    {
        //        if (this.remag_cboReference.IsLoaded)
        //        {
        //            this.remag_cboReference.Load();
        //        }
        //        return this.remag_cbo;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("CBO");
        //        if (value == null)
        //        {
        //            this.remag_cboReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_cbo = Globals.DataContext.LoadKey<remag_cbo>("cbo_id", value.cbo_id);
        //        }
        //        this.OnPropertyChanged("CBO");
        //    }
        //}

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
            set { this.remag_categoria.categoria_id = value.categoria_id; }
        }

        //public remag_categoria Categoria
        //{
        //    get
        //    {
        //        if (this.remag_categoriaReference.IsLoaded)
        //        {
        //            this.remag_categoriaReference.Load();
        //        }
        //        return this.remag_categoria;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("Categoria");
        //        if (value == null)
        //        {
        //            this.remag_categoriaReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_categoria = Globals.DataContext.LoadKey<remag_categoria>("categoria_id", value.categoria_id);
        //        }
        //        this.OnPropertyChanged("Categoria");
        //    }
        //}

        public remag_codigo_movimentacao Movimentacao
        {
            get { return this.remag_codigo_movimentacao; }
            set { this.remag_codigo_movimentacao.movimentacao_id = value.movimentacao_id; }
        }

        //public remag_codigo_movimentacao Movimentacao
        //{
        //    get
        //    {
        //        if (this.remag_codigo_movimentacaoReference.IsLoaded)
        //        {
        //            this.remag_codigo_movimentacaoReference.Load();
        //        }
        //        return this.remag_codigo_movimentacao;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("Movimentacao");
        //        if (value == null)
        //        {
        //            this.remag_codigo_movimentacaoReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_codigo_movimentacao = Globals.DataContext.LoadKey<remag_codigo_movimentacao>("movimentacao_id", value.movimentacao_id);
        //        }
        //        this.OnPropertyChanged("Movimentacao");
        //    }
        //}

        //public remag_admissao_alfanumerica AdmissaoAlfa
        //{
        //    get
        //    {
        //        if (this.remag_admissao_alfanumericaReference.IsLoaded)
        //        {
        //            this.remag_admissao_alfanumericaReference.Load();
        //        }
        //        return this.remag_admissao_alfanumerica;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("AdmissaoAlfa");
        //        if (value == null)
        //        {
        //            this.remag_admissao_alfanumericaReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_admissao_alfanumerica = Globals.DataContext.LoadKey<remag_admissao_alfanumerica>("admissao_alfanumerica_id", value.admissao_alfanumerica_id);
        //        }
        //        this.OnPropertyChanged("AdmissaoAlfa");
        //    }
        //}

        public remag_admissao_alfanumerica AdmissaoAlfa
        {
            get { return this.remag_admissao_alfanumerica; }
            set { this.remag_admissao_alfanumerica.admissao_alfanumerica_id = value.admissao_alfanumerica_id; }
        }

        public remag_admissao_numerica AdmissaoNumerica
        {
            get { return this.remag_admissao_numerica; }
            set { this.remag_admissao_numerica.admissao_numerica_id = value.admissao_numerica_id; }
        }

        //public remag_admissao_numerica AdmissaoNumerica
        //{
        //    get
        //    {
        //        if (this.remag_admissao_numericaReference.IsLoaded)
        //        {
        //            this.remag_admissao_numericaReference.Load();
        //        }
        //        return this.remag_admissao_numerica;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("AdmissaoNumerica");
        //        if (value == null)
        //        {
        //            this.remag_admissao_numericaReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_admissao_numerica = Globals.DataContext.LoadKey<remag_admissao_numerica>("admissao_numerica_id", value.admissao_numerica_id);
        //        }
        //        this.OnPropertyChanged("AdmissaoNumerica");
        //    }
        //}


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
