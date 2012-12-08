using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace RemagLib
{
    public partial class remag_empresa
    {
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
        //            this.remag_municipio = Globals.DataContext.LoadKey<remag_municipio>("municipio_id", value.municipio_id);
        //        }
        //        this.OnPropertyChanged("Municipio");
        //    }
        //}

        public remag_municipio Municipio
        {
            get { return this.remag_municipio; }
            set { this.remag_municipio.municipio_id = value.municipio_id; }
        }

        public remag_responsavel Responsavel
        {
            get { return this.remag_responsavel; }
            set { this.remag_responsavel.responsavel_id = value.responsavel_id; }
        }

        //public remag_responsavel Responsavel
        //{
        //    get
        //    {
        //        if (this.remag_responsavelReference.IsLoaded)
        //        {
        //            this.remag_responsavelReference.Load();
        //        }
        //        return this.remag_responsavel;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("Responsavel");
        //        if (value == null)
        //        {
        //            this.remag_responsavelReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_responsavel = Globals.DataContext.LoadKey<remag_responsavel>("responsavel_id", value.responsavel_id);
        //        }
        //        this.OnPropertyChanged("Responsavel");
        //    }
        //}

        public remag_categoria_empregador CategoriaEmpresa
        {
            get { return this.remag_categoria_empregador; }
            set { this.categoria_empregador_id = value.categoria_empregador_id; }
        }

        //public remag_categoria_empregador CategoriaEmpresa
        //{
        //    get
        //    {
        //        if (this.remag_categoria_empregadorReference.IsLoaded)
        //        {
        //            this.remag_categoria_empregadorReference.Load();
        //        }
        //        return this.remag_categoria_empregador;
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("CategoriaEmpresa");
        //        if (value == null)
        //        {
        //            this.remag_categoria_empregadorReference.EntityKey = null;
        //        }
        //        else
        //        {
        //            this.remag_categoria_empregador = Globals.DataContext.LoadKey<remag_categoria_empregador>("categoria_empregador_id", value.categoria_empregador_id);
        //        }
        //        this.OnPropertyChanged("CategoriaEmpresa");
        //    }
        //}

        public bool IsCNPJ
        {
            get { return this.tipo_inscricao.Equals("CNPJ"); }
        }

        public bool IsCEI
        {
            get { return this.tipo_inscricao.Equals("CEI"); }
        }

   }
}
