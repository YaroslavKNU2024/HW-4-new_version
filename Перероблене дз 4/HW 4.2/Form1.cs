using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form tr = new triangle();
            tr.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form cl = new circle();
            cl.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form sq = new square();
            sq.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form rec = new rectangle();
            rec.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form rmb = new rhombus();
            rmb.ShowDialog();
            Close();
        }
    }
}
