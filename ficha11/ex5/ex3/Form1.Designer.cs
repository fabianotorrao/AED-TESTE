namespace ex3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saida = new System.Windows.Forms.RadioButton();
            this.entrada = new System.Windows.Forms.RadioButton();
            this.regist_btn = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.n_estudante_txt = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_estudante_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movimentosToolStripMenuItem
            // 
            this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.movimentosToolStripMenuItem.Text = "Movimentos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Estudante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Histórico de Movimentos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saida);
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Movimento";
            // 
            // saida
            // 
            this.saida.AutoSize = true;
            this.saida.Location = new System.Drawing.Point(77, 75);
            this.saida.Name = "saida";
            this.saida.Size = new System.Drawing.Size(54, 17);
            this.saida.TabIndex = 1;
            this.saida.TabStop = true;
            this.saida.Text = "Saída";
            this.saida.UseVisualStyleBackColor = true;
            this.saida.CheckedChanged += new System.EventHandler(this.saida_CheckedChanged);
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Location = new System.Drawing.Point(77, 37);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(62, 17);
            this.entrada.TabIndex = 0;
            this.entrada.TabStop = true;
            this.entrada.Text = "Entrada";
            this.entrada.UseVisualStyleBackColor = true;
            this.entrada.CheckedChanged += new System.EventHandler(this.entrada_CheckedChanged);
            // 
            // regist_btn
            // 
            this.regist_btn.Enabled = false;
            this.regist_btn.Location = new System.Drawing.Point(253, 120);
            this.regist_btn.Name = "regist_btn";
            this.regist_btn.Size = new System.Drawing.Size(123, 128);
            this.regist_btn.TabIndex = 4;
            this.regist_btn.Text = "Registar";
            this.regist_btn.UseVisualStyleBackColor = true;
            this.regist_btn.Click += new System.EventHandler(this.regist_btn_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.Control;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(483, 120);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(215, 130);
            this.history.TabIndex = 5;
            // 
            // n_estudante_txt
            // 
            this.n_estudante_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_estudante_txt.Location = new System.Drawing.Point(130, 73);
            this.n_estudante_txt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.n_estudante_txt.Name = "n_estudante_txt";
            this.n_estudante_txt.Size = new System.Drawing.Size(120, 20);
            this.n_estudante_txt.TabIndex = 6;
            this.n_estudante_txt.ValueChanged += new System.EventHandler(this.n_estudante_txt_Enter);
            this.n_estudante_txt.Enter += new System.EventHandler(this.n_estudante_txt_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 308);
            this.Controls.Add(this.n_estudante_txt);
            this.Controls.Add(this.history);
            this.Controls.Add(this.regist_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlo de presenças";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_estudante_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton saida;
        private System.Windows.Forms.RadioButton entrada;
        private System.Windows.Forms.Button regist_btn;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.NumericUpDown n_estudante_txt;
    }
}

