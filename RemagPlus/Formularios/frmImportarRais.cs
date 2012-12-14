using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RamagPlus.Importacao.RAIS;
using RamagPlus.Importacao;
using RemagPlus.Classes;
using RemagLib;


namespace RemagPlus.Formularios
{
    public partial class frmImportarRais : Form
    {
        public frmImportarRais()
        {
            InitializeComponent();
            _dataContext = new DataEntities();
            PreecheComBox();
        }

        private void PreecheComBox()
        {
            this.categoriaComboBox.DataSource = _dataContext.remag_categoria.ToList();
            this.categoriaComboBox.DisplayMember = "descricao";
            this.admissaoAlfanumericaComboBox.DataSource = _dataContext.remag_admissao_alfanumerica.ToList();
            this.admissaoAlfanumericaComboBox.DisplayMember = "descricao";
            this.admissaoNumericaComboBox.DataSource = _dataContext.remag_admissao_numerica.ToList();
            this.admissaoNumericaComboBox.DisplayMember = "descricao";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
                LoadFuncionarios(openFileDialog1.FileName);
            }
        }

        private void LoadFuncionarios(string file)
        {
            ReadRais rais = new ReadRais(new StreamReader(file));
            IList<Funcionario> funcionarios = Globals.IsDemo ? rais.Funcionarios.Take(3).ToList() : rais.Funcionarios;
            foreach (Funcionario funcionario in funcionarios)
            {
                AddFuncionario(funcionario);
            }
        }

        private void AddFuncionario(Funcionario funcionario)
        {
            ListViewItem item = listView1.Items.Add(funcionario.PIS);
            item.SubItems.Add(funcionario.Nome);
            item.SubItems.Add(funcionario.Admissao.ToString("dd/MM/yyyy"));
            item.Tag = funcionario;
            item.Checked = true;
        }

        DataEntities _dataContext;
        private void button2_Click(object sender, EventArgs e)
        {
            if (Globals.IsDemo)
            {
                MessageBox.Show("O sistema irá importar apenas três funcionários do arquivo.",Mensagens.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.Checked)
                {
                    continue;
                }
                Funcionario funcionario = item.Tag as Funcionario;
                remag_funcionario funcionarioDB = new remag_funcionario();
                funcionarioDB.cpf = funcionario.CPF;
                funcionarioDB.pis = funcionario.PIS;
                funcionarioDB.ctps = "9999";
                funcionarioDB.serie = "999";
                funcionarioDB.sexo = funcionario.Sexo == Sexo.Masculino ? "M" : "F";
                funcionarioDB.remuneracao = funcionario.SalarioContratual;
                funcionarioDB.data_admissao = funcionario.Admissao;
                funcionarioDB.data_opcao = funcionario.Admissao;
                funcionarioDB.data_nascimento = funcionario.Nascimento;
                funcionarioDB.remag_cbo = GetCBO(_dataContext,funcionario.CBO);
                funcionarioDB.remag_categoria = this.categoriaComboBox.SelectedItem as remag_categoria;
                funcionarioDB.remag_admissao_alfanumerica = this.admissaoAlfanumericaComboBox.SelectedItem as remag_admissao_alfanumerica;
                funcionarioDB.remag_admissao_numerica = this.admissaoNumericaComboBox.SelectedItem as remag_admissao_numerica;
                funcionarioDB.remag_empresa = _dataContext.remag_empresa.FirstOrDefault(emp => emp.empresa_id == Globals.Empresa.empresa_id);
                funcionarioDB.remag_municipio = _dataContext.remag_municipio.FirstOrDefault(m => m.municipio_id == Globals.Empresa.Municipio.municipio_id);
                _dataContext.AddToremag_funcionario(funcionarioDB);
            }
            if (_dataContext.SaveChanges() > 0)
            {
                MessageBox.Show("Importação realizada com sucesso!",Mensagens.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private remag_cbo GetCBO(DataEntities dataContext,int cbo)
        {
            remag_cbo cboDB = dataContext.remag_cbo.FirstOrDefault(c => c.cbo == cbo);
            if (cbo == null)
            {
                cboDB = new remag_cbo();
                cboDB.cbo = cbo;
                cboDB.descricao = "CBO Importação RAIS";
                dataContext.AddToremag_cbo(cboDB);
            }
            return cboDB;
        }
    }
}
