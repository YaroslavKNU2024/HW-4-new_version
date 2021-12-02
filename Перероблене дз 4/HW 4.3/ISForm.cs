using System;
using System.Windows.Forms;

namespace HW_4._3
{
    public partial class ISForm : Form
    {
        public ISForm() => InitializeComponent();

        IsoscelesTriangle IST;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double alpha = Convert.ToDouble(textBox3.Text);

                IST = new IsoscelesTriangle(a, b, alpha);
            }
            catch
            {
                MessageBox.Show("Impossible to create a triangle");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IST == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(IST.Perimeter().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IST == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(IST.Area().ToString());
        }
    }
}
