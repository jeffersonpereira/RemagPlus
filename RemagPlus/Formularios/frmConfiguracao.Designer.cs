namespace RemagPlus.Formularios
{
    partial class frmConfiguracao
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSefip = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxRemag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogRemag = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSefip
            // 
            this.textBoxSefip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sefip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSefip.Location = new System.Drawing.Point(12, 37);
            this.textBoxSefip.Name = "textBoxSefip";
            this.textBoxSefip.Size = new System.Drawing.Size(361, 20);
            this.textBoxSefip.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(RemagLib.remag_configuracao);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxRemag
            // 
            this.textBoxRemag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "remag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxRemag.Location = new System.Drawing.Point(12, 83);
            this.textBoxRemag.Name = "textBoxRemag";
            this.textBoxRemag.Size = new System.Drawing.Size(361, 20);
            this.textBoxRemag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEFIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remag";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(344, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(263, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Sefip";
            this.openFileDialog1.Filter = "Arquivo EXE| *.exe";
            // 
            // openFileDialogRemag
            // 
            this.openFileDialogRemag.FileName = "Remag";
            this.openFileDialogRemag.Filter = "Arquivo EXE| *.exe";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 164);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemag);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSefip);
            this.Controls.Add(this.button1);
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfiguracao_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSefip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxRemag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogRemag;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}