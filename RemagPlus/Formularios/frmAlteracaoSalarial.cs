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

namespace RemagPlus.Formularios
{
    public partial class frmAlteracaoSalarial : Form
    {
        DataEntities _dataContext;
        public frmAlteracaoSalarial()
        {
            InitializeComponent();
            _dataContext = new DataEntities();
            selecaoFuncionario.Bind(_dataContext);
            this.btnAvancar.Visible = true;
            this.btnRetornar.Visible = false;
            this.btnConfirmar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnAvancar.Visible = true;
            this.btnRetornar.Visible = false;
            this.btnConfirmar.Visible = false;
            this.funcionarioPanel.Visible = true;
            this.alteracaoPanel.Visible = false;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            this.btnAvancar.Visible = false;
            this.btnRetornar.Visible = true;
            this.btnConfirmar.Visible = true;
            this.funcionarioPanel.Visible = false;
            this.alteracaoPanel.Visible = true;
            AlteraParcial();
        }

        private void AlteraParcial()
        {
            List<remag_funcionario> funcionarios = new List<remag_funcionario>();
            foreach (remag_funcionario funcionario in selecaoFuncionario.Funcionario)
            {
                switch (this.comboBox1.SelectedIndex)
                {
                    case 0: funcionario.SalarioAlterado = funcionario.remuneracao + funcionario.remuneracao * valorNumericUpDown.Value / 100M;
                        break;
                    case 1: funcionario.SalarioAlterado = funcionario.remuneracao + valorNumericUpDown.Value;
                        break;
                    case 2: funcionario.SalarioAlterado = valorNumericUpDown.Value;
                        break;
                }
                funcionarios.Add(funcionario);
            }
            this.bindingSource1.DataSource = funcionarios;
        }

        private void UpdateAll()
        {
            foreach (remag_funcionario funcionario in selecaoFuncionario.Funcionario)
            {
                funcionario.remuneracao = funcionario.SalarioAlterado;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UpdateAll();
            if (_dataContext.SaveChanges() > 0)
            {
                MessageBox.Show("Alteração realizada com sucesso!",RemagPlus.Classes.Mensagens.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
