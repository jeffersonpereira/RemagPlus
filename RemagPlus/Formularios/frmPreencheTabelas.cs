using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RemagLib;
using RemagPlus.Classes;

namespace RemagPlus.Formularios
{
    public partial class frmPreencheTabelas : Form
    {
        public frmPreencheTabelas()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        DataEntities _dataContext;
        List<string> _linhas;
        public frmPreencheTabelas(DataEntities dataContext)
            : this()
        {
            _dataContext = dataContext;
            string temp = string.Format(@"{0}\{1}",Application.ExecutablePath.Replace("\\RemagPlus.exe", ""),@"temp\importar.txt");
            temp.Replace("\\RemagPlus.exe", "");
            if (!File.Exists(temp))
            {
                MessageBox.Show("Arquivo de importação não foi encontrado no diretório padrão.", Mensagens.Titulo);
                return;
            }
            StreamReader reader = new StreamReader(temp);
            List<string> linhas = new List<string>();
            while (!reader.EndOfStream)
            {
                linhas.Add(reader.ReadLine());
            }
            _linhas = linhas;
            backgroundWorker1.RunWorkerAsync();
        }

        private void DoImportar(DataEntities dataContext, List<string> linhas)
        {
            ImportarMunicipio(dataContext, linhas);
            ImportarCategoria(dataContext, linhas);
            ImportarCategoriaEmpresa(dataContext, linhas);
            ImportarAdmissaoNumerica(dataContext, linhas);
            ImportarAdmissaoAlfanumerica(dataContext, linhas);
            ImportarCBO(dataContext, linhas);
        }

        private void ImportarMunicipio(DataEntities dataContext,List<string> linhas)
        {
            linhas = linhas.Where(l=>l.StartsWith("Municipio|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_municipio municipio = new remag_municipio();
                municipio.nome = fields[1];
                municipio.uf = fields[2];
                dataContext.AddToremag_municipio(municipio);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void ImportarCategoria(DataEntities dataContext, List<string> linhas)
        {
            linhas = linhas.Where(l => l.StartsWith("Categoria|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_categoria categoria = new remag_categoria();
                categoria.descricao = fields[1];
                categoria.tipo = Convert.ToInt32(fields[2]);
                dataContext.AddToremag_categoria(categoria);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void ImportarCategoriaEmpresa(DataEntities dataContext, List<string> linhas)
        {
            linhas = linhas.Where(l => l.StartsWith("CategoriaEmpresa|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_categoria_empregador categoria = new remag_categoria_empregador();
                categoria.descricao = fields[1];
                categoria.tipo = Convert.ToInt32(fields[2]);
                dataContext.AddToremag_categoria_empregador(categoria);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void ImportarAdmissaoNumerica(DataEntities dataContext, List<string> linhas)
        {
            linhas = linhas.Where(l => l.StartsWith("AdmissaoNumerica|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_admissao_numerica admissao = new remag_admissao_numerica();
                admissao.descricao = fields[1];
                admissao.codigo = Convert.ToInt32(fields[2]);
                dataContext.AddToremag_admissao_numerica(admissao);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void ImportarAdmissaoAlfanumerica(DataEntities dataContext, List<string> linhas)
        {
            linhas = linhas.Where(l => l.StartsWith("AdmissaoAlfanumerica|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_admissao_alfanumerica admissao = new remag_admissao_alfanumerica();
                admissao.descricao = fields[1];
                admissao.codigo = fields[2];
                dataContext.AddToremag_admissao_alfanumerica(admissao);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void ImportarCBO(DataEntities dataContext, List<string> linhas)
        {
            linhas = linhas.Where(l => l.StartsWith("CBO|")).ToList();
            int i = 0;
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split('|');
                remag_cbo cbo = new remag_cbo();
                cbo.descricao = fields[2];
                cbo.cbo = Convert.ToInt32(fields[1]);
                dataContext.AddToremag_cbo(cbo);
                backgroundWorker1.ReportProgress(i++);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             DoImportar(_dataContext, _linhas);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _dataContext.SaveChanges();
            this.Close();
        }
    }
}
