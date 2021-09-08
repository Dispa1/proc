using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void A1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B1_TextChanged(object sender, EventArgs e)
        {

        }

        private void N1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reshit_Click(object sender, EventArgs e)
        {

            int a, b, n;
            a = Convert.ToInt32(Box1.Text);
            b = Convert.ToInt32(Box2.Text);
            n = Convert.ToInt32(Box3.Text);
            var h = (b - a) / (n * 1);
            double sum = 0.0;
            for (var i = 0; i <= n - 1; i++)
            {
                var x = a + i * h;
                sum += F(x);
            }
            var result = h * sum;
            label5.Text = Convert.ToString(result);
           

        }

            private static double F(double x)
        {
            return Math.Sqrt(1 + x);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}



