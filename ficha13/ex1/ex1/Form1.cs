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
        public Form1()
        {
            InitializeComponent();
        }

        private void osMeusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Login")
            {
                vars.mainForm = this;
                this.Hide();
                Form next = new login();
                next.Show();

                menuStrip1.Enabled = true;
                //desbloquear botoes
            }
            else
            {
                label1.Text = "Utilizador";
                vars.user_name = "";
                //bloquear botoes

                menuStrip1.Enabled = false;

                button1.Text = "Login";
            }

        }
        
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (vars.user_name != "")
            {
                label1.Text ="Utilizador: " + vars.user_name;
                button1.Text = "Logout";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minhasImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionar_img.Visible = true;
            guardar_img.Visible = true;
            remover_img.Visible = true;
            pictureBox1.Visible = true;
            imageList1.Images.Clear();
            string[] linhas = File.ReadAllLines("fotos.txt");
            foreach (var item in linhas)
            {
                var linha = item.Split(';');
                if (linha[0]==vars.user_name)
                {
                    imageList1.Images.Add(("Foto" + imageList1.Images.Count),Image.FromFile(linha[1]));
                }
            }
            listBox1.Items.Clear();
            foreach (var item in imageList1.Images.Keys)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[listBox1.SelectedIndex];
        }

        private void meusVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
