using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listofbooks
{
    public partial class Form1 : Form

    {
        List<string> books = new List<string>(new string[] { });
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Name: " + textBox1.Text + " Author: " + textBox2.Text + " ISBN: " + textBox3.Text + " Price: £ " + textBox4.Text);
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }

}