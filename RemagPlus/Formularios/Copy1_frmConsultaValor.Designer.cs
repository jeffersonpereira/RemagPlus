namespace RemagPlus.Formularios
{
    partial class frmConsultaValor
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
            this.radioButtonGeral = new System.Windows.Forms.RadioButton();
            this.radioButtonDataRecolhimento = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
            this.radioButtonCompetencia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewConsulta = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeposito13 = new System.Windows.Forms.Label();
            this.labelDeposito = new System.Windows.Forms.Label();
            this.labelJam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonGeral);
            this.groupBox1.Controls.Add(this.radioButtonDataRecolhimento);
            this.groupBox1.Controls.Add(this.radioButtonFuncionario);
            this.groupBox1.Controls.Add(this.radioButtonCompetencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // radioButtonGeral
            // 
            this.radioButtonGeral.AutoSize = true;
            this.radioButtonGeral.Checked = true;
            this.radioButtonGeral.Location = new System.Drawing.Point(6, 23);
            this.radioButtonGeral.Name = "radioButtonGeral";
            this.radioButtonGeral.Size = new System.Drawing.Size(50, 17);
            this.radioButtonGeral.TabIndex = 2;
            this.radioButtonGeral.TabStop = true;
            this.radioButtonGeral.Text = "Geral";
            this.radioButtonGeral.UseVisualStyleBackColor = true;
            // 
            // radioButtonDataRecolhimento
            // 
            this.radioButtonDataRecolhimento.AutoSize = true;
            this.radioButtonDataRecolhimento.Location = new System.Drawing.Point(6, 46);
            this.radioButtonDataRecolhimento.Name = "radioButtonDataRecolhimento";
            this.radioButtonDataRecolhimento.Size = new System.Drawing.Size(131, 17);
            this.radioButtonDataRecolhimento.TabIndex = 2;
            this.radioButtonDataRecolhimento.TabStop = true;
            this.radioButtonDataRecolhimento.Text = "Data de Recolhimento";
            this.radioButtonDataRecolhimento.UseVisualStyleBackColor = true;
            this.radioButtonDataRecolhimento.CheckedChanged += new System.EventHandler(this.ChangedRadionButton);
            // 
            // radioButtonFuncionario
            // 
            this.radioButtonFuncionario.AutoSize = true;
            this.radioButtonFuncionario.Location = new System.Drawing.Point(144, 23);
            this.radioButtonFuncionario.Name = "radioButtonFuncionario";
            this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionario.TabIndex = 2;
            this.radioButtonFuncionario.TabStop = true;
            this.radioButtonFuncionario.Text = "Funcionário";
            this.radioButtonFuncionario.UseVisualStyleBackColor = true;
            this.radioButtonFuncionario.CheckedChanged += new System.EventHandler(this.ChangedRadionButton);
            // 
            // radioButtonCompetencia
            // 
            this.radioButtonCompetencia.AutoSize = true;
            this.radioButtonCompetencia.Location = new System.Drawing.Point(144, 46);
            this.radioButtonCompetencia.Name = "radioButtonCompetencia";
            this.radioButtonCompetencia.Size = new System.Drawing.Size(87, 17);
            this.radioButtonCompetencia.TabIndex = 2;
            this.radioButtonCompetencia.TabStop = true;
            this.radioButtonCompetencia.Text = "Competência";
            this.radioButtonCompetencia.UseVisualStyleBackColor = true;
            this.radioButtonCompetencia.CheckedChanged += new System.EventHandler(this.ChangedRadionButton);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTitulo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TextBoxPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conteúdo do Filtro";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(3, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(32, 13);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Geral";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxPesquisa
            // 
            this.TextBoxPesquisa.Location = new System.Drawing.Point(6, 46);
            this.TextBoxPesquisa.Name = "TextBoxPesquisa";
            this.TextBoxPesquisa.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPesquisa.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewConsulta);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 162);
            this.panel1.TabIndex = 2;
            // 
            // listViewConsulta
            // 
            this.listViewConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewConsulta.Location = new System.Drawing.Point(0, 0);
            this.listViewConsulta.Name = "listViewConsulta";
            this.listViewConsulta.Size = new System.Drawing.Size(597, 162);
            this.listViewConsulta.TabIndex = 0;
            this.listViewConsulta.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelDeposito13);
            this.panel2.Controls.Add(this.labelDeposito);
            this.panel2.Controls.Add(this.labelJam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 44);
            this.panel2.TabIndex = 2;
            // 
            // labelDeposito13
            // 
            this.labelDeposito13.AutoSize = true;
            this.labelDeposito13.Location = new System.Drawing.Point(510, 19);
            this.labelDeposito13.Name = "labelDeposito13";
            this.labelDeposito13.Size = new System.Drawing.Size(35, 13);
            this.labelDeposito13.TabIndex = 1;
            this.labelDeposito13.Text = "label4";
            // 
            // labelDeposito
            // 
            this.labelDeposito.AutoSize = true;
            this.labelDeposito.Location = new System.Drawing.Point(303, 19);
            this.labelDeposito.Name = "labelDeposito";
            this.labelDeposito.Size = new System.Drawing.Size(35, 13);
            this.labelDeposito.TabIndex = 1;
            this.labelDeposito.Text = "label4";
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Location = new System.Drawing.Point(105, 19);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(35, 13);
            this.labelJam.TabIndex = 1;
            this.labelJam.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total do Depósito 13°:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total do Depósito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total do JAM:";
            // 
            // frmConsultaValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDataRecolhimento;
        private System.Windows.Forms.RadioButton radioButtonFuncionario;
        private System.Windows.Forms.RadioButton radioButtonCompetencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonGeral;
        private System.Windows.Forms.MaskedTextBox TextBoxPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDeposito13;
        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Label labelTitulo;
    }
}