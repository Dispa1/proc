using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int N = int.Parse(textBox1.Text);
            textBox2.Text ="";
            int[,] matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                matrix[i, i] = 0;
                for (int j = i + 1; j < N; j++)
                {
                    matrix[i, j] = ran.Next(0, 2);
                    matrix[j, i] = matrix[i, j];
                }
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {       
                    textBox2.Text += matrix[i, j].ToString();      
                }
                textBox2.Text += Environment.NewLine;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
