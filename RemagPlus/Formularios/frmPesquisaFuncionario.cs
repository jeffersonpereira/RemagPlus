using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemagPlus.Classes;
using RemagLib;
using System.Collections;

namespace RemagPlus.Formularios
{
    public partial class frmPesquisaFuncionario : Form
    {
        public frmPesquisaFuncionario()
        {
            InitializeComponent();
            this.pisPanel.Visible = false;
            this.admissaoPanel.Visible = false;
            this.selecaocomboBox.SelectedIndex = 0;
        }

        DataEntities _dataContext;
        public frmPesquisaFuncionario(DataEntities dataContext)
            : this()
        {
            _dataContext = dataContext;
        }

        IList<remag_funcionario> _funcionarios;
        public IList<remag_funcionario> Funcionarios
        {
            get { return _funcionarios; }
        }

        private void selecaocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selecaocomboBox.SelectedIndex == 0)
            {
                this.nomePanel.Visible = true;
                this.pisPanel.Visible = false;
                this.admissaoPanel.Visible = false;
            }
            else if (selecaocomboBox.SelectedIndex == 1)
            {
                this.nomePanel.Visible = false;
                this.pisPanel.Visible = false;
                this.admissaoPanel.Visible = true;
            }
            else if (selecaocomboBox.SelectedIndex == 2)
            {
                this.nomePanel.Visible = false;
                this.pisPanel.Visible = true;
                this.admissaoPanel.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFuncionarios();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadFuncionarios()
        {
            _funcionarios = new List<remag_funcionario>();
            foreach (ListViewItem item in this.destinoListView.Items)
            {
                remag_funcionario funcionario = item.Tag as remag_funcionario;
                _funcionarios.Add(funcionario);
            }
        }

        private void DoPesquisar()
        {
            if (selecaocomboBox.SelectedIndex == 0 && this.nomeTextBox.Text.Equals("*"))
            {
                _funcionarios = _dataContext.remag_funcionario.Where(f => f.empresa_id == Globals.Empresa.empresa_id).ToList();
            }
            if (selecaocomboBox.SelectedIndex == 0 && !this.nomeTextBox.Text.Equals("*") && !string.IsNullOrWhiteSpace(this.nomeTextBox.Text))
            {
                _funcionarios = _dataContext.remag_funcionario.Where(f => f.nome.StartsWith(this.nomeTextBox.Text)).ToList();
            }
            if (selecaocomboBox.SelectedIndex == 1)
            {
                _funcionarios = _dataContext.GetFuncionarioDados(Globals.Empresa, this.inicialDateTimePicker.Value, this.finalDateTimePicker.Value);
            }
            if (selecaocomboBox.SelectedIndex == 2)
            {
                _funcionarios = _dataContext.GetFuncionarioDados(Globals.Empresa, this.pisTextBox.Text);
            }
            PreencheOrigem();
        }

        private bool IsExist(remag_funcionario funcionario, bool origem)
        {
            bool exist = false;
            if (origem)
            {
                foreach (ListViewItem item in this.origemListView.Items)
                {
                    if (funcionario == (remag_funcionario)item.Tag)
                    {
                        exist = true;
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in this.destinoListView.Items)
                {
                    if (funcionario == (remag_funcionario)item.Tag)
                    {
                        exist = true;
                    }
                }
            }
            return exist;
        }

        private void PreencheOrigem()
        {
            this.origemListView.Items.Clear();
            foreach (remag_funcionario funcionario in _funcionarios)
            {
                if (!IsExist(funcionario, true) && !IsExist(funcionario, false))
                {
                    ListViewItem item = this.origemListView.Items.Add(funcionario.pis);
                    item.SubItems.Add(funcionario.nome);
                    item.Tag = funcionario;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (origemListView.SelectedItems.Count == 1)
            {
                ListViewItem item = origemListView.SelectedItems[0];
                remag_funcionario funcionario = item.Tag as remag_funcionario;
                if (!IsExist(funcionario, false))
                {
                    this.origemListView.Items.Remove(origemListView.SelectedItems[0]);
                    this.destinoListView.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            origemListView.Items.Clear();
            foreach (var funcionario in _funcionarios)
            {
                if (!IsExist(funcionario, false))
                {
                    ListViewItem item = destinoListView.Items.Add(funcionario.pis);
                    item.SubItems.Add(funcionario.nome);
                    item.Tag = funcionario;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            destinoListView.Items.Clear();
            foreach (var funcionario in _funcionarios)
            {
                if (!IsExist(funcionario, true))
                {
                    ListViewItem item = origemListView.Items.Add(funcionario.pis);
                    item.SubItems.Add(funcionario.nome);
                    item.Tag = funcionario;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (destinoListView.SelectedItems.Count == 1)
            {
                ListViewItem item = destinoListView.SelectedItems[0];
                remag_funcionario funcionario = item.Tag as remag_funcionario;
                if (!IsExist(funcionario, true))
                {
                    this.destinoListView.Items.Remove(destinoListView.SelectedItems[0]);
                    this.origemListView.Items.Add(item);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DoPesquisar();
        }

    }
}
