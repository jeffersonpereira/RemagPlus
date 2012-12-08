namespace RemagPlus.Formularios
{
    partial class frmRptSalarioMinimo
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
            this.radioButtonVigencia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxDataI = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxDataF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVigencia);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 19);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 0;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonVigencia
            // 
            this.radioButtonVigencia.AutoSize = true;
            this.radioButtonVigencia.Location = new System.Drawing.Point(96, 19);
            this.radioButtonVigencia.Name = "radioButtonVigencia";
            this.radioButtonVigencia.Size = new System.Drawing.Size(66, 17);
            this.radioButtonVigencia.TabIndex = 0;
            this.radioButtonVigencia.Text = "Vigência";
            this.radioButtonVigencia.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TextBoxDataF);
            this.groupBox2.Controls.Add(this.TextBoxDataI);
            this.groupBox2.Location = new System.Drawing.Point(209, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // TextBoxDataI
            // 
            this.TextBoxDataI.Location = new System.Drawing.Point(6, 36);
            this.TextBoxDataI.Mask = "00/00/0000";
            this.TextBoxDataI.Name = "TextBoxDataI";
            this.TextBoxDataI.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDataI.TabIndex = 1;
            // 
            // TextBoxDataF
            // 
            this.TextBoxDataF.Location = new System.Drawing.Point(112, 36);
            this.TextBoxDataF.Mask = "00/00/0000";
            this.TextBoxDataF.Name = "TextBoxDataF";
            this.TextBoxDataF.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDataF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRptSalarioMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptSalarioMinimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salário Mínimo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonVigencia;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextBoxDataF;
        private System.Windows.Forms.MaskedTextBox TextBoxDataI;
        private System.Windows.Forms.Button button1;
    }
}