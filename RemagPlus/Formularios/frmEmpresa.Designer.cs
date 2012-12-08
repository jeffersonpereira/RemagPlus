namespace RemagPlus.Formularios
{
    partial class frmEmpresa
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
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label tipo_inscricaoLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label fpasLabel;
            System.Windows.Forms.Label satLabel;
            System.Windows.Forms.Label cnaeLabel;
            System.Windows.Forms.Label label4;
            this.razao_socialTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_inscricaoComboBox = new System.Windows.Forms.ComboBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pesquisaControlCidade = new RemagPlus.PesquisaControl();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.faxMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.fpasTextBox = new System.Windows.Forms.TextBox();
            this.satTextBox = new System.Windows.Forms.TextBox();
            this.cnaeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pesquisaControlResponsavel = new RemagPlus.PesquisaControl();
            this.pesquisaControlCategoriaEmpresa = new RemagPlus.PesquisaControl();
            razao_socialLabel = new System.Windows.Forms.Label();
            tipo_inscricaoLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            fpasLabel = new System.Windows.Forms.Label();
            satLabel = new System.Windows.Forms.Label();
            cnaeLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(9, 38);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(70, 13);
            razao_socialLabel.TabIndex = 6;
            razao_socialLabel.Text = "Razão Social";
            // 
            // tipo_inscricaoLabel
            // 
            tipo_inscricaoLabel.AutoSize = true;
            tipo_inscricaoLabel.Location = new System.Drawing.Point(327, 37);
            tipo_inscricaoLabel.Name = "tipo_inscricaoLabel";
            tipo_inscricaoLabel.Size = new System.Drawing.Size(89, 13);
            tipo_inscricaoLabel.TabIndex = 7;
            tipo_inscricaoLabel.Text = "Tipo de Inscrição";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(419, 38);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(50, 13);
            cnpjLabel.TabIndex = 8;
            cnpjLabel.Text = "Inscrição";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(6, 24);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(53, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereço";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(285, 24);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(34, 13);
            bairroLabel.TabIndex = 2;
            bairroLabel.Text = "Bairro";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(454, 24);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 4;
            cepLabel.Text = "CEP";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(341, 67);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(435, 67);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 10;
            faxLabel.Text = "Fax";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(3, 106);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(242, 24);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(18, 13);
            numeroLabel.TabIndex = 11;
            numeroLabel.Text = "Nr";
            // 
            // fpasLabel
            // 
            fpasLabel.AutoSize = true;
            fpasLabel.Location = new System.Drawing.Point(344, 286);
            fpasLabel.Name = "fpasLabel";
            fpasLabel.Size = new System.Drawing.Size(34, 13);
            fpasLabel.TabIndex = 11;
            fpasLabel.Text = "FPAS";
            // 
            // satLabel
            // 
            satLabel.AutoSize = true;
            satLabel.Location = new System.Drawing.Point(450, 286);
            satLabel.Name = "satLabel";
            satLabel.Size = new System.Drawing.Size(71, 13);
            satLabel.TabIndex = 12;
            satLabel.Text = "Alíquota SAT";
            // 
            // cnaeLabel
            // 
            cnaeLabel.AutoSize = true;
            cnaeLabel.Location = new System.Drawing.Point(9, 326);
            cnaeLabel.Name = "cnaeLabel";
            cnaeLabel.Size = new System.Drawing.Size(66, 13);
            cnaeLabel.TabIndex = 14;
            cnaeLabel.Text = "CNAE Fiscal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(344, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 6;
            label4.Text = "Código CEF";
            // 
            // razao_socialTextBox
            // 
            this.razao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "razao_social", true));
            this.razao_socialTextBox.Location = new System.Drawing.Point(12, 54);
            this.razao_socialTextBox.MaxLength = 50;
            this.razao_socialTextBox.Name = "razao_socialTextBox";
            this.razao_socialTextBox.Size = new System.Drawing.Size(307, 20);
            this.razao_socialTextBox.TabIndex = 7;
            // 
            // bindingSourceEmpresa
            // 
            this.bindingSourceEmpresa.DataSource = typeof(RemagLib.remag_empresa);
            // 
            // tipo_inscricaoComboBox
            // 
            this.tipo_inscricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "tipo_inscricao", true));
            this.tipo_inscricaoComboBox.FormattingEnabled = true;
            this.tipo_inscricaoComboBox.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.tipo_inscricaoComboBox.Location = new System.Drawing.Point(325, 53);
            this.tipo_inscricaoComboBox.Name = "tipo_inscricaoComboBox";
            this.tipo_inscricaoComboBox.Size = new System.Drawing.Size(91, 21);
            this.tipo_inscricaoComboBox.TabIndex = 8;
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(422, 53);
            this.cnpjMaskedTextBox.Mask = "00.000.000/0000-00";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(133, 20);
            this.cnpjMaskedTextBox.TabIndex = 9;
            this.cnpjMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesquisaControlCidade);
            this.groupBox1.Controls.Add(numeroLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(faxLabel);
            this.groupBox1.Controls.Add(this.faxMaskedTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(cepLabel);
            this.groupBox1.Controls.Add(this.cepMaskedTextBox);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço / Contato";
            // 
            // pesquisaControlCidade
            // 
            this.pesquisaControlCidade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pesquisaControlCidade.Location = new System.Drawing.Point(8, 60);
            this.pesquisaControlCidade.Name = "pesquisaControlCidade";
            this.pesquisaControlCidade.Size = new System.Drawing.Size(312, 41);
            this.pesquisaControlCidade.TabIndex = 14;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(245, 40);
            this.numeroTextBox.MaxLength = 5;
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(37, 20);
            this.numeroTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(6, 122);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(329, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // faxMaskedTextBox
            // 
            this.faxMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "fax", true));
            this.faxMaskedTextBox.Location = new System.Drawing.Point(438, 83);
            this.faxMaskedTextBox.Mask = "(000) 0000-0000";
            this.faxMaskedTextBox.Name = "faxMaskedTextBox";
            this.faxMaskedTextBox.Size = new System.Drawing.Size(97, 20);
            this.faxMaskedTextBox.TabIndex = 11;
            this.faxMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(341, 83);
            this.telefoneMaskedTextBox.Mask = "(000) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(91, 20);
            this.telefoneMaskedTextBox.TabIndex = 9;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(457, 40);
            this.cepMaskedTextBox.Mask = "00.000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.cepMaskedTextBox.TabIndex = 5;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(288, 40);
            this.bairroTextBox.MaxLength = 20;
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(163, 20);
            this.bairroTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(6, 40);
            this.enderecoTextBox.MaxLength = 30;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(233, 20);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // fpasTextBox
            // 
            this.fpasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "fpas", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.fpasTextBox.Location = new System.Drawing.Point(347, 302);
            this.fpasTextBox.MaxLength = 3;
            this.fpasTextBox.Name = "fpasTextBox";
            this.fpasTextBox.Size = new System.Drawing.Size(100, 20);
            this.fpasTextBox.TabIndex = 12;
            // 
            // satTextBox
            // 
            this.satTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "sat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N4"));
            this.satTextBox.Location = new System.Drawing.Point(453, 302);
            this.satTextBox.Name = "satTextBox";
            this.satTextBox.Size = new System.Drawing.Size(100, 20);
            this.satTextBox.TabIndex = 13;
            // 
            // cnaeTextBox
            // 
            this.cnaeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "cnae", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.cnaeTextBox.Location = new System.Drawing.Point(12, 342);
            this.cnaeTextBox.MaxLength = 7;
            this.cnaeTextBox.Name = "cnaeTextBox";
            this.cnaeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnaeTextBox.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSourceEmpresa;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmpresa, "codigo_cef", true));
            this.textBox1.Location = new System.Drawing.Point(347, 97);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pesquisaControlResponsavel
            // 
            this.pesquisaControlResponsavel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pesquisaControlResponsavel.Location = new System.Drawing.Point(12, 282);
            this.pesquisaControlResponsavel.Name = "pesquisaControlResponsavel";
            this.pesquisaControlResponsavel.Size = new System.Drawing.Size(312, 41);
            this.pesquisaControlResponsavel.TabIndex = 16;
            // 
            // pesquisaControlCategoriaEmpresa
            // 
            this.pesquisaControlCategoriaEmpresa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pesquisaControlCategoriaEmpresa.Location = new System.Drawing.Point(13, 76);
            this.pesquisaControlCategoriaEmpresa.Name = "pesquisaControlCategoriaEmpresa";
            this.pesquisaControlCategoriaEmpresa.Size = new System.Drawing.Size(312, 41);
            this.pesquisaControlCategoriaEmpresa.TabIndex = 17;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 388);
            this.ControlBox = false;
            this.Controls.Add(this.pesquisaControlCategoriaEmpresa);
            this.Controls.Add(this.pesquisaControlResponsavel);
            this.Controls.Add(cnaeLabel);
            this.Controls.Add(this.cnaeTextBox);
            this.Controls.Add(satLabel);
            this.Controls.Add(this.satTextBox);
            this.Controls.Add(fpasLabel);
            this.Controls.Add(this.fpasTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjMaskedTextBox);
            this.Controls.Add(tipo_inscricaoLabel);
            this.Controls.Add(this.tipo_inscricaoComboBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(razao_socialLabel);
            this.Controls.Add(this.razao_socialTextBox);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceEmpresa;
        private System.Windows.Forms.TextBox razao_socialTextBox;
        private System.Windows.Forms.ComboBox tipo_inscricaoComboBox;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox faxMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox fpasTextBox;
        private System.Windows.Forms.TextBox satTextBox;
        private System.Windows.Forms.TextBox cnaeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private PesquisaControl pesquisaControlCidade;
        private PesquisaControl pesquisaControlCategoriaEmpresa;
        private PesquisaControl pesquisaControlResponsavel;

    }
}