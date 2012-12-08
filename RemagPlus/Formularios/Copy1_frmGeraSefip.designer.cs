namespace RemagPlus
{
    partial class TelaGeraSefip
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
            this.textBoxCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCodPagamento = new System.Windows.Forms.TextBox();
            this.comboBoxModalidade = new System.Windows.Forms.ComboBox();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonIndividualizacaoAcaoFiscal = new System.Windows.Forms.RadioButton();
            this.radioButtonIndividualizacao = new System.Windows.Forms.RadioButton();
            this.radioButtonFgtsAtrasoAcaoFiscal = new System.Windows.Forms.RadioButton();
            this.radioButtonFgtsAtraso = new System.Windows.Forms.RadioButton();
            this.radioButtonFgtsPrazo = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCaminho = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDtInss = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonInssAtraso = new System.Windows.Forms.RadioButton();
            this.radioButtonInssPrazo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCompetencia);
            this.groupBox1.Controls.Add(this.textBoxCodPagamento);
            this.groupBox1.Controls.Add(this.comboBoxModalidade);
            this.groupBox1.Controls.Add(this.comboBoxCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // textBoxCompetencia
            // 
            this.textBoxCompetencia.Location = new System.Drawing.Point(9, 51);
            this.textBoxCompetencia.Mask = "00/0000";
            this.textBoxCompetencia.Name = "textBoxCompetencia";
            this.textBoxCompetencia.Size = new System.Drawing.Size(103, 20);
            this.textBoxCompetencia.TabIndex = 1;
            // 
            // textBoxCodPagamento
            // 
            this.textBoxCodPagamento.Location = new System.Drawing.Point(342, 92);
            this.textBoxCodPagamento.MaxLength = 4;
            this.textBoxCodPagamento.Name = "textBoxCodPagamento";
            this.textBoxCodPagamento.Size = new System.Drawing.Size(119, 20);
            this.textBoxCodPagamento.TabIndex = 3;
            this.textBoxCodPagamento.Text = "2402";
            // 
            // comboBoxModalidade
            // 
            this.comboBoxModalidade.FormattingEnabled = true;
            this.comboBoxModalidade.Location = new System.Drawing.Point(9, 91);
            this.comboBoxModalidade.Name = "comboBoxModalidade";
            this.comboBoxModalidade.Size = new System.Drawing.Size(327, 21);
            this.comboBoxModalidade.TabIndex = 2;
            // 
            // comboBoxCodigo
            // 
            this.comboBoxCodigo.FormattingEnabled = true;
            this.comboBoxCodigo.Location = new System.Drawing.Point(118, 50);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(343, 21);
            this.comboBoxCodigo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código de Pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de Recolhimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competência";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxData);
            this.groupBox2.Controls.Add(this.radioButtonIndividualizacaoAcaoFiscal);
            this.groupBox2.Controls.Add(this.radioButtonIndividualizacao);
            this.groupBox2.Controls.Add(this.radioButtonFgtsAtrasoAcaoFiscal);
            this.groupBox2.Controls.Add(this.radioButtonFgtsAtraso);
            this.groupBox2.Controls.Add(this.radioButtonFgtsPrazo);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FGTS";
            // 
            // TextBoxData
            // 
            this.TextBoxData.Location = new System.Drawing.Point(161, 39);
            this.TextBoxData.Mask = "00/00/0000";
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Size = new System.Drawing.Size(77, 20);
            this.TextBoxData.TabIndex = 1;
            // 
            // radioButtonIndividualizacaoAcaoFiscal
            // 
            this.radioButtonIndividualizacaoAcaoFiscal.AutoSize = true;
            this.radioButtonIndividualizacaoAcaoFiscal.Location = new System.Drawing.Point(11, 111);
            this.radioButtonIndividualizacaoAcaoFiscal.Name = "radioButtonIndividualizacaoAcaoFiscal";
            this.radioButtonIndividualizacaoAcaoFiscal.Size = new System.Drawing.Size(166, 17);
            this.radioButtonIndividualizacaoAcaoFiscal.TabIndex = 0;
            this.radioButtonIndividualizacaoAcaoFiscal.Text = "Individualização - Ação FIscal";
            this.radioButtonIndividualizacaoAcaoFiscal.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndividualizacao
            // 
            this.radioButtonIndividualizacao.AutoSize = true;
            this.radioButtonIndividualizacao.Location = new System.Drawing.Point(11, 88);
            this.radioButtonIndividualizacao.Name = "radioButtonIndividualizacao";
            this.radioButtonIndividualizacao.Size = new System.Drawing.Size(101, 17);
            this.radioButtonIndividualizacao.TabIndex = 0;
            this.radioButtonIndividualizacao.Text = "Individualização";
            this.radioButtonIndividualizacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonFgtsAtrasoAcaoFiscal
            // 
            this.radioButtonFgtsAtrasoAcaoFiscal.AutoSize = true;
            this.radioButtonFgtsAtrasoAcaoFiscal.Location = new System.Drawing.Point(11, 65);
            this.radioButtonFgtsAtrasoAcaoFiscal.Name = "radioButtonFgtsAtrasoAcaoFiscal";
            this.radioButtonFgtsAtrasoAcaoFiscal.Size = new System.Drawing.Size(137, 17);
            this.radioButtonFgtsAtrasoAcaoFiscal.TabIndex = 0;
            this.radioButtonFgtsAtrasoAcaoFiscal.Tag = "1";
            this.radioButtonFgtsAtrasoAcaoFiscal.Text = "Em Atraso - Ação Fiscal";
            this.radioButtonFgtsAtrasoAcaoFiscal.UseVisualStyleBackColor = true;
            // 
            // radioButtonFgtsAtraso
            // 
            this.radioButtonFgtsAtraso.AutoSize = true;
            this.radioButtonFgtsAtraso.Location = new System.Drawing.Point(9, 42);
            this.radioButtonFgtsAtraso.Name = "radioButtonFgtsAtraso";
            this.radioButtonFgtsAtraso.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFgtsAtraso.TabIndex = 0;
            this.radioButtonFgtsAtraso.Tag = "1";
            this.radioButtonFgtsAtraso.Text = "Em Atraso";
            this.radioButtonFgtsAtraso.UseVisualStyleBackColor = true;
            // 
            // radioButtonFgtsPrazo
            // 
            this.radioButtonFgtsPrazo.AutoSize = true;
            this.radioButtonFgtsPrazo.Checked = true;
            this.radioButtonFgtsPrazo.Location = new System.Drawing.Point(9, 19);
            this.radioButtonFgtsPrazo.Name = "radioButtonFgtsPrazo";
            this.radioButtonFgtsPrazo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFgtsPrazo.TabIndex = 0;
            this.radioButtonFgtsPrazo.TabStop = true;
            this.radioButtonFgtsPrazo.Text = "Prazo";
            this.radioButtonFgtsPrazo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gerar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCaminho
            // 
            this.textBoxCaminho.Location = new System.Drawing.Point(18, 316);
            this.textBoxCaminho.Name = "textBoxCaminho";
            this.textBoxCaminho.Size = new System.Drawing.Size(318, 20);
            this.textBoxCaminho.TabIndex = 2;
            this.textBoxCaminho.Text = "c:\\SEFIP.RE";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Sefip";
            this.saveFileDialog1.Filter = "Aqruivo Sefip|*.re";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Caminho de geração";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDtInss);
            this.groupBox3.Controls.Add(this.radioButtonInssAtraso);
            this.groupBox3.Controls.Add(this.radioButtonInssPrazo);
            this.groupBox3.Location = new System.Drawing.Point(268, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 146);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INSS";
            // 
            // textBoxDtInss
            // 
            this.textBoxDtInss.Location = new System.Drawing.Point(118, 39);
            this.textBoxDtInss.Mask = "00/00/0000";
            this.textBoxDtInss.Name = "textBoxDtInss";
            this.textBoxDtInss.Size = new System.Drawing.Size(77, 20);
            this.textBoxDtInss.TabIndex = 1;
            // 
            // radioButtonInssAtraso
            // 
            this.radioButtonInssAtraso.AutoSize = true;
            this.radioButtonInssAtraso.Location = new System.Drawing.Point(9, 42);
            this.radioButtonInssAtraso.Name = "radioButtonInssAtraso";
            this.radioButtonInssAtraso.Size = new System.Drawing.Size(73, 17);
            this.radioButtonInssAtraso.TabIndex = 0;
            this.radioButtonInssAtraso.Text = "Em Atraso";
            this.radioButtonInssAtraso.UseVisualStyleBackColor = true;
            // 
            // radioButtonInssPrazo
            // 
            this.radioButtonInssPrazo.AutoSize = true;
            this.radioButtonInssPrazo.Checked = true;
            this.radioButtonInssPrazo.Location = new System.Drawing.Point(9, 19);
            this.radioButtonInssPrazo.Name = "radioButtonInssPrazo";
            this.radioButtonInssPrazo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonInssPrazo.TabIndex = 0;
            this.radioButtonInssPrazo.TabStop = true;
            this.radioButtonInssPrazo.Text = "Prazo";
            this.radioButtonInssPrazo.UseVisualStyleBackColor = true;
            // 
            // TelaGeraSefip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCaminho);
            this.Name = "TelaGeraSefip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar SEFIP";
            this.Load += new System.EventHandler(this.TelaGeraSefip_Load);
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
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox TextBoxData;
        private System.Windows.Forms.RadioButton radioButtonFgtsAtraso;
        private System.Windows.Forms.RadioButton radioButtonFgtsPrazo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCaminho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxCodPagamento;
        private System.Windows.Forms.ComboBox comboBoxModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFgtsAtrasoAcaoFiscal;
        private System.Windows.Forms.RadioButton radioButtonIndividualizacaoAcaoFiscal;
        private System.Windows.Forms.RadioButton radioButtonIndividualizacao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox textBoxDtInss;
        private System.Windows.Forms.RadioButton radioButtonInssAtraso;
        private System.Windows.Forms.RadioButton radioButtonInssPrazo;
        private System.Windows.Forms.MaskedTextBox textBoxCompetencia;
    }
}