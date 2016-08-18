using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;
        

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.ForeColor = Color.Red;
                q2Correct = false;
                label2.Text = "\u00fb";//cross
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.ForeColor = Color.Green;
                q1Correct = true;
                label2.Text = "\u00fc";//correct
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label2.ForeColor = Color.Red;
                q1Correct = false;
                label2.Text = "\u00fb";//wrong
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label3.ForeColor = Color.Red;
                q2Correct = false;
                label3.Text = "\u00fb";//wrong
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label3.ForeColor = Color.Red;
                q2Correct = false;
                label3.Text = "\u00fb";//wrong
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label3.ForeColor = Color.Green;
                q2Correct = true;
                label3.Text = "\u00fc";//correct
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label4.ForeColor = Color.Red;
                q3Correct = false;
                label4.Text = "\u00fb";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label4.ForeColor = Color.Red;
                q3Correct = false;
                label4.Text = "\u00fb";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                label4.ForeColor = Color.Green;
                q3Correct = true;                 
                label4.Text = "\u00fc";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          

            if(q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("Well done, everthing is correct");
            }

            else if(timeLeft > 0)
            {
                timeLeft--;
                label8.Text = timeLeft + "seconds";
            }
            
            else
            {
                timer1.Stop();
                MessageBox.Show("Sorry you run out of time");
           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }
    }
}
