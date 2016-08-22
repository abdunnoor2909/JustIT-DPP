using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libary
{
    public partial class Form1 : Form
    {
        List<string> books = new List<string>(new string[] { });
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Book name: " + textBox1.Text + " Price £" + textBox2.Text);
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myItems = new List<string> { "aaa", "bbb" };
            listBox1.DataSource = myItems;

            //if ((string)listBox1.SelectedItem == textBox1.Text + textBox2.Text);
            //MessageBox.Show((string)listBox1.SelectedItem);
        }
    }
}
