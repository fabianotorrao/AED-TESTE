namespace ex3
{
    partial class consultas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.entradas_check = new System.Windows.Forms.CheckBox();
            this.saidas_check = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n_estudante_txt = new System.Windows.Forms.NumericUpDown();
            this.consult_btn = new System.Windows.Forms.Button();
            this.conteudo_tabela = new System.Windows.Forms.DataGridView();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dataehora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_estudante_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conteudo_tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saidas_check);
            this.groupBox1.Controls.Add(this.entradas_check);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Tipo de Movimentos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.consult_btn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 312);
            this.panel1.TabIndex = 1;
            // 
            // entradas_check
            // 
            this.entradas_check.AutoSize = true;
            this.entradas_check.Location = new System.Drawing.Point(7, 20);
            this.entradas_check.Name = "entradas_check";
            this.entradas_check.Size = new System.Drawing.Size(68, 17);
            this.entradas_check.TabIndex = 0;
            this.entradas_check.Text = "Entradas";
            this.entradas_check.UseVisualStyleBackColor = true;
            // 
            // saidas_check
            // 
            this.saidas_check.AutoSize = true;
            this.saidas_check.Location = new System.Drawing.Point(7, 52);
            this.saidas_check.Name = "saidas_check";
            this.saidas_check.Size = new System.Drawing.Size(60, 17);
            this.saidas_check.TabIndex = 1;
            this.saidas_check.Text = "Saídas";
            this.saidas_check.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.n_estudante_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número :";
            // 
            // n_estudante_txt
            // 
            this.n_estudante_txt.Location = new System.Drawing.Point(63, 56);
            this.n_estudante_txt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.n_estudante_txt.Name = "n_estudante_txt";
            this.n_estudante_txt.Size = new System.Drawing.Size(103, 20);
            this.n_estudante_txt.TabIndex = 1;
            // 
            // consult_btn
            // 
            this.consult_btn.Location = new System.Drawing.Point(11, 236);
            this.consult_btn.Name = "consult_btn";
            this.consult_btn.Size = new System.Drawing.Size(166, 61);
            this.consult_btn.TabIndex = 2;
            this.consult_btn.Text = "Consultar";
            this.consult_btn.UseVisualStyleBackColor = true;
            this.consult_btn.Click += new System.EventHandler(this.consult_btn_Click);
            // 
            // conteudo_tabela
            // 
            this.conteudo_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conteudo_tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número,
            this.Dataehora,
            this.Movimento});
            this.conteudo_tabela.Location = new System.Drawing.Point(290, 12);
            this.conteudo_tabela.Name = "conteudo_tabela";
            this.conteudo_tabela.Size = new System.Drawing.Size(404, 312);
            this.conteudo_tabela.TabIndex = 2;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            // 
            // Dataehora
            // 
            this.Dataehora.HeaderText = "Data e hora";
            this.Dataehora.Name = "Dataehora";
            this.Dataehora.Width = 150;
            // 
            // Movimento
            // 
            this.Movimento.HeaderText = "Movimento";
            this.Movimento.Name = "Movimento";
            // 
            // consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 336);
            this.Controls.Add(this.conteudo_tabela);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultas_FormClosing);
            this.Load += new System.EventHandler(this.consultas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_estudante_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conteudo_tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox saidas_check;
        private System.Windows.Forms.CheckBox entradas_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown n_estudante_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consult_btn;
        private System.Windows.Forms.DataGridView conteudo_tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dataehora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimento;
    }
}