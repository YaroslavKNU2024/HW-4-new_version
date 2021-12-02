using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class square : Form
    {
        public square() => InitializeComponent();

        Square s;
        private void button1_Click(object sender, EventArgs e) => MessageBox.Show(s.Perimeter().ToString());

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(textBox1.Text);
                if (side <= 0) 
                    throw new ArgumentException();
                s = new Square(side);
            }
            catch
            {
                MessageBox.Show("Can't create a rectangle!");
            }
        }

        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(s == null ? "Create a square!": s.Area().ToString());
    }
}
