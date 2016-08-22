using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            var conversion = 100;

            if (radioButton1.Checked)
            {
                textBox2.Text = (a * 100).ToString();
                label1.Text = "m";
                label2.Text = "cm";
            }
        }
    }
}
