namespace RemagPlus.Formularios
{
    partial class frmResponsavel
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tipo_inscricaoLabel;
            System.Windows.Forms.Label cnpj_cei_cpfLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contatoLabel;
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceResponsavel = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_inscricaoComboBox = new System.Windows.Forms.ComboBox();
            this.cnpj_cei_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.pesquisaControl1 = new RemagPlus.PesquisaControl();
            nomeLabel = new System.Windows.Forms.Label();
            tipo_inscricaoLabel = new System.Windows.Forms.Label();
            cnpj_cei_cpfLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResponsavel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(9, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // tipo_inscricaoLabel
            // 
            tipo_inscricaoLabel.AutoSize = true;
            tipo_inscricaoLabel.Location = new System.Drawing.Point(310, 42);
            tipo_inscricaoLabel.Name = "tipo_inscricaoLabel";
            tipo_inscricaoLabel.Size = new System.Drawing.Size(28, 13);
            tipo_inscricaoLabel.TabIndex = 5;
            tipo_inscricaoLabel.Text = "Tipo";
            // 
            // cnpj_cei_cpfLabel
            // 
            cnpj_cei_cpfLabel.AutoSize = true;
            cnpj_cei_cpfLabel.Location = new System.Drawing.Point(385, 42);
            cnpj_cei_cpfLabel.Name = "cnpj_cei_cpfLabel";
            cnpj_cei_cpfLabel.Size = new System.Drawing.Size(50, 13);
            cnpj_cei_cpfLabel.TabIndex = 6;
            cnpj_cei_cpfLabel.Text = "Inscrição";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(3, 27);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereço";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(268, 27);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(34, 13);
            bairroLabel.TabIndex = 2;
            bairroLabel.Text = "Bairro";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(6, 66);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 4;
            cepLabel.Text = "CEP";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(6, 105);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(115, 105);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Location = new System.Drawing.Point(6, 144);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(105, 13);
            contatoLabel.TabIndex = 12;
            contatoLabel.Text = "Pessoa para contato";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 59);
            this.nomeTextBox.MaxLength = 50;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(295, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // bindingSourceResponsavel
            // 
            this.bindingSourceResponsavel.DataSource = typeof(RemagLib.remag_responsavel);
            // 
            // tipo_inscricaoComboBox
            // 
            this.tipo_inscricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "tipo_inscricao", true));
            this.tipo_inscricaoComboBox.FormattingEnabled = true;
            this.tipo_inscricaoComboBox.Items.AddRange(new object[] {
            "CNPJ",
            "CEI",
            "CPF"});
            this.tipo_inscricaoComboBox.Location = new System.Drawing.Point(313, 58);
            this.tipo_inscricaoComboBox.Name = "tipo_inscricaoComboBox";
            this.tipo_inscricaoComboBox.Size = new System.Drawing.Size(68, 21);
            this.tipo_inscricaoComboBox.TabIndex = 6;
            // 
            // cnpj_cei_cpfMaskedTextBox
            // 
            this.cnpj_cei_cpfMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cnpj_cei_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "cnpj_cei_cpf", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cnpj_cei_cpfMaskedTextBox.Location = new System.Drawing.Point(388, 58);
            this.cnpj_cei_cpfMaskedTextBox.Mask = "00.000.000/0000-00";
            this.cnpj_cei_cpfMaskedTextBox.Name = "cnpj_cei_cpfMaskedTextBox";
            this.cnpj_cei_cpfMaskedTextBox.Size = new System.Drawing.Size(114, 20);
            this.cnpj_cei_cpfMaskedTextBox.TabIndex = 7;
            this.cnpj_cei_cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesquisaControl1);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(contatoLabel);
            this.groupBox1.Controls.Add(this.contatoTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(cepLabel);
            this.groupBox1.Controls.Add(this.cepMaskedTextBox);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço / Contato";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "contato", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contatoTextBox.Location = new System.Drawing.Point(9, 160);
            this.contatoTextBox.MaxLength = 50;
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(253, 20);
            this.contatoTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(115, 121);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(355, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "telefone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(9, 121);
            this.telefoneMaskedTextBox.Mask = "(000) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 9;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "cep", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(6, 82);
            this.cepMaskedTextBox.Mask = "00.000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTextBox.TabIndex = 5;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(268, 43);
            this.bairroTextBox.MaxLength = 20;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(202, 20);
            this.bairroTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceResponsavel, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(6, 43);
            this.enderecoTextBox.MaxLength = 30;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(256, 20);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // pesquisaControl1
            // 
            this.pesquisaControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pesquisaControl1.Location = new System.Drawing.Point(109, 63);
            this.pesquisaControl1.Name = "pesquisaControl1";
            this.pesquisaControl1.Size = new System.Drawing.Size(361, 41);
            this.pesquisaControl1.TabIndex = 14;
            // 
            // frmResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 333);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(cnpj_cei_cpfLabel);
            this.Controls.Add(this.cnpj_cei_cpfMaskedTextBox);
            this.Controls.Add(tipo_inscricaoLabel);
            this.Controls.Add(this.tipo_inscricaoComboBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsável";
            this.Load += new System.EventHandler(this.frmResponsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResponsavel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceResponsavel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox tipo_inscricaoComboBox;
        private System.Windows.Forms.MaskedTextBox cnpj_cei_cpfMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private PesquisaControl pesquisaControl1;
    }
}