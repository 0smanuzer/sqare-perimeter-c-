using System;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryGetDouble(textBox1, out double x1) && TryGetDouble(textBox2, out double x2) &&
                TryGetDouble(textBox3, out double y1) && TryGetDouble(textBox4, out double y2))
            {
                double smallerSideLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double largerSideLength = smallerSideLength * 2.5;
                double area = smallerSideLength * largerSideLength;
                double perimeter = 2 * (smallerSideLength + largerSideLength);

                textBox5.Text = $"Площадь: {area:F2}, Периметр: {perimeter:F2}";
            }
        }

        private bool TryGetDouble(TextBox textBox, out double value)
        {
            return double.TryParse(textBox.Text, out value);
        }
    }
}
