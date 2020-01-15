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

namespace ficha15
{
    public partial class Form1 : Form
    {
        public void listar()
        {
            dataGridView1.Rows.Clear();
            foreach (var linha in File.ReadAllLines("matricula.txt"))
            {
                
                string[] linha_splited = linha.Split(';');
                dataGridView1.Rows.Add(linha_splited[0], linha_splited[1]);
                }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("matricula.txt"))
            {
                File.Create("matricula.txt").Close();
            }
            else
            {
                listar();
            }
            dataGridView1.MultiSelect = false;
        }

        private void matricula_inserir_TextChanged(object sender, EventArgs e)
        {
            if (matricula_inserir.Text.Length == 8)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (var linha in File.ReadAllLines("matricula.txt"))
            {
                string[] linha_splited = linha.Split(';');
                if (matricula_inserir.Text==linha_splited[1])
                {
                    flag = true;
                    break;
                }
            }
            if (flag==false)
            {
                //dataGridView1.Rows.Add(DateTime.Now.ToString(), matricula_inserir.Text);
                StreamWriter sw = File.AppendText("matricula.txt");
                sw.WriteLine( DateTime.Now.ToString() + ";" + matricula_inserir.Text);
                sw.Close();
                listar();
            }
            else
            {
                MessageBox.Show("Matricula repetida","Aviso",MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count==1)
            {
                matricula_saída.Text = dataGridView1.Rows [dataGridView1.SelectedCells[0].RowIndex].Cells["matricula"].FormattedValue.ToString();
            }
            
        }

        private void matricula_inserir_Enter(object sender, EventArgs e)
        {
            matricula_saída.Text = "";
            maskedTextBox3.Text = "";
        }

        private void matricula_saída_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void matricula_saída_TextChanged(object sender, EventArgs e)
        {
            if (matricula_saída.Text.Length==8)
            {
                
                maskedTextBox3.Text = DateTime.Now.ToString() ;

                DateTime hora_entrada=Convert.ToDateTime(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["data_hora"].FormattedValue.ToString());
                var tempo = DateTime.Now.Subtract(hora_entrada).TotalMinutes;
                textBox1.Text = tempo.ToString("##");
                double total = 0;
                if (tempo<=15)
                {
                    total = 1;
                    
                }
                else if (tempo<=30)
                {
                    total=1.5;
                }
                else if (tempo<=45)
                {
                    total = 2.5;
                }
                else
                {
                    total = 2.5 + (tempo - 45) * 0.10;
                }
                maskedTextBox1.Text = total.ToString("##.##");
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                maskedTextBox3.Text = "";
                textBox1.Text = "";
                maskedTextBox1.Text = "";


            }
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] novo_array = new string[dataGridView1.Rows.Count - 1];
            int i = 0;
            foreach (var linha in File.ReadAllLines("matricula.txt"))
            {
                var linhaSplited = linha.Split(';');
                if (linhaSplited[1] != matricula_saída.Text)
                {
                    novo_array[i] = linha;
                    i++;
                }
            }
            File.WriteAllLines("matricula.txt", novo_array);
            listar();
            MessageBox.Show("Pagamento completo", "Confirmacao", MessageBoxButtons.OK);
        }
    }
}
