using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ex1
{
    public partial class Form1 : Form
    {

        string [] linhas = File.ReadAllLines("faturas.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liquidadas.Checked = false;
            porLiquidar.Checked = false;
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            if (liquidadas.Checked||porLiquidar.Checked)
            {
                dataGridView1.Rows.Clear();
                if (liquidadas.Checked)
                {
                    foreach (var item in linhas)
                    {
                        var linha_conteudo = item.Split(';');
                        if (linha_conteudo[3]=="S")
                        {
                            dataGridView1.Rows.Add(linha_conteudo);
                        }
                    }
                }
                else
                {
                    foreach (var item in linhas)
                    {
                        var linha_conteudo = item.Split(';');
                        if (linha_conteudo[3] == "N")
                        {
                            dataGridView1.Rows.Add(linha_conteudo[0], linha_conteudo[1], linha_conteudo[2], linha_conteudo[3],DateTime.Parse(linha_conteudo[1]).AddDays(30).ToString("yyyy/MM/dd"));
                        }
                    }
                }
               
                n_results.Text = "Nº Faturas obtidas na consulta : "+ (dataGridView1.Rows.Count -1);
            }
            else
            {
                MessageBox.Show("Não selecionou nenhuma opção para consulta");
            }
        }

        private void porLiquidar_CheckedChanged(object sender, EventArgs e)
        {
            if (porLiquidar.Checked)
            {
                dataGridView1.Columns.Add("DataVencimento","Data Vencimento");
            }
        }

        private void liquidadas_CheckedChanged(object sender, EventArgs e)
        {
            if (liquidadas.Checked)
            {
                dataGridView1.Columns.Remove("DataVencimento");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que quer sair ?","Sair?",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
