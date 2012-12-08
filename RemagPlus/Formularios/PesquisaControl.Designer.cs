namespace RemagPlus
{
    partial class PesquisaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaControl));
            this.editPesquisa = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editPesquisa
            // 
            this.editPesquisa.Location = new System.Drawing.Point(0, 17);
            this.editPesquisa.Multiline = true;
            this.editPesquisa.Name = "editPesquisa";
            this.editPesquisa.ReadOnly = true;
            this.editPesquisa.Size = new System.Drawing.Size(248, 25);
            this.editPesquisa.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Image = global::RemagPlus.Properties.Resources.edit_trash;
            this.buttonClear.Location = new System.Drawing.Point(279, 17);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(33, 25);
            this.buttonClear.TabIndex = 1;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(247, 17);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(33, 25);
            this.btnPesquisa.TabIndex = 1;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(3, 1);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(35, 13);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "label1";
            // 
            // PesquisaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.editPesquisa);
            this.Name = "PesquisaControl";
            this.Size = new System.Drawing.Size(312, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox editPesquisa;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label tituloLabel;

    }
}
