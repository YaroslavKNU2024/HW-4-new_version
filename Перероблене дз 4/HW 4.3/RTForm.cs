using System;
using System.Windows.Forms;

namespace HW_4._3
{
    public partial class RTForm : Form
    {
        public RTForm()
        {
            InitializeComponent();
        }
        RightTriangle RT;
        private void button1_Click(object sender, EventArgs e)
        {
            if (RT == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(RT.Perimeter().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double alpha = Convert.ToDouble(textBox3.Text);

                RT = new RightTriangle(a, b, alpha);
            }
            catch
            {
                MessageBox.Show("Impossible to create a triangle");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RT == null)
            {
                MessageBox.Show("You haven't created a triangle yet!");
                return;
            }
            MessageBox.Show(RT.Area().ToString());
        }
    }
}
