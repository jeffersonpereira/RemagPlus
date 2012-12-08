namespace RemagPlus.Formularios
{
    partial class frmRptIndividualizacao
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
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonRecolhimento = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
            this.radioButtonCompetencia = new System.Windows.Forms.RadioButton();
            this.TextBoxConteudo = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonRecolhimento);
            this.groupBox1.Controls.Add(this.radioButtonFuncionario);
            this.groupBox1.Controls.Add(this.radioButtonCompetencia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(97, 42);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 1;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // radioButtonRecolhimento
            // 
            this.radioButtonRecolhimento.AutoSize = true;
            this.radioButtonRecolhimento.Location = new System.Drawing.Point(6, 42);
            this.radioButtonRecolhimento.Name = "radioButtonRecolhimento";
            this.radioButtonRecolhimento.Size = new System.Drawing.Size(90, 17);
            this.radioButtonRecolhimento.TabIndex = 1;
            this.radioButtonRecolhimento.Text = "Recolhimento";
            this.radioButtonRecolhimento.UseVisualStyleBackColor = true;
            this.radioButtonRecolhimento.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // radioButtonFuncionario
            // 
            this.radioButtonFuncionario.AutoSize = true;
            this.radioButtonFuncionario.Location = new System.Drawing.Point(97, 19);
            this.radioButtonFuncionario.Name = "radioButtonFuncionario";
            this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionario.TabIndex = 1;
            this.radioButtonFuncionario.Text = "Funcionário";
            this.radioButtonFuncionario.UseVisualStyleBackColor = true;
            this.radioButtonFuncionario.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // radioButtonCompetencia
            // 
            this.radioButtonCompetencia.AutoSize = true;
            this.radioButtonCompetencia.Checked = true;
            this.radioButtonCompetencia.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCompetencia.Name = "radioButtonCompetencia";
            this.radioButtonCompetencia.Size = new System.Drawing.Size(87, 17);
            this.radioButtonCompetencia.TabIndex = 1;
            this.radioButtonCompetencia.TabStop = true;
            this.radioButtonCompetencia.Text = "Competência";
            this.radioButtonCompetencia.UseVisualStyleBackColor = true;
            this.radioButtonCompetencia.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // TextBoxConteudo
            // 
            this.TextBoxConteudo.Location = new System.Drawing.Point(214, 28);
            this.TextBoxConteudo.Mask = "00/0000";
            this.TextBoxConteudo.Name = "TextBoxConteudo";
            this.TextBoxConteudo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxConteudo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRptIndividualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxConteudo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptIndividualizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individualização";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonRecolhimento;
        private System.Windows.Forms.RadioButton radioButtonFuncionario;
        private System.Windows.Forms.RadioButton radioButtonCompetencia;
        private System.Windows.Forms.MaskedTextBox TextBoxConteudo;
        private System.Windows.Forms.Button button1;
    }
}