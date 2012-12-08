using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Formularios;
using System.Data.Objects;
using RemagPlus.Classes;
using System.Collections;
using System.Collections.Generic;
using RemagLib;

namespace RemagPlus
{
   public class Pesquisa<T>:frmPesquisa where T:class
    {
       private string _tabela;
       private string[] _campos;
       private string[] _titulo;
       private int[] _tamanho;
       private bool _isForm;
       private bool _isEmpresa;
       private remag_empresa _empresa;
       public Pesquisa()
       { }

       public Pesquisa(DataEntities dataContext, string tabela, string[] campos, int[] tamanho, string[] titulo, string tituloForm, bool isForm)
           :this(dataContext,tabela,campos,tamanho,titulo,tituloForm,isForm,null,false)
        {

        }

       DataEntities _dataContext;
       public Pesquisa(DataEntities dataContext, string tabela, string[] campos, int[] tamanho, string[] titulo, string tituloForm, bool isForm, remag_empresa empresa, bool isEmpresa)
       {
           this._empresa = empresa;
           this._isEmpresa = isEmpresa;
           this._dataContext = dataContext;
           this._campos = campos;
           this._tabela = tabela;
           this._titulo = titulo;
           this._tamanho = tamanho;
           this._isForm = isForm;
           listViewPesquisa.FullRowSelect = true;
           this.Text = tituloForm;
           this.btnOK.Enabled = false;
           PreencheListView();
       }

        private void PreencheListView()
        {
            this.listViewPesquisa.View = View.Details;
            int i=0;
            List<ComboPreenchido> dataSource = new List<ComboPreenchido>();
            while (i<_titulo.Length)
	        {
                ComboPreenchido combo = new ComboPreenchido(_campos[i], _titulo[i]);
                dataSource.Add(combo);
                this.listViewPesquisa.Columns.Add(_titulo[i], _tamanho[i], HorizontalAlignment.Left);
                this.comboBoxFiltro.Items.Add(_titulo[i]);
                i++;
	        }
            this.comboBoxFiltro.DataSource = dataSource;
            this.comboBoxFiltro.DisplayMember = "Descricao";
            this.comboBoxFiltro.ValueMember = "Nome";

        }

        public T Entity
        {
            get {return (T)_entity;}   
        }

        public override void ExecutaPesquisa()
        {
            string valor = textBoxValorPesquisa.Text;
            List<T> lista = _dataContext.GetPesquisa<T>(_tabela, (string)this.comboBoxFiltro.SelectedValue, valor); ;
            if (_isEmpresa)
            {
                lista = _dataContext.GetPesquisa<T>(_tabela, (string)this.comboBoxFiltro.SelectedValue, valor, _empresa);
            }

            if (lista.Count > 0)
            {
                this.labelMensabel.Text = "Registros encontrados: " + lista.Count.ToString();
                this.btnOK.Enabled = true;
            }
            else
            {
                this.labelMensabel.Text = "Nenhum registro foi encontrado.";
                this.btnOK.Enabled = false;
            }
            this.listViewPesquisa.Items.Clear();
            foreach (var t in lista)
            {
                ListViewItem item = new ListViewItem();
                item = this.listViewPesquisa.Items.Add(t.GetType().GetProperty(_campos[0]).GetValue(t, null).ToString());
                item.SubItems.Add(t.GetType().GetProperty(_campos[1]).GetValue(t, null).ToString());
                item.Tag = t;
            }
        }
    }
}
