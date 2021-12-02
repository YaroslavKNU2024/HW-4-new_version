using System;
using System.Windows.Forms;

namespace HW_4._2
{
    public partial class rectangle : Form
    {
        public rectangle()
        {
            InitializeComponent();
        }
        Rectangle rec;
        private void button1_Click(object sender, EventArgs e)
        {
            double first, second;
            try
            {
                first = Convert.ToDouble(textBox1.Text);
                second = Convert.ToDouble(textBox2.Text);
                if (first <= 0 || second <= 0) throw new Exception();
                rec = new Rectangle(first, second);
            } catch
            {
                MessageBox.Show("Impossible to create");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) => MessageBox.Show(rec.Perimeter().ToString());

        private void button3_Click(object sender, EventArgs e) => MessageBox.Show(rec.Area().ToString());
        
    }
}
