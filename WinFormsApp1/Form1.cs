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
            string IntToString(int i)
            {
                return i.ToString();
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

                int a, b, n, h;
                a = Convert.ToInt32(Box1.Text);
                b = Convert.ToInt32(Box2.Text);
                n = Convert.ToInt32(Box3.Text);
                h = (b - a) / n;
                var sum = 0;
                for (var i = 0; 1 <= n - 1; i++)
                {
                    var x = a + i * h;
                    sum += f(x);
                }
                var result = h * sum;
                return;
            }

        private int f(int x)
        {
            throw new NotImplementedException();
        }
    }
    
}

