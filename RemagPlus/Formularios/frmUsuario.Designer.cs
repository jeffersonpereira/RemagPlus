namespace RemagPlus.Formularios
{
    partial class frmUsuario
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label senhaLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSourceUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            loginLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(9, 81);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(33, 13);
            loginLabel.TabIndex = 51;
            loginLabel.Text = "Login";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 40);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 53;
            nomeLabel.Text = "Nome";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(338, 81);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(38, 13);
            senhaLabel.TabIndex = 55;
            senhaLabel.Text = "Senha";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bindingSourceUsuario
            // 
            this.bindingSourceUsuario.DataSource = typeof(RemagLib.remag_usuario);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsuario, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(12, 97);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(323, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsuario, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 56);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(458, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsuario, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(341, 97);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(129, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 141);
            this.ControlBox = false;
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSourceUsuario;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}