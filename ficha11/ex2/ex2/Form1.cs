using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace ex2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasks.SelectedIndex != -1)
            {
                remove.Enabled = true;
                task.Text = tasks.SelectedItem.ToString();
            }
            else
            {
                remove.Enabled = false;
                task.Text = "";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string txt = Interaction.InputBox("Input your task", "Task");
            if (txt.Length > 0)
            {
                tasks.Items.Add(txt);
                pending_tasks.Text = tasks.Items.Count.ToString();
            }
            else
                MessageBox.Show("Invalid task", "Alert", MessageBoxButtons.OK);
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tasks.Items.Clear();
            pending_tasks.Text = tasks.Items.Count.ToString();
            task.Text = "";
        }

        private void order_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (var item in tasks.Items)
            {
                items.Add(item.ToString());
            }
            items.Sort();
            tasks.Items.Clear();
            foreach (var item in items)
            {
                tasks.Items.Add(item);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                path_file.Filter="Text Files (*.txt*)|*.txt*";
                path_file.DefaultExt = ".txt";
                path_file.ShowDialog();
                string file_path = path_file.FileName.ToString();
                var sr = File.ReadAllLines(file_path);
                tasks.Items.Clear();
                foreach (var item in sr)
                {
                    tasks.Items.Add(item);
                }
                pending_tasks.Text = tasks.Items.Count.ToString();
            }
            catch (Exception)
            {

             
            }
              
        }

        private void download_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text Files (*.txt*)|*.txt*";
                saveFileDialog1.DefaultExt = ".txt";
                saveFileDialog1.ShowDialog();
                File.Create(saveFileDialog1.FileName).Close();
                List<string> items = new List<string>();
                for (int i = 0; i < tasks.Items.Count ; i++)
                {
                    items.Add(tasks.Items[i].ToString());
                }
                File.WriteAllLines(saveFileDialog1.FileName, items);
            }
            catch (Exception)
            {

                
            }
            
        }

        private void tasks_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void tasks_ClientSizeChanged(object sender, EventArgs e)
        {
        }

        private void remove_Click(object sender, EventArgs e)
        {
            tasks.Items.Remove(tasks.SelectedItem);

            pending_tasks.Text = tasks.Items.Count.ToString();
        }
    }
}
