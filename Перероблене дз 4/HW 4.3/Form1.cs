using System;
using System.Windows.Forms;

namespace HW_4._3
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
            RTForm R = new RTForm();
            R.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Other O = new Other();
            O.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            ISForm I = new ISForm();
            I.ShowDialog();
            Close();
        }
    }
}
