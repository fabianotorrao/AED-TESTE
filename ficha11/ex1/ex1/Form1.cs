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
        string path = "texto.txt";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            text.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                
            }

        }

        private void ler_Click(object sender, EventArgs e)
        {
            var sr = File.ReadAllText(path);
            text.Text = sr;
            
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, text.Text);
        }
    }
}
