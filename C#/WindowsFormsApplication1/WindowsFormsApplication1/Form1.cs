using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> books = new List<string>(new string[] { });
        
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sally");
            listBox1.Items.Add("Craig");
        }
    }
}
