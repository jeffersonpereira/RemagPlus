namespace RemagPlus.Formularios
{
    partial class frmPesquisa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxValorPesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewPesquisa = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelMensabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(6, 18);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(173, 21);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.textBoxValorPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor da Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::RemagPlus.Properties.Resources.find;
            this.btnPesquisar.Location = new System.Drawing.Point(293, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(45, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxValorPesquisa
            // 
            this.textBoxValorPesquisa.Location = new System.Drawing.Point(17, 19);
            this.textBoxValorPesquisa.Name = "textBoxValorPesquisa";
            this.textBoxValorPesquisa.Size = new System.Drawing.Size(270, 20);
            this.textBoxValorPesquisa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewPesquisa);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 229);
            this.panel1.TabIndex = 2;
            // 
            // listViewPesquisa
            // 
            this.listViewPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPesquisa.FullRowSelect = true;
            this.listViewPesquisa.Location = new System.Drawing.Point(0, 0);
            this.listViewPesquisa.Name = "listViewPesquisa";
            this.listViewPesquisa.Size = new System.Drawing.Size(569, 229);
            this.listViewPesquisa.TabIndex = 0;
            this.listViewPesquisa.UseCompatibleStateImageBehavior = false;
            this.listViewPesquisa.SelectedIndexChanged += new System.EventHandler(this.listViewPesquisa_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMensabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMensabel
            // 
            this.labelMensabel.Name = "labelMensabel";
            this.labelMensabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(500, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(419, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 367);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.ListView listViewPesquisa;
        public System.Windows.Forms.TextBox textBoxValorPesquisa;
        public System.Windows.Forms.ToolStripStatusLabel labelMensabel;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ComboBox comboBoxFiltro;
    }
}