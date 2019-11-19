namespace ex1
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
            this.guardar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.ler = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(12, 56);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(97, 48);
            this.guardar.TabIndex = 0;
            this.guardar.Text = "Guardar Ficheiro";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(12, 126);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(97, 48);
            this.limpar.TabIndex = 1;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // ler
            // 
            this.ler.Location = new System.Drawing.Point(12, 196);
            this.ler.Name = "ler";
            this.ler.Size = new System.Drawing.Size(97, 48);
            this.ler.TabIndex = 2;
            this.ler.Text = "Ler Ficheiro";
            this.ler.UseVisualStyleBackColor = true;
            this.ler.Click += new System.EventHandler(this.ler_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(167, 56);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text.Size = new System.Drawing.Size(337, 188);
            this.text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 300);
            this.Controls.Add(this.text);
            this.Controls.Add(this.ler);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.guardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button ler;
        private System.Windows.Forms.TextBox text;
    }
}

