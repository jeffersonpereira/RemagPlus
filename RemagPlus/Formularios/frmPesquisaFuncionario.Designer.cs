namespace RemagPlus.Formularios
{
    partial class frmPesquisaFuncionario
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
            this.selecaocomboBox = new System.Windows.Forms.ComboBox();
            this.admissaoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomePanel = new System.Windows.Forms.Panel();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pisPanel = new System.Windows.Forms.Panel();
            this.pisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.origemListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.destinoListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.admissaoPanel.SuspendLayout();
            this.nomePanel.SuspendLayout();
            this.pisPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selecaocomboBox
            // 
            this.selecaocomboBox.FormattingEnabled = true;
            this.selecaocomboBox.Items.AddRange(new object[] {
            "Nome",
            "Data de Admissão",
            "PIS\\PASEP"});
            this.selecaocomboBox.Location = new System.Drawing.Point(12, 28);
            this.selecaocomboBox.Name = "selecaocomboBox";
            this.selecaocomboBox.Size = new System.Drawing.Size(121, 21);
            this.selecaocomboBox.TabIndex = 0;
            this.selecaocomboBox.SelectedIndexChanged += new System.EventHandler(this.selecaocomboBox_SelectedIndexChanged);
            // 
            // admissaoPanel
            // 
            this.admissaoPanel.Controls.Add(this.label2);
            this.admissaoPanel.Controls.Add(this.label1);
            this.admissaoPanel.Controls.Add(this.finalDateTimePicker);
            this.admissaoPanel.Controls.Add(this.inicialDateTimePicker);
            this.admissaoPanel.Location = new System.Drawing.Point(148, 12);
            this.admissaoPanel.Name = "admissaoPanel";
            this.admissaoPanel.Size = new System.Drawing.Size(373, 40);
            this.admissaoPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial";
            // 
            // finalDateTimePicker
            // 
            this.finalDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finalDateTimePicker.Location = new System.Drawing.Point(123, 17);
            this.finalDateTimePicker.Name = "finalDateTimePicker";
            this.finalDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.finalDateTimePicker.TabIndex = 3;
            // 
            // inicialDateTimePicker
            // 
            this.inicialDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.inicialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inicialDateTimePicker.Location = new System.Drawing.Point(3, 17);
            this.inicialDateTimePicker.Name = "inicialDateTimePicker";
            this.inicialDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.inicialDateTimePicker.TabIndex = 3;
            // 
            // nomePanel
            // 
            this.nomePanel.Controls.Add(this.nomeTextBox);
            this.nomePanel.Controls.Add(this.label4);
            this.nomePanel.Location = new System.Drawing.Point(148, 12);
            this.nomePanel.Name = "nomePanel";
            this.nomePanel.Size = new System.Drawing.Size(373, 40);
            this.nomePanel.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 17);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(364, 20);
            this.nomeTextBox.TabIndex = 2;
            this.nomeTextBox.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // pisPanel
            // 
            this.pisPanel.Controls.Add(this.pisTextBox);
            this.pisPanel.Controls.Add(this.label3);
            this.pisPanel.Location = new System.Drawing.Point(148, 12);
            this.pisPanel.Name = "pisPanel";
            this.pisPanel.Size = new System.Drawing.Size(373, 40);
            this.pisPanel.TabIndex = 1;
            // 
            // pisTextBox
            // 
            this.pisTextBox.Location = new System.Drawing.Point(6, 17);
            this.pisTextBox.Mask = "0.000.000.000-0";
            this.pisTextBox.Name = "pisTextBox";
            this.pisTextBox.Size = new System.Drawing.Size(100, 20);
            this.pisTextBox.TabIndex = 3;
            this.pisTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pis\\Pasep";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.origemListView);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 246);
            this.panel1.TabIndex = 2;
            // 
            // origemListView
            // 
            this.origemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.origemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origemListView.FullRowSelect = true;
            this.origemListView.Location = new System.Drawing.Point(0, 0);
            this.origemListView.Name = "origemListView";
            this.origemListView.Size = new System.Drawing.Size(225, 246);
            this.origemListView.TabIndex = 0;
            this.origemListView.UseCompatibleStateImageBehavior = false;
            this.origemListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pis";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 146;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.destinoListView);
            this.panel2.Location = new System.Drawing.Point(296, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 246);
            this.panel2.TabIndex = 2;
            // 
            // destinoListView
            // 
            this.destinoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.destinoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinoListView.FullRowSelect = true;
            this.destinoListView.Location = new System.Drawing.Point(0, 0);
            this.destinoListView.Name = "destinoListView";
            this.destinoListView.Size = new System.Drawing.Size(225, 246);
            this.destinoListView.TabIndex = 0;
            this.destinoListView.UseCompatibleStateImageBehavior = false;
            this.destinoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pis";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 147;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(446, 310);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button5.Location = new System.Drawing.Point(12, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // frmPesquisaFuncionario
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 339);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pisPanel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nomePanel);
            this.Controls.Add(this.admissaoPanel);
            this.Controls.Add(this.selecaocomboBox);
            this.Name = "frmPesquisaFuncionario";
            this.Text = "Seleção de funcionários";
            this.admissaoPanel.ResumeLayout(false);
            this.admissaoPanel.PerformLayout();
            this.nomePanel.ResumeLayout(false);
            this.nomePanel.PerformLayout();
            this.pisPanel.ResumeLayout(false);
            this.pisPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selecaocomboBox;
        private System.Windows.Forms.Panel admissaoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker finalDateTimePicker;
        private System.Windows.Forms.DateTimePicker inicialDateTimePicker;
        private System.Windows.Forms.Panel nomePanel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pisPanel;
        private System.Windows.Forms.MaskedTextBox pisTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView origemListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView destinoListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button5;

    }
}