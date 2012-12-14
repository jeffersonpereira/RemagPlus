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
using System.Threading;
using RemagLib;

namespace RemagPlus
{

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            SelectBusiness();
         }
        private void SelectBusiness()
        {
            frmSelecionaEmpresa select = new frmSelecionaEmpresa();
            select.ShowDialog();
            UpdateNameBusiness();
        }

        private void UpdateNameBusiness()
        {
            if (Globals.Empresa != null)
            {
                this.toolStripStatusLabel1.Text = Globals.Empresa.razao_social;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCBO cbo = new frmCBO();
            cbo.ShowDialog();
        }

        DateTime _data;
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now - _data;
            timer.Start();
            this.lbHora.Text = Hour(time);
        }

        private string Hour(TimeSpan span)
        {
            return string.Concat(span.Hours.ToString().PadLeft(2, '0'), ":", span.Minutes.ToString().PadLeft(2, '0'), ":", span.Seconds.ToString().PadLeft(2, '0'));
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa empresa = new frmEmpresa();
            empresa.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerra a aplicação?", "Remag Plus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void responsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsavel responsavel = new frmResponsavel();
            responsavel.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.ShowDialog();
        }

        private void individualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualizarForm ind = new IndividualizarForm();
            ind.ShowDialog();
        }

        private void SEFIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaGeraSefip sefip = new TelaGeraSefip();
            sefip.ShowDialog();
        }

        private void remag422ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeraRemag remag = new Formularios.frmGeraRemag();
            remag.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaValor consulta = new Formularios.frmConsultaValor();
            consulta.ShowDialog();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracao config = new Formularios.frmConfiguracao();
            config.ShowDialog();
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void listaDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptListaFuncionario report = new frmRptListaFuncionario();
            report.ShowDialog();
        }

        private void individualizaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptIndividualizacao individualizacao = new frmRptIndividualizacao();
            individualizacao.ShowDialog();
        }

        private void salárioMínimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalarioMinimo salario = new frmSalarioMinimo();
            salario.ShowDialog();
        }

        private void salárioMínimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptSalarioMinimo salario_minimo = new frmRptSalarioMinimo();
            salario_minimo.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSelecionaEmpresa select = new frmSelecionaEmpresa();
            if (select.ShowDialog() == DialogResult.OK)
            {
                UpdateNameBusiness();
            }
        }

        private void altararRemuneraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlteracaoSalarial alteracao = new frmAlteracaoSalarial();
            alteracao.ShowDialog();
        }

        private void estimativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptEstimativa estimativa = new frmRptEstimativa();
            estimativa.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.ShowDialog();
        }

        private void importarRAIS2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportarRais form = new frmImportarRais();
            form.ShowDialog();
        }

      }
}
