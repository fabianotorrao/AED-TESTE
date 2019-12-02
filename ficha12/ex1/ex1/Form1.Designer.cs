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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.porLiquidar = new System.Windows.Forms.RadioButton();
            this.liquidadas = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.n_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liquidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_results = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 128);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.consultar);
            this.groupBox1.Controls.Add(this.porLiquidar);
            this.groupBox1.Controls.Add(this.liquidadas);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado das faturas";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(224, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(265, 19);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(248, 88);
            this.consultar.TabIndex = 2;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // porLiquidar
            // 
            this.porLiquidar.AutoSize = true;
            this.porLiquidar.Location = new System.Drawing.Point(17, 94);
            this.porLiquidar.Name = "porLiquidar";
            this.porLiquidar.Size = new System.Drawing.Size(77, 17);
            this.porLiquidar.TabIndex = 1;
            this.porLiquidar.TabStop = true;
            this.porLiquidar.Text = "Por liquidar";
            this.porLiquidar.UseVisualStyleBackColor = true;
            this.porLiquidar.CheckedChanged += new System.EventHandler(this.porLiquidar_CheckedChanged);
            // 
            // liquidadas
            // 
            this.liquidadas.AutoSize = true;
            this.liquidadas.Location = new System.Drawing.Point(17, 35);
            this.liquidadas.Name = "liquidadas";
            this.liquidadas.Size = new System.Drawing.Size(76, 17);
            this.liquidadas.TabIndex = 0;
            this.liquidadas.TabStop = true;
            this.liquidadas.Text = "Liquidadas";
            this.liquidadas.UseVisualStyleBackColor = true;
            this.liquidadas.CheckedChanged += new System.EventHandler(this.liquidadas_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_cliente,
            this.data_fatura,
            this.valor,
            this.liquidado,
            this.DataVencimento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // n_cliente
            // 
            this.n_cliente.HeaderText = "Nº Cliente";
            this.n_cliente.Name = "n_cliente";
            this.n_cliente.ReadOnly = true;
            // 
            // data_fatura
            // 
            this.data_fatura.HeaderText = "Data Fatura";
            this.data_fatura.Name = "data_fatura";
            this.data_fatura.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // liquidado
            // 
            this.liquidado.HeaderText = "Liquidado";
            this.liquidado.Name = "liquidado";
            this.liquidado.ReadOnly = true;
            // 
            // DataVencimento
            // 
            this.DataVencimento.HeaderText = "Data Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            // 
            // n_results
            // 
            this.n_results.AutoSize = true;
            this.n_results.Location = new System.Drawing.Point(367, 437);
            this.n_results.Name = "n_results";
            this.n_results.Size = new System.Drawing.Size(161, 13);
            this.n_results.TabIndex = 2;
            this.n_results.Text = "Nº Faturas obtidas na consulta : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 459);
            this.Controls.Add(this.n_results);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.RadioButton porLiquidar;
        private System.Windows.Forms.RadioButton liquidadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label n_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn liquidado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
    }
}

