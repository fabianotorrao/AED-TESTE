namespace ex1
{
    partial class peso_ideal
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
            this.label1 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fem = new System.Windows.Forms.RadioButton();
            this.masc = new System.Windows.Forms.RadioButton();
            this.peso_ideal_btn = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.altura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura em cm :";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(92, 28);
            this.altura.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(64, 20);
            this.altura.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fem);
            this.groupBox1.Controls.Add(this.masc);
            this.groupBox1.Location = new System.Drawing.Point(15, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(19, 43);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(67, 17);
            this.fem.TabIndex = 1;
            this.fem.TabStop = true;
            this.fem.Text = "Feminino";
            this.fem.UseVisualStyleBackColor = true;
            this.fem.CheckedChanged += new System.EventHandler(this.fem_CheckedChanged);
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Location = new System.Drawing.Point(19, 20);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(73, 17);
            this.masc.TabIndex = 0;
            this.masc.TabStop = true;
            this.masc.Text = "Masculino";
            this.masc.UseVisualStyleBackColor = true;
            this.masc.CheckedChanged += new System.EventHandler(this.masc_CheckedChanged);
            // 
            // peso_ideal_btn
            // 
            this.peso_ideal_btn.Enabled = false;
            this.peso_ideal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso_ideal_btn.Location = new System.Drawing.Point(15, 181);
            this.peso_ideal_btn.Name = "peso_ideal_btn";
            this.peso_ideal_btn.Size = new System.Drawing.Size(180, 71);
            this.peso_ideal_btn.TabIndex = 3;
            this.peso_ideal_btn.Text = "Calcular peso ideal";
            this.peso_ideal_btn.UseVisualStyleBackColor = true;
            this.peso_ideal_btn.Click += new System.EventHandler(this.peso_ideal_btn_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(321, 181);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(180, 71);
            this.sair.TabIndex = 4;
            this.sair.Text = "Menu principal";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(301, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(63, 60);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(82, 20);
            this.result.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peso ideal em Kg";
            // 
            // peso_ideal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.peso_ideal_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "peso_ideal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "peso_ideal";
            this.Load += new System.EventHandler(this.peso_ideal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown altura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.Button peso_ideal_btn;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
    }
}