using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class triangle : Form
    {
        public triangle() => InitializeComponent();

        private Triangle T;
        private bool checker(double first_side, double second_side, double third_side)
        {
            if (first_side <= 0 || second_side <= 0 || third_side <= 0 ||
                first_side + second_side <= third_side ||
                second_side + third_side <= first_side ||
                first_side + third_side <= second_side)
            {
                MessageBox.Show("Impossible to create a triangle!");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e) => MessageBox.Show(T == null ? @"Create a triangle" : T.Perimeter().ToString());
        
        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(T == null ? @"Create a triangle" : T.Area().ToString());
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                T = null;
                var first = Convert.ToDouble(a.Text);
                var second = Convert.ToDouble(b.Text);
                var third = Convert.ToDouble(c.Text);
                if (checker(first, second, third))
                    T = new Triangle(first, second, third);
            } catch
            {
                MessageBox.Show("Impossible to create!");
            }
        }

    }
}
