using System;
using System.Windows.Forms;

namespace HW_4._1
{
    public partial class Form1 : Form
    {

        private Triangle A;
        public EquilateralTriangle T;
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                A = new Triangle(a, b, c);
                if (a == b && b == c)
                {
                    MessageBox.Show("You've created  an equaliteral triangle. Redirecting you to another form.");
                    T = new EquilateralTriangle();
                    T.first = T.second = T.third = A.first;
                    Hide();
                    Form treq = new Form2(T);
                    treq.ShowDialog();
                    Close();
                }

            }
            catch {
                MessageBox.Show("Could not create a triangle");
            }

        }

        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(A == null ? "Create a triangle" : A.GetPerimeter().ToString());

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var angleDescription in A.CalculateAngles())
                MessageBox.Show(angleDescription);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T = new EquilateralTriangle();
            MessageBox.Show(T.GetEdge.ToString());
        }

    }
}
