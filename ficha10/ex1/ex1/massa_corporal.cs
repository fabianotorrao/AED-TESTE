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
    public partial class massa_corporal : Form
    {
        public massa_corporal()
        {
            InitializeComponent();
        }

        private void peso_txt_TextChanged(object sender, EventArgs e)
        {
            buttons(sender, e);
        }
        public void buttons(object sender,EventArgs e)
        {
            if (peso_txt.Text.Length > 0 && altura_txt.Text.Length > 0)
            {
                calc_btn.Enabled = true;
            }
            else
                calc_btn.Enabled = false;
        }

        private void altura_txt_TextChanged(object sender, EventArgs e)
        {
            buttons(sender, e);
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double imc = Convert.ToDouble(peso_txt.Text.Replace('.', ',')) / Math.Pow(Convert.ToDouble(altura_txt.Text.Replace('.', ',')),2);
            imc_valor.Text = imc.ToString("##.##");
            
        }

        private void sair_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form nf =new Form1();
            nf.Show();
        }
    }
}
