using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
    }

    protected void calculate_Click(object sender, EventArgs e)
    {
         
        double twenty = 0.2;
        double fourty = 0.4;
        double additionalRate = 0.45;
        int taxFreeAllowance = 11000;
        int grossSalary = Convert.ToInt32(TextBox1.Text);
        //tax at 40
        var tax40 = grossSalary - taxFreeAllowance;
        var tax45 = grossSalary - taxFreeAllowance;
        var totalTaxable = grossSalary - taxFreeAllowance;

        if(int.Parse(grossSalary.ToString()) > 150000)
        {
            

        }
       
        else if(int.Parse(grossSalary.ToString()) <= taxFreeAllowance)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();
            totaltxbleLbl.Text = 0.ToString();
            taxPaid.Text = 0.ToString();
        }
        else if(int.Parse(grossSalary.ToString())>= 43000)
        {
          
            var total = (tax40 - 32000) * fourty;
            var total2 = 32000 * twenty;
            var mainTotal = total + total2;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();
            totaltxbleLbl.Text = totalTaxable.ToString();
            taxPaid.Text = mainTotal.ToString();

        }
        else if (int.Parse(grossSalary.ToString()) > 11000)
        {
            var total = (grossSalary - taxFreeAllowance) * 0.2;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();
            totaltxbleLbl.Text = totalTaxable.ToString();
            taxPaid.Text = total.ToString();
        }


                      

    }

   
    
}