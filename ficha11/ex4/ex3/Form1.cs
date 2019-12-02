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

namespace ex3
{
    public partial class Form1 : Form
    {
        string file_path = "acessos.txt";
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
            n_estudante_txt.Controls[0].Visible = false;
            listar_listbox();

        }
        public void unlock_regist(object sender,EventArgs e)
        {
            if (n_estudante_txt.Value>0&&(entrada.Checked||saida.Checked))
            
                regist_btn.Enabled = true;
            else
                regist_btn.Enabled = false;
        }

        private void n_estudante_txt_ValueChanged(object sender, EventArgs e)
        {
            unlock_regist(sender, e);
        }

        private void entrada_CheckedChanged(object sender, EventArgs e)
        {
            unlock_regist(sender, e);
        }

        private void saida_CheckedChanged(object sender, EventArgs e)
        {
            unlock_regist(sender, e);
        }

        private void n_estudante_txt_Enter(object sender, EventArgs e)
        {
            unlock_regist(sender, e);
        }

        private void regist_btn_Click(object sender, EventArgs e)
        {

            if (entrada.Checked)
                verificacao("Entrada");
                
            else
                verificacao("Saida");
                
        }
        public void verificacao(string mov)
        {
            var lines = File.ReadAllLines(file_path);
            bool decid = true;
            foreach (var line in lines.Reverse())
            {
                string[] line_splited = line.Split(';');
                if (n_estudante_txt.Value.ToString() == line_splited[0] && mov == line_splited[2])
                {
                    MessageBox.Show("O ultimo movimento deste aluno é uma " + mov, "Aviso", MessageBoxButtons.OK);
                    decid = false;
                    break;
                }
                else
                {
                    decid = true;
                }

            }
            if (decid==true)
            {
                escrever_no_ficheiro(mov);
            }
        }
        public void escrever_no_ficheiro(string mov)
        {
            //escrita no ficheiro
            string txt = n_estudante_txt.Value.ToString() + ";" + DateTime.Now.ToString("dd-MM-yyyy HH:mm") + ";" + mov;
            StreamWriter streamWriter= File.AppendText(file_path);
            streamWriter.WriteLine(txt);
            streamWriter.Close();
            listar_listbox();
            
        }
        public void listar_listbox()
        {
            history.Items.Clear();
            if (!File.Exists(file_path))
            {
                File.Create(file_path).Close();
            }
            else
            {
                var lines = File.ReadAllLines(file_path);
                foreach (var line in lines)
                {
                    string[] line_splited = line.Split(';');
                    history.Items.Add(line_splited[0] + " - " + line_splited[1] + " - " + line_splited[2]);

                }
            }
        }
    }
}
