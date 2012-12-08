namespace RemagPlus.Formularios
{
    partial class frmAlteracaoSalarial
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
            this.TextBoxPis = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSalarioMinimo = new System.Windows.Forms.RadioButton();
            this.radioButtonValor = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxVigenciaValor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTituloVigenciaValor = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.groupBoxFaixa = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorF = new System.Windows.Forms.TextBox();
            this.textBoxValorI = new System.Windows.Forms.TextBox();
            this.Escolha = new System.Windows.Forms.GroupBox();
            this.radioButtonIndividual = new System.Windows.Forms.RadioButton();
            this.radioButtonPorFaixa = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxFaixa.SuspendLayout();
            this.Escolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPis
            // 
            this.TextBoxPis.Enabled = false;
            this.TextBoxPis.Location = new System.Drawing.Point(12, 217);
            this.TextBoxPis.Mask = "0.000.000.000-0";
            this.TextBoxPis.Name = "TextBoxPis";
            this.TextBoxPis.Size = new System.Drawing.Size(96, 20);
            this.TextBoxPis.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Executar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pis/Pasep";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSalarioMinimo);
            this.groupBox1.Controls.Add(this.radioButtonValor);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Alteração";
            // 
            // radioButtonSalarioMinimo
            // 
            this.radioButtonSalarioMinimo.AutoSize = true;
            this.radioButtonSalarioMinimo.Location = new System.Drawing.Point(6, 46);
            this.radioButtonSalarioMinimo.Name = "radioButtonSalarioMinimo";
            this.radioButtonSalarioMinimo.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSalarioMinimo.TabIndex = 1;
            this.radioButtonSalarioMinimo.Text = "Salário Mínimo";
            this.radioButtonSalarioMinimo.UseVisualStyleBackColor = true;
            this.radioButtonSalarioMinimo.CheckedChanged += new System.EventHandler(this.radioButtonSalarioMinimo_CheckedChanged);
            // 
            // radioButtonValor
            // 
            this.radioButtonValor.AutoSize = true;
            this.radioButtonValor.Checked = true;
            this.radioButtonValor.Location = new System.Drawing.Point(6, 23);
            this.radioButtonValor.Name = "radioButtonValor";
            this.radioButtonValor.Size = new System.Drawing.Size(103, 17);
            this.radioButtonValor.TabIndex = 1;
            this.radioButtonValor.TabStop = true;
            this.radioButtonValor.Text = "Valor Específico";
            this.radioButtonValor.UseVisualStyleBackColor = true;
            this.radioButtonValor.CheckedChanged += new System.EventHandler(this.radioButtonValor_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxVigenciaValor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelTituloVigenciaValor);
            this.groupBox3.Controls.Add(this.textBoxQtd);
            this.groupBox3.Location = new System.Drawing.Point(184, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 82);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // TextBoxVigenciaValor
            // 
            this.TextBoxVigenciaValor.Location = new System.Drawing.Point(6, 39);
            this.TextBoxVigenciaValor.Name = "TextBoxVigenciaValor";
            this.TextBoxVigenciaValor.Size = new System.Drawing.Size(81, 20);
            this.TextBoxVigenciaValor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qtd";
            // 
            // labelTituloVigenciaValor
            // 
            this.labelTituloVigenciaValor.AutoSize = true;
            this.labelTituloVigenciaValor.Location = new System.Drawing.Point(3, 23);
            this.labelTituloVigenciaValor.Name = "labelTituloVigenciaValor";
            this.labelTituloVigenciaValor.Size = new System.Drawing.Size(31, 13);
            this.labelTituloVigenciaValor.TabIndex = 1;
            this.labelTituloVigenciaValor.Text = "Valor";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Enabled = false;
            this.textBoxQtd.Location = new System.Drawing.Point(93, 39);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(47, 20);
            this.textBoxQtd.TabIndex = 0;
            // 
            // groupBoxFaixa
            // 
            this.groupBoxFaixa.Controls.Add(this.label2);
            this.groupBoxFaixa.Controls.Add(this.label1);
            this.groupBoxFaixa.Controls.Add(this.textBoxValorF);
            this.groupBoxFaixa.Controls.Add(this.textBoxValorI);
            this.groupBoxFaixa.Enabled = false;
            this.groupBoxFaixa.Location = new System.Drawing.Point(12, 116);
            this.groupBoxFaixa.Name = "groupBoxFaixa";
            this.groupBoxFaixa.Size = new System.Drawing.Size(166, 82);
            this.groupBoxFaixa.TabIndex = 10;
            this.groupBoxFaixa.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Inicial";
            // 
            // textBoxValorF
            // 
            this.textBoxValorF.Location = new System.Drawing.Point(87, 39);
            this.textBoxValorF.Name = "textBoxValorF";
            this.textBoxValorF.Size = new System.Drawing.Size(73, 20);
            this.textBoxValorF.TabIndex = 0;
            // 
            // textBoxValorI
            // 
            this.textBoxValorI.Location = new System.Drawing.Point(8, 39);
            this.textBoxValorI.Name = "textBoxValorI";
            this.textBoxValorI.Size = new System.Drawing.Size(73, 20);
            this.textBoxValorI.TabIndex = 0;
            // 
            // Escolha
            // 
            this.Escolha.Controls.Add(this.radioButtonIndividual);
            this.Escolha.Controls.Add(this.radioButtonPorFaixa);
            this.Escolha.Controls.Add(this.radioButtonTodos);
            this.Escolha.Location = new System.Drawing.Point(12, 12);
            this.Escolha.Name = "Escolha";
            this.Escolha.Size = new System.Drawing.Size(166, 98);
            this.Escolha.TabIndex = 11;
            this.Escolha.TabStop = false;
            this.Escolha.Text = "Funcionários";
            // 
            // radioButtonIndividual
            // 
            this.radioButtonIndividual.AutoSize = true;
            this.radioButtonIndividual.Location = new System.Drawing.Point(6, 65);
            this.radioButtonIndividual.Name = "radioButtonIndividual";
            this.radioButtonIndividual.Size = new System.Drawing.Size(70, 17);
            this.radioButtonIndividual.TabIndex = 1;
            this.radioButtonIndividual.Text = "Individual";
            this.radioButtonIndividual.UseVisualStyleBackColor = true;
            this.radioButtonIndividual.CheckedChanged += new System.EventHandler(this.radioButtonIndividual_CheckedChanged);
            // 
            // radioButtonPorFaixa
            // 
            this.radioButtonPorFaixa.AutoSize = true;
            this.radioButtonPorFaixa.Location = new System.Drawing.Point(6, 42);
            this.radioButtonPorFaixa.Name = "radioButtonPorFaixa";
            this.radioButtonPorFaixa.Size = new System.Drawing.Size(107, 17);
            this.radioButtonPorFaixa.TabIndex = 1;
            this.radioButtonPorFaixa.Text = "Por faixa de valor";
            this.radioButtonPorFaixa.UseVisualStyleBackColor = true;
            this.radioButtonPorFaixa.CheckedChanged += new System.EventHandler(this.radioButtonPorFaixa_CheckedChanged_1);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 23);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 1;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // frmAlteracaoSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 248);
            this.Controls.Add(this.TextBoxPis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxFaixa);
            this.Controls.Add(this.Escolha);
            this.Name = "frmAlteracaoSalarial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração Salarial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxFaixa.ResumeLayout(false);
            this.groupBoxFaixa.PerformLayout();
            this.Escolha.ResumeLayout(false);
            this.Escolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TextBoxPis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSalarioMinimo;
        private System.Windows.Forms.RadioButton radioButtonValor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox TextBoxVigenciaValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTituloVigenciaValor;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.GroupBox groupBoxFaixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValorF;
        private System.Windows.Forms.TextBox textBoxValorI;
        private System.Windows.Forms.GroupBox Escolha;
        private System.Windows.Forms.RadioButton radioButtonPorFaixa;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonIndividual;


    }
}