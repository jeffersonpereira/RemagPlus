namespace RemagPlus.Formularios
{
    partial class frmRptListaFuncionario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonPis = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonInativo);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonAtivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNome);
            this.groupBox2.Controls.Add(this.radioButtonPis);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenação";
            // 
            // radioButtonAtivo
            // 
            this.radioButtonAtivo.AutoSize = true;
            this.radioButtonAtivo.Checked = true;
            this.radioButtonAtivo.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAtivo.TabIndex = 0;
            this.radioButtonAtivo.Text = "Ativos";
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.Location = new System.Drawing.Point(89, 19);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonInativo.TabIndex = 0;
            this.radioButtonInativo.Text = "Inativos";
            this.radioButtonInativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPis
            // 
            this.radioButtonPis.AutoSize = true;
            this.radioButtonPis.Checked = true;
            this.radioButtonPis.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPis.Name = "radioButtonPis";
            this.radioButtonPis.Size = new System.Drawing.Size(74, 17);
            this.radioButtonPis.TabIndex = 0;
            this.radioButtonPis.TabStop = true;
            this.radioButtonPis.Text = "Pis/Pasep";
            this.radioButtonPis.UseVisualStyleBackColor = true;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(97, 19);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 0;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 42);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // frmRptListaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptListaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonInativo;
        private System.Windows.Forms.RadioButton radioButtonAtivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonPis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
    }
}