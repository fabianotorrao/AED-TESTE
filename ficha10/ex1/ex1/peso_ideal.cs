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
    public partial class peso_ideal : Form
    {
        public peso_ideal()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Form next = new Form1();
            next.Show();
        }

        private void masc_CheckedChanged(object sender, EventArgs e)
        {
            check_radio(sender, e);
        }

        private void fem_CheckedChanged(object sender, EventArgs e)
        {
            check_radio(sender,e);
        }
        public void check_radio(object sender, EventArgs e)
        {
            if (masc.Checked || fem.Checked)
            {
                peso_ideal_btn.Enabled = true;
            }
        }

        private void peso_ideal_btn_Click(object sender, EventArgs e)
        {
            double pesoideal;
            if (masc.Checked)
            {
                 pesoideal = calcularpeso(4, Convert.ToInt16(altura.Value));
            }
            else
                 pesoideal = calcularpeso(2,Convert.ToInt16(altura.Value));
            result.Text = pesoideal.ToString("##,##");

        }
        public static double calcularpeso(int k, Int32 altura)
        {
            double peso = (altura - 100) - (altura - 150) / k;
            return peso;
        }

        private void peso_ideal_Load(object sender, EventArgs e)
        {
            altura.Value = 100;
        }
    }
}
