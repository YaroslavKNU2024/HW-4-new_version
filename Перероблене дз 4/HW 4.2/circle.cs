using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class circle : Form
    {
        public circle() => InitializeComponent();

        Circle c;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double rad = Convert.ToDouble(textBox1.Text);
                if (rad <= 0) throw new Exception();
                c = new Circle(rad);
            } catch
            {
                MessageBox.Show("Impossible to create a circle!");
            }
        }
        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(c.Perimeter().ToString());

        private void button3_Click(object sender, EventArgs e) => MessageBox.Show(c.Area().ToString());
    }
}
