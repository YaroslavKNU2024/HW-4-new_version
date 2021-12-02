using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class rhombus : Form
    {
        public rhombus() => InitializeComponent();
        Rhombus rmb;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(textBox1.Text);
                double SmallDiagonal = Convert.ToDouble(textBox2.Text);
                double BigDiagonal = Convert.ToDouble(textBox3.Text);

                rmb = new Rhombus(side, SmallDiagonal, BigDiagonal);
            }
            catch
            { MessageBox.Show("Can't create a rhombus"); }

        }

        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(rmb == null ? "Can't create a rhombus": rmb.Perimeter().ToString());

        private void button3_Click(object sender, EventArgs e)
        {
            if (rmb != null)
                MessageBox.Show(rmb.Area().ToString());
            else
                MessageBox.Show("Can't create a rhombus");
        }
    }
}
