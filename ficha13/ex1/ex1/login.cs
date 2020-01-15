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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            vars.mainForm.Show();
        }

        private void log_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("users.txt");
            foreach (var linha in linhas)
            {
                string[] linhaContent = linha.Split(';');
                if (linhaContent[0] == user.Text)
                {
                    if (pw.Text==linhaContent[1])
                    {
                        vars.user_name = user.Text;
                        this.Close();
                        vars.mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password incorreta", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void registar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (registar.Text == "Registar")
            {
                log.Visible = false;
                //registar.Visible = false;
                label3.Visible = true;
                pw_check.Visible = true;
                registar.Text = "Criar Conta";
                registar.Enabled = false;
            }
            else
            {
                string[] linhas = File.ReadAllLines("users.txt");
                foreach (var linha in linhas)
                {
                    string[] linhaContent = linha.Split(';');
                    if (linhaContent[0]==user.Text)
                    {
                        flag = true;
                    }
                }
                if (flag==false)
                {
                    string[] conteudo = { user.Text + ";" + pw.Text };
                    File.AppendAllLines("users.txt",conteudo);
                    MessageBox.Show("Conta criada com sucesso", "Confirmação", MessageBoxButtons.OK);
                    vars.user_name = user.Text;
                    this.Close();
                    vars.mainForm.Show();
                    
                    

                }
                else
                {
                    MessageBox.Show("Username em uso", "Aviso", MessageBoxButtons.OK);
                }
            }



        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pw_check_TextChanged(object sender, EventArgs e)
        {
            verificar_dados();
        }
        public void verificar_dados()
        {
            if (((pw_check.Text == pw.Text) && pw.Text.Length > 3)&&(user.Text.Length>3))
            {
                registar.Enabled = true;
            }
            else
            {
                registar.Enabled = false;
            }
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
