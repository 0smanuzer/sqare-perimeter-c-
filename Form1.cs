using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            if (double.TryParse(textBox1.Text, out x1) && double.TryParse(textBox2.Text, out x2) &&
                double.TryParse(textBox3.Text, out y1) && double.TryParse(textBox4.Text, out y2))
            {
                double smallerSideLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                double largerSideLength = smallerSideLength * 2.5;

                double area = smallerSideLength * largerSideLength;
                double perimeter = 2 * (smallerSideLength + largerSideLength);

                textBox5.Text = $"Площадь: {area:F2}, Периметр: {perimeter:F2}";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
