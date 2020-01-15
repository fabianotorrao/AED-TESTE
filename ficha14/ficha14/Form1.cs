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
using System.Threading;

namespace ficha14
{
    
    public partial class Form1 : Form
    {
        string[,] perguntas= new string[10,6];
        List <int> perguntas_usadas=new List<int>();
        int corr = 0, inc = 0,i=0,i1=0,n;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            
            do
            {
                Random rnd = new Random();
                n = rnd.Next(0,10);
                if (perguntas_usadas.Count==10)
                {
                    MessageBox.Show("Fim do jogo", "Fim", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
            } while (perguntas_usadas.Contains(n));
            perguntas_usadas.Add(n);
            textBox1.Text = perguntas[n, 0];
            radioButton1.Text = perguntas[n, 1];
            radioButton2.Text = perguntas[n, 2];
            radioButton3.Text = perguntas[n, 3];
            radioButton4.Text = perguntas[n, 4];
            panel4.Enabled = true;


        }

        private void panel4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Text==perguntas[n,5])
                {
                    
                    show_result("C");
                }
                else
                {
                    
                    show_result("I");
                }
            }
            else if (radioButton2.Checked)
              {
                if (radioButton2.Text == perguntas[n, 5])
                {

                    show_result("C");
                }
                else
                {

                    show_result("I");
                }
              }
            else if (radioButton3.Checked)
            {
                if (radioButton3.Text == perguntas[n, 5])
                {

                    show_result("C");
                }
                else
                {

                    show_result("I");
                }
            }
            else
            {
                if (radioButton4.Text == perguntas[n, 5])
                {

                    show_result("C");
                }
                else
                {

                    show_result("I");
                }
            }

        }
        public void show_result(string corr1)
        {
            
            if (corr1=="C")
            {
                corr++;
                result.Text = "Acertou";
            }
            else
            {
                inc++;
                result.Text = "Errou";
            }
            result.Visible = true;
            Thread.Sleep(4000);
            //result.Visible = false;
            n_certas.Text = corr.ToString();
            n_erradas.Text = inc.ToString();
        }

        private void europa_tema_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (europa_tema.Checked || america_tema.Checked || asia_tema.Checked)
            {
                europa_tema.Enabled = false;
                america_tema.Enabled = false;
                asia_tema.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = true;
                
                i = 0;
                if (europa_tema.Checked)
                {
                    carregar_ficheiro("europa.txt");
                }
                else if (asia_tema.Checked)
                {
                    carregar_ficheiro("asia.txt");
                }
                else
                {
                    carregar_ficheiro("america.txt");
                }
            }
        }
        public  void carregar_ficheiro(string caminho)
        {
            foreach (var linha in File.ReadLines(caminho))
            {
                var linha_splited = linha.Split(';');
                i1 = 0;
                foreach (var item in linha_splited)
                {

                    perguntas[i, i1] = item;
                    i1++;
                }
                i++;
            }
        }
    }
}
