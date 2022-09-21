using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnosbrojaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Izracun_Click(object sender, EventArgs e)
        {
            int brojA, brojB, zbroj;

            brojA = Convert.ToInt32(txtUnosbrojaA.Text);
            brojB= Convert.ToInt32(txtUnosbrojaB.Text);
            zbroj = brojA + brojB;

            txtIspis.Text = "" + zbroj;

        }

        private void txtIspis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
