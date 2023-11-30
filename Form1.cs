using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            double e0 = (Math.Pow(x, 1.0 / 3.0) + Math.Pow(x, (Math.Sqrt((y+2)))));
            double e1 = Math.Sqrt(10* e0);
            double e2 = Math.Pow(Math.Asin(Math.Atan(z)), 2) - Math.Abs (x-y);
            double res = e1 * e2;
            listBox1.Items.Add(res);
        }
    }
}
