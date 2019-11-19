using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    //o programa deve calcular o IMC e o peso ideal de um individuo dado os seus dados
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem a certeza que pretende sair","Sair",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pesoIdealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nextform =new peso_ideal();
            nextform.Show();
        }

        private void massaCorporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nextform = new massa_corporal();
            nextform.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
