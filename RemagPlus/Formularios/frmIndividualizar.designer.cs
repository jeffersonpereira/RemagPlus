namespace RemagPlus
{
    partial class IndividualizarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.radioButtonSalarioMinimo = new System.Windows.Forms.RadioButton();
            this.radioButtonRateio = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.TextBoxRecolhimento = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDeposito13 = new System.Windows.Forms.TextBox();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.textBoxJam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 236);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 236);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxQtd);
            this.groupBox1.Controls.Add(this.radioButtonSalarioMinimo);
            this.groupBox1.Controls.Add(this.radioButtonRateio);
            this.groupBox1.Controls.Add(this.radioButtonNormal);
            this.groupBox1.Controls.Add(this.txtCompetencia);
            this.groupBox1.Controls.Add(this.TextBoxRecolhimento);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxDeposito13);
            this.groupBox1.Controls.Add(this.textBoxDeposito);
            this.groupBox1.Controls.Add(this.textBoxJam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forneça as Informações para Individualização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Qtd";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(267, 92);
            this.textBoxQtd.MaxLength = 4;
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(44, 20);
            this.textBoxQtd.TabIndex = 6;
            this.textBoxQtd.Text = "1";
            // 
            // radioButtonSalarioMinimo
            // 
            this.radioButtonSalarioMinimo.AutoSize = true;
            this.radioButtonSalarioMinimo.Location = new System.Drawing.Point(166, 92);
            this.radioButtonSalarioMinimo.Name = "radioButtonSalarioMinimo";
            this.radioButtonSalarioMinimo.Size = new System.Drawing.Size(95, 17);
            this.radioButtonSalarioMinimo.TabIndex = 5;
            this.radioButtonSalarioMinimo.Text = "Salário Mínimo";
            this.radioButtonSalarioMinimo.UseVisualStyleBackColor = true;
            this.radioButtonSalarioMinimo.CheckedChanged += new System.EventHandler(this.radioButtonSalarioMinimo_CheckedChanged);
            // 
            // radioButtonRateio
            // 
            this.radioButtonRateio.AutoSize = true;
            this.radioButtonRateio.Location = new System.Drawing.Point(84, 92);
            this.radioButtonRateio.Name = "radioButtonRateio";
            this.radioButtonRateio.Size = new System.Drawing.Size(56, 17);
            this.radioButtonRateio.TabIndex = 5;
            this.radioButtonRateio.Text = "Rateio";
            this.radioButtonRateio.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(6, 92);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 5;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // TextBoxRecolhimento
            // 
            this.TextBoxRecolhimento.Location = new System.Drawing.Point(112, 47);
            this.TextBoxRecolhimento.Mask = "00/00/0000";
            this.TextBoxRecolhimento.Name = "TextBoxRecolhimento";
            this.TextBoxRecolhimento.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRecolhimento.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desfazer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDeposito13
            // 
            this.textBoxDeposito13.Location = new System.Drawing.Point(430, 47);
            this.textBoxDeposito13.Name = "textBoxDeposito13";
            this.textBoxDeposito13.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeposito13.TabIndex = 2;
            this.textBoxDeposito13.Text = "0,00";
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(324, 47);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeposito.TabIndex = 2;
            this.textBoxDeposito.Text = "0,00";
            // 
            // textBoxJam
            // 
            this.textBoxJam.Location = new System.Drawing.Point(218, 47);
            this.textBoxJam.Name = "textBoxJam";
            this.textBoxJam.Size = new System.Drawing.Size(100, 20);
            this.textBoxJam.TabIndex = 2;
            this.textBoxJam.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "(R$) Depósito 13°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "(R$) Depósito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "(R$) JAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recolhimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competência";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(573, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.Location = new System.Drawing.Point(3, 47);
            this.txtCompetencia.Mask = "00/0000";
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(100, 20);
            this.txtCompetencia.TabIndex = 4;
            // 
            // IndividualizarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 410);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "IndividualizarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individualizar";
            this.Load += new System.EventHandler(this.IndividualizarForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeposito13;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.TextBox textBoxJam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox TextBoxRecolhimento;
        private System.Windows.Forms.RadioButton radioButtonRateio;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonSalarioMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.MaskedTextBox txtCompetencia;
    }
}