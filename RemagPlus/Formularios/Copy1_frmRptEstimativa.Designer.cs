namespace RemagPlus.Formularios
{
    partial class frmRptEstimativa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.radioButtonSalarioMinimo = new System.Windows.Forms.RadioButton();
            this.radioButtonRemuneracao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxQtd);
            this.groupBox1.Controls.Add(this.radioButtonSalarioMinimo);
            this.groupBox1.Controls.Add(this.radioButtonRemuneracao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base para Cálculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qtd";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(107, 53);
            this.textBoxQtd.MaxLength = 4;
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(44, 20);
            this.textBoxQtd.TabIndex = 1;
            this.textBoxQtd.Text = "1";
            // 
            // radioButtonSalarioMinimo
            // 
            this.radioButtonSalarioMinimo.AutoSize = true;
            this.radioButtonSalarioMinimo.Location = new System.Drawing.Point(6, 54);
            this.radioButtonSalarioMinimo.Name = "radioButtonSalarioMinimo";
            this.radioButtonSalarioMinimo.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSalarioMinimo.TabIndex = 1;
            this.radioButtonSalarioMinimo.Text = "Salário Mínimo";
            this.radioButtonSalarioMinimo.UseVisualStyleBackColor = true;
            this.radioButtonSalarioMinimo.CheckedChanged += new System.EventHandler(this.radioButtonSalarioMinimo_CheckedChanged);
            // 
            // radioButtonRemuneracao
            // 
            this.radioButtonRemuneracao.AutoSize = true;
            this.radioButtonRemuneracao.Checked = true;
            this.radioButtonRemuneracao.Location = new System.Drawing.Point(6, 31);
            this.radioButtonRemuneracao.Name = "radioButtonRemuneracao";
            this.radioButtonRemuneracao.Size = new System.Drawing.Size(92, 17);
            this.radioButtonRemuneracao.TabIndex = 1;
            this.radioButtonRemuneracao.TabStop = true;
            this.radioButtonRemuneracao.Text = "Remuneração";
            this.radioButtonRemuneracao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(197, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(112, 51);
            this.maskedTextBox2.Mask = "00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 51);
            this.maskedTextBox1.Mask = "00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonFuncionario);
            this.groupBox3.Controls.Add(this.radioButtonTodos);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 17);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 1;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionario
            // 
            this.radioButtonFuncionario.AutoSize = true;
            this.radioButtonFuncionario.Location = new System.Drawing.Point(93, 17);
            this.radioButtonFuncionario.Name = "radioButtonFuncionario";
            this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionario.TabIndex = 1;
            this.radioButtonFuncionario.Text = "Funcionário";
            this.radioButtonFuncionario.UseVisualStyleBackColor = true;
            this.radioButtonFuncionario.CheckedChanged += new System.EventHandler(this.radioButtonFuncionario_CheckedChanged);
            // 
            // maskedTextBoxFuncionario
            // 
            this.maskedTextBoxFuncionario.Enabled = false;
            this.maskedTextBoxFuncionario.Location = new System.Drawing.Point(206, 134);
            this.maskedTextBoxFuncionario.Name = "maskedTextBoxFuncionario";
            this.maskedTextBoxFuncionario.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFuncionario.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pis/Pasep";
            // 
            // frmRptEstimativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 177);
            this.Controls.Add(this.maskedTextBoxFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptEstimativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estimativa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.RadioButton radioButtonSalarioMinimo;
        private System.Windows.Forms.RadioButton radioButtonRemuneracao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonFuncionario;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFuncionario;
        private System.Windows.Forms.Label label4;
    }
}