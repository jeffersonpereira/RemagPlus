namespace RemagPlus
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEmpresa = new System.Windows.Forms.ToolStripButton();
            this.btnFuncionario = new System.Windows.Forms.ToolStripButton();
            this.btnIndividualizacao = new System.Windows.Forms.ToolStripButton();
            this.btnConsultarValor = new System.Windows.Forms.ToolStripButton();
            this.btnAlteraEmpresa = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cBOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salárioMínimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.altararRemuneraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualizaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioMínimoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estimativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEFIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remag422ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.importarRAIS2011ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarSEFIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmpresa,
            this.btnFuncionario,
            this.btnIndividualizacao,
            this.btnConsultarValor,
            this.btnAlteraEmpresa,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(36, 36);
            this.btnEmpresa.Text = "toolStripButton1";
            this.btnEmpresa.ToolTipText = "Empresa";
            this.btnEmpresa.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFuncionario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(36, 36);
            this.btnFuncionario.Text = "toolStripButton1";
            this.btnFuncionario.ToolTipText = "Funcionário";
            this.btnFuncionario.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // btnIndividualizacao
            // 
            this.btnIndividualizacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIndividualizacao.Image = ((System.Drawing.Image)(resources.GetObject("btnIndividualizacao.Image")));
            this.btnIndividualizacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIndividualizacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIndividualizacao.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnIndividualizacao.Name = "btnIndividualizacao";
            this.btnIndividualizacao.Size = new System.Drawing.Size(36, 36);
            this.btnIndividualizacao.Text = "toolStripButton2";
            this.btnIndividualizacao.ToolTipText = "Individualização";
            this.btnIndividualizacao.Click += new System.EventHandler(this.individualizaçãoToolStripMenuItem_Click);
            // 
            // btnConsultarValor
            // 
            this.btnConsultarValor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultarValor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarValor.Image")));
            this.btnConsultarValor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsultarValor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultarValor.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.btnConsultarValor.Name = "btnConsultarValor";
            this.btnConsultarValor.Size = new System.Drawing.Size(36, 36);
            this.btnConsultarValor.Text = "toolStripButton3";
            this.btnConsultarValor.ToolTipText = "Consultar Individualização";
            this.btnConsultarValor.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // btnAlteraEmpresa
            // 
            this.btnAlteraEmpresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlteraEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnAlteraEmpresa.Image")));
            this.btnAlteraEmpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlteraEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlteraEmpresa.Name = "btnAlteraEmpresa";
            this.btnAlteraEmpresa.Size = new System.Drawing.Size(36, 36);
            this.btnAlteraEmpresa.Text = "toolStripButton1";
            this.btnAlteraEmpresa.ToolTipText = "Alterar Empresa";
            this.btnAlteraEmpresa.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.Text = "toolStripButton1";
            this.btnSair.ToolTipText = "Sair";
            this.btnSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.toolStripMenuItem1,
            this.utilitárioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.toolStripSeparator3,
            this.cBOToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            this.responsávelToolStripMenuItem.Click += new System.EventHandler(this.responsávelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // cBOToolStripMenuItem
            // 
            this.cBOToolStripMenuItem.Name = "cBOToolStripMenuItem";
            this.cBOToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cBOToolStripMenuItem.Text = "CBO";
            this.cBOToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualizaçãoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.toolStripSeparator2,
            this.salárioMínimoToolStripMenuItem,
            this.toolStripSeparator1,
            this.altararRemuneraçãoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // individualizaçãoToolStripMenuItem
            // 
            this.individualizaçãoToolStripMenuItem.Name = "individualizaçãoToolStripMenuItem";
            this.individualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.individualizaçãoToolStripMenuItem.Text = "Individualização";
            this.individualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.individualizaçãoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // salárioMínimoToolStripMenuItem
            // 
            this.salárioMínimoToolStripMenuItem.Name = "salárioMínimoToolStripMenuItem";
            this.salárioMínimoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salárioMínimoToolStripMenuItem.Text = "Salário Mínimo";
            this.salárioMínimoToolStripMenuItem.Click += new System.EventHandler(this.salárioMínimoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // altararRemuneraçãoToolStripMenuItem
            // 
            this.altararRemuneraçãoToolStripMenuItem.Name = "altararRemuneraçãoToolStripMenuItem";
            this.altararRemuneraçãoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.altararRemuneraçãoToolStripMenuItem.Text = "Alterar Remuneração";
            this.altararRemuneraçãoToolStripMenuItem.Click += new System.EventHandler(this.altararRemuneraçãoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeFuncionárioToolStripMenuItem,
            this.individualizaçãoToolStripMenuItem1,
            this.salárioMínimoToolStripMenuItem1,
            this.estimativaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Relatório";
            // 
            // listaDeFuncionárioToolStripMenuItem
            // 
            this.listaDeFuncionárioToolStripMenuItem.Name = "listaDeFuncionárioToolStripMenuItem";
            this.listaDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeFuncionárioToolStripMenuItem.Text = "Lista de Funcionário";
            this.listaDeFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.listaDeFuncionárioToolStripMenuItem_Click);
            // 
            // individualizaçãoToolStripMenuItem1
            // 
            this.individualizaçãoToolStripMenuItem1.Name = "individualizaçãoToolStripMenuItem1";
            this.individualizaçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.individualizaçãoToolStripMenuItem1.Text = "Individualização";
            this.individualizaçãoToolStripMenuItem1.Click += new System.EventHandler(this.individualizaçãoToolStripMenuItem1_Click);
            // 
            // salárioMínimoToolStripMenuItem1
            // 
            this.salárioMínimoToolStripMenuItem1.Name = "salárioMínimoToolStripMenuItem1";
            this.salárioMínimoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salárioMínimoToolStripMenuItem1.Text = "Salário Mínimo";
            this.salárioMínimoToolStripMenuItem1.Click += new System.EventHandler(this.salárioMínimoToolStripMenuItem1_Click);
            // 
            // estimativaToolStripMenuItem
            // 
            this.estimativaToolStripMenuItem.Name = "estimativaToolStripMenuItem";
            this.estimativaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estimativaToolStripMenuItem.Text = "Estimativa";
            this.estimativaToolStripMenuItem.Click += new System.EventHandler(this.estimativaToolStripMenuItem_Click);
            // 
            // utilitárioToolStripMenuItem
            // 
            this.utilitárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEFIPToolStripMenuItem,
            this.remag422ToolStripMenuItem,
            this.toolStripSeparator4,
            this.importarRAIS2011ToolStripMenuItem,
            this.importarSEFIPToolStripMenuItem,
            this.toolStripSeparator5,
            this.configuraçãoToolStripMenuItem});
            this.utilitárioToolStripMenuItem.Name = "utilitárioToolStripMenuItem";
            this.utilitárioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.utilitárioToolStripMenuItem.Text = "Utilitário";
            // 
            // sEFIPToolStripMenuItem
            // 
            this.sEFIPToolStripMenuItem.Name = "sEFIPToolStripMenuItem";
            this.sEFIPToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sEFIPToolStripMenuItem.Text = "SEFIP";
            this.sEFIPToolStripMenuItem.Click += new System.EventHandler(this.SEFIPToolStripMenuItem_Click);
            // 
            // remag422ToolStripMenuItem
            // 
            this.remag422ToolStripMenuItem.Name = "remag422ToolStripMenuItem";
            this.remag422ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.remag422ToolStripMenuItem.Text = "Remag 4.2.2";
            this.remag422ToolStripMenuItem.Click += new System.EventHandler(this.remag422ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // importarRAIS2011ToolStripMenuItem
            // 
            this.importarRAIS2011ToolStripMenuItem.Name = "importarRAIS2011ToolStripMenuItem";
            this.importarRAIS2011ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importarRAIS2011ToolStripMenuItem.Text = "Importar RAIS 2011";
            this.importarRAIS2011ToolStripMenuItem.Click += new System.EventHandler(this.importarRAIS2011ToolStripMenuItem_Click);
            // 
            // importarSEFIPToolStripMenuItem
            // 
            this.importarSEFIPToolStripMenuItem.Enabled = false;
            this.importarSEFIPToolStripMenuItem.Name = "importarSEFIPToolStripMenuItem";
            this.importarSEFIPToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importarSEFIPToolStripMenuItem.Text = "Importar SEFIP";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "empresa";
            // 
            // lbHora
            // 
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(31, 17);
            this.lbHora.Text = "hora";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RemagPlus.Properties.Resources.selecionar_empresa2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 371);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Remag Plus versão 1.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFuncionario;
        private System.Windows.Forms.ToolStripButton btnIndividualizacao;
        private System.Windows.Forms.ToolStripButton btnConsultarValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cBOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEFIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remag422ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnEmpresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel lbHora;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualizaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salárioMínimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem salárioMínimoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton btnAlteraEmpresa;
        private System.Windows.Forms.ToolStripMenuItem altararRemuneraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem importarRAIS2011ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarSEFIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

