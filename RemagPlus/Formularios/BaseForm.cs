using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagLib;

namespace RemagPlus
{
    public partial class BaseForm : Form
    {
        protected DataEntities dataContext;
        public BaseForm()
        {
            InitializeComponent();
            dataContext = new DataEntities();
        }

        string entity;
        public void SetBindindSource(BindingSource bindingSource,string entity)
        {
            this.bindingSourceBase = bindingSource;
            this.entity = entity;
            HabilitarDesabilitaBotoes();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a saída dessa tela?", "RemagPlus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected virtual List<string> GetErros()
        {
            return null;
        }

        protected virtual void Pesquisa()
        { }

        protected virtual void Salvar()
        {
            List<string> erros = GetErros();
            if (erros == null || erros.Count == 0)
            {
                if (dataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso!", "RemagPlus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    HabilitarDesabilitaBotoes();
                }
            }
            else
            {
                string msg = string.Empty;
                foreach (string erro in erros)
                {
                    msg += erro + "\n";
                }
                MessageBox.Show(msg,"RemagPlus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excluir()
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "RemagPlus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dataContext.DeleteObject(this.bindingSourceBase.Current);
                if (dataContext.SaveChanges() > 0)
                {
                    this.bindingSourceBase.ResetCurrentItem();
                    MessageBox.Show("Registro excluído com sucesso!", "RemagPlus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        protected void HabilitarDesabilitaBotoes()
        {
            this.btnNovo.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = this.bindingSourceBase.Current != null;
            this.btnExcluir.Enabled = this.bindingSourceBase.Current != null;
            this.btnCancelar.Enabled = this.bindingSourceBase.Current != null;

            if (this.bindingSourceBase.Current != null)
            {
                ObjectStateEntry entry = dataContext.ObjectStateManager.GetObjectStateEntry(this.bindingSourceBase.Current);
                if (entry != null)
                {
                    this.btnSalvar.Enabled = entry.State == EntityState.Added || entry.State == EntityState.Modified || entry.State != EntityState.Unchanged;
                    this.btnNovo.Enabled = entry.State == EntityState.Unchanged || entry.State == EntityState.Deleted;
                    this.btnExcluir.Enabled = entry.State == EntityState.Unchanged;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.bindingSourceBase.AddNew();
            this.dataContext.AddObject(entity, this.bindingSourceBase.Current);
            HabilitarDesabilitaBotoes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnSalvar.Enabled = true;
            this.btnSalvar.Enabled = true;
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;

            ObjectStateEntry entry = dataContext.ObjectStateManager.GetObjectStateEntry(this.bindingSourceBase.Current);
            entry.SetModified();
            HabilitarDesabilitaBotoes();
        }

        protected virtual void Pesquisar()
        { }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void bindingSourceBase_DataSourceChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitaBotoes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bindingSourceBase.EndEdit();
            HabilitarDesabilitaBotoes();
        }

    }
}
