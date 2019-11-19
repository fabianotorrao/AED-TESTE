using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ex2
{
    public partial class Form1 : Form
    {
        int n = 0,tent=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?","Sair",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            n = rnd.Next(0, 101);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            if (tent < 10)
            {
                if (n > numericUpDown1.Value)

                    mensagem("Maior");

                else if (n < numericUpDown1.Value)
                    mensagem("Menor");
                else
                {
                    acertou.Visible = true;
                    Thread.Sleep(1500);
                    fimdojogo();
                }
            }
            else
                fimdojogo();
        }
        public void fimdojogo()
        {
            if (MessageBox.Show("Deseja jogar novamente?", "Novo jogo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Refresh();
                Refresh();
                this.Hide();
                Form1 fr = new Form1();
                fr.Show();
            }
            else
                Environment.Exit(0);
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fimdojogo();
        }

        public void mensagem(string msg)
        {
            MessageBox.Show("O numero é " + msg, msg, MessageBoxButtons.OK);
            tent++;
            tentativas.Text = "Usou " + tent + " tentativas";
        }
    }
}
