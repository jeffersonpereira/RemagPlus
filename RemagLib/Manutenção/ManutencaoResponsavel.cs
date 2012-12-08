using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RemagLib
{
    public partial class remag_responsavel
    {
        public override string ToString()
        {
            return this.nome;
        }

        public remag_municipio Municipio
        {
            get { return this.remag_municipio; }
            set { this.remag_municipio.municipio_id = value.municipio_id; }
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
        //            this.remag_municipio = Globals.DataContext.LoadKey<remag_municipio>("municipio_id", value.municipio_id);
        //        }
        //        this.OnPropertyChanged("Municipio");
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
