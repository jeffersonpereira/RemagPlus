using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagLib;

namespace RemagPlus
{
    public delegate void SetValue<T>(object dataSource, T value);
    public partial class PesquisaControl : UserControl
    {
        public PesquisaControl()
        {
            InitializeComponent();
        }

        public void Bind<TSearch>(DataEntities dataContext,string rotulo, string tabela, string[] campos, string[] titulo,int[] tamanho, BindingSource bindingSource, SetValue<TSearch> setValue,bool isForm) where TSearch:System.Data.Objects.DataClasses.EntityObject
        {
            this.editPesquisa.DataBindings.Add("Text", bindingSource, tabela, true, DataSourceUpdateMode.OnPropertyChanged);
            this.tituloLabel.Text = rotulo;
            btnPesquisa.Click += delegate(object sender, EventArgs e)
            {
                if (bindingSource.Current != null)
                {
                    EventHandler pesquisado = delegate(object s2, EventArgs e2)
                    {
                        SearchSelectedEventArgs args = (SearchSelectedEventArgs)e2;
                        setValue(bindingSource.Current, (TSearch)args.Selected);
                        bindingSource.ResetBindings(true);
                    };
                    DataSearch.DoSearch<TSearch>(dataContext,tabela, campos, titulo, tamanho, "Pesquisa", pesquisado, isForm);
                }
            };

            this.buttonClear.Click += delegate(object s3, EventArgs e3)
            {
                if (bindingSource.Current != null)
                {
                    setValue(bindingSource.Current, null);
                    bindingSource.ResetBindings(true);
                }
            };

        }

    }

    public class SearchSelectedEventArgs : EventArgs
    {
        public readonly object Selected;
        public SearchSelectedEventArgs(object selected)
        {
            this.Selected = selected;
        }
    }

    public partial class DataSearch
    {
        public static void DoSearch<T>(DataEntities dataContext, string tabela,string[] campos, string [] titulo, int[] tamanho ,string tituloForm, EventHandler onSelected,bool isForm) where T:class
        {
            Pesquisa<T> pesquisa = new Pesquisa<T>(dataContext,tabela, campos, tamanho, titulo, tituloForm, isForm);
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    if (pesquisa.listViewPesquisa.SelectedItems != null)
                    { 
                      onSelected(pesquisa,new SearchSelectedEventArgs(pesquisa.Entity));
                    }
                }
        }
    }
}
