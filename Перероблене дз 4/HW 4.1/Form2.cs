using System;
using System.Windows.Forms;

namespace HW_4._1
{
    public partial class Form2 : Form
    {
        public EquilateralTriangle _T;
        public Form2(EquilateralTriangle T)
        {
            if (T == null)
            {
                MessageBox.Show("Triangle was not created. Something went wrong!");
                return;
            }
            _T = T;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) => MessageBox.Show(_T.GetPerimeter().ToString());

        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(_T.GetArea().ToString());

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var angleDescription in _T.CalculateAngles())
                MessageBox.Show(angleDescription);
        }
    }
}
