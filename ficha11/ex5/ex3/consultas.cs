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
    public partial class consultas : Form
    {
        public string file_path = "acessos.txt";
        public consultas()
        {
            InitializeComponent();
        }

        private void consultas_Load(object sender, EventArgs e)
        {
            n_estudante_txt.Controls[0].Visible = false;
            listar_conteudo(null,-1);
        }
        public void listar_conteudo(string mov,int n)
        {
            conteudo_tabela.Rows.Clear();
            var lines = File.ReadAllLines(file_path);
            foreach (var line in lines)
            {
                string[] line_splited = line.Split(';');
                
                
                if (mov==null)
                {
                    if (n==-1)
                    {
                        conteudo_tabela.Rows.Add(line_splited);
                    }
                    else if (n==Convert.ToInt32(line_splited[0]))
                    {
                        conteudo_tabela.Rows.Add(line_splited);
                    }

                }
                if (mov==line_splited[2])
                {
                    if (n==Convert.ToInt32(line_splited[0]))
                    {
                        conteudo_tabela.Rows.Add(line_splited);
                    }
                    else if (n==-1)
                    {
                        conteudo_tabela.Rows.Add(line_splited);
                    }
                }
                
                

            }
        }

        private void consult_btn_Click(object sender, EventArgs e)
        {
            string mov = null;
            int n = -1;
            if (entradas_check.Checked&&saidas_check.Checked)
            {
                mov = null;
            }
            else if (entradas_check.Checked)
            {
                mov = "Entrada";
            }
            else if (saidas_check.Checked)
            {
                mov = "Saida";
            }
            if (n_estudante_txt.Value!=0)
            {
                n = Convert.ToInt32(n_estudante_txt.Value);
            }
            listar_conteudo(mov, n);
        }

        private void consultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            Form nextfrm = new Form1();
            nextfrm.Show();
        }
    }
}
