namespace RemagPlus.Formularios
{
    partial class frmAlteracaoSalarial
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.selecaoFuncionario = new RemagPlus.Formularios.SelecaoFuncionario();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remuneracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.funcionarioPanel = new System.Windows.Forms.Panel();
            this.alteracaoPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.funcionarioPanel.SuspendLayout();
            this.alteracaoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(396, 352);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Percentual",
            "Valor",
            "Valor Fixo"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alteração por";
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DecimalPlaces = 2;
            this.valorNumericUpDown.Location = new System.Drawing.Point(139, 32);
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valorNumericUpDown.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor";
            // 
            // selecaoFuncionario
            // 
            this.selecaoFuncionario.Funcionario = null;
            this.selecaoFuncionario.Location = new System.Drawing.Point(3, 3);
            this.selecaoFuncionario.Name = "selecaoFuncionario";
            this.selecaoFuncionario.Size = new System.Drawing.Size(460, 287);
            this.selecaoFuncionario.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.remuneracao,
            this.Column1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // remuneracao
            // 
            this.remuneracao.DataPropertyName = "remuneracao";
            this.remuneracao.HeaderText = "Salário";
            this.remuneracao.Name = "remuneracao";
            this.remuneracao.ReadOnly = true;
            this.remuneracao.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SalarioAlterado";
            this.Column1.HeaderText = "Novo Salário";
            this.Column1.Name = "Column1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(RemagLib.remag_funcionario);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(316, 352);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 16;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(397, 352);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 16;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // funcionarioPanel
            // 
            this.funcionarioPanel.Controls.Add(this.selecaoFuncionario);
            this.funcionarioPanel.Location = new System.Drawing.Point(12, 59);
            this.funcionarioPanel.Name = "funcionarioPanel";
            this.funcionarioPanel.Size = new System.Drawing.Size(463, 287);
            this.funcionarioPanel.TabIndex = 20;
            // 
            // alteracaoPanel
            // 
            this.alteracaoPanel.Controls.Add(this.dataGridView1);
            this.alteracaoPanel.Location = new System.Drawing.Point(12, 59);
            this.alteracaoPanel.Name = "alteracaoPanel";
            this.alteracaoPanel.Size = new System.Drawing.Size(463, 287);
            this.alteracaoPanel.TabIndex = 21;
            // 
            // frmAlteracaoSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 385);
            this.Controls.Add(this.funcionarioPanel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.alteracaoPanel);
            this.Name = "frmAlteracaoSalarial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração Salarial";
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.funcionarioPanel.ResumeLayout(false);
            this.alteracaoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private RemagPlus.Formularios.SelecaoFuncionario selecaoFuncionario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown valorNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remuneracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel funcionarioPanel;
        private System.Windows.Forms.Panel alteracaoPanel;


    }
}