namespace ex1
{
    partial class massa_corporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(massa_corporal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.altura_txt = new System.Windows.Forms.TextBox();
            this.peso_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imc_valor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calc_btn = new System.Windows.Forms.Button();
            this.sair_btn = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.altura_txt);
            this.groupBox1.Controls.Add(this.peso_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // altura_txt
            // 
            this.altura_txt.Location = new System.Drawing.Point(87, 66);
            this.altura_txt.Name = "altura_txt";
            this.altura_txt.Size = new System.Drawing.Size(49, 20);
            this.altura_txt.TabIndex = 3;
            this.altura_txt.TextChanged += new System.EventHandler(this.altura_txt_TextChanged);
            // 
            // peso_txt
            // 
            this.peso_txt.Location = new System.Drawing.Point(49, 16);
            this.peso_txt.Name = "peso_txt";
            this.peso_txt.Size = new System.Drawing.Size(60, 20);
            this.peso_txt.TabIndex = 2;
            this.peso_txt.TextChanged += new System.EventHandler(this.peso_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura em m :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imc_valor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // imc_valor
            // 
            this.imc_valor.AutoSize = true;
            this.imc_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imc_valor.Location = new System.Drawing.Point(67, 56);
            this.imc_valor.Name = "imc_valor";
            this.imc_valor.Size = new System.Drawing.Size(0, 24);
            this.imc_valor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Índice de Massa Corporal";
            // 
            // calc_btn
            // 
            this.calc_btn.Enabled = false;
            this.calc_btn.Location = new System.Drawing.Point(239, 23);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(96, 52);
            this.calc_btn.TabIndex = 2;
            this.calc_btn.Text = "Calcular IMC";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // sair_btn
            // 
            this.sair_btn.Location = new System.Drawing.Point(239, 202);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.Size = new System.Drawing.Size(96, 52);
            this.sair_btn.TabIndex = 3;
            this.sair_btn.Text = "Sair";
            this.sair_btn.UseVisualStyleBackColor = true;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(379, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(167, 263);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 4;
            this.img.TabStop = false;
            // 
            // massa_corporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 277);
            this.Controls.Add(this.img);
            this.Controls.Add(this.sair_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "massa_corporal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "massa_corporal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox altura_txt;
        private System.Windows.Forms.TextBox peso_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label imc_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button sair_btn;
        private System.Windows.Forms.PictureBox img;
    }
}