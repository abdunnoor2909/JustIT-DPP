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
        Label5.Visible = false;
        Label6.Visible = false;
    }

    protected void calculate_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;


        //DECLARING VARIABLES.
        double tax20 = 0.2;
        double tax40 = 0.4;
        double tax45 = 0.45;
        int taxFreeAllowance = 11000;
        int grossSalary = Convert.ToInt32(TextBox1.Text);

       
        //To work out tax for salary earned is less than and equal to £11,000
         if (int.Parse(grossSalary.ToString()) <= 11000)
        {
            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();//£11,000
            totaltxbleLbl.Text = 0.ToString();
            taxPaidlbl.Text = 0.ToString();
            netSalarylbl.Text = grossSalary.ToString();
        }

         else if(int.Parse(grossSalary.ToString()) > 150000)
        {
            var workOut1 = (grossSalary - 150000) * 0.45;
            var workOut2 = 118000 * 0.4;
            var workOut3 = 32000 * 0.2;
            var total = workOut1 + workOut2 + workOut3;
            var netSalary = grossSalary - total;            

            grossSalarylbl.Text = grossSalary.ToString();
            taxPaidlbl.Text = total.ToString();
            totaltxbleLbl.Text = grossSalary.ToString();
            netSalarylbl.Text = netSalary.ToString();

           


        }
        //To work out tax for salary earned is more than and equal to £43,000 (40% and 20% taxed)
        else if (int.Parse(grossSalary.ToString()) >= 43000)
        {
            var taxed40 = grossSalary - taxFreeAllowance;
            var workOut = (taxed40 - 32000) * tax40;
            var workOut2 = 32000 * tax20;
            var Total = workOut + workOut2;
            var netSalary = grossSalary - Total;
            var totalTaxable = grossSalary - taxFreeAllowance;

    
            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();
            totaltxbleLbl.Text = totalTaxable.ToString();
            taxPaidlbl.Text = Total.ToString();
            netSalarylbl.Text = netSalary.ToString();

           
        }
        //To work out tax for salary earned is more than £11,000 (20% taxed)
        else if (int.Parse(grossSalary.ToString()) > 11000)
        {
            var total = (grossSalary - taxFreeAllowance) * 0.2;

            var totalTaxable = grossSalary - taxFreeAllowance;
            var netSalary = grossSalary - total;

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxFreeAllowance.ToString();
            totaltxbleLbl.Text = totalTaxable.ToString();
            taxPaidlbl.Text = total.ToString();
            netSalarylbl.Text = netSalary.ToString();

        }
         //TAX FREE ALLOWANCE STARTS DECREASING ABOVE £100,000 
        if (int.Parse(grossSalary.ToString()) > 100000 && (int.Parse(grossSalary.ToString()) <= 150000))
        {
            //Calculating the tax free allowance and the total tax to be paid.
            var workOut1 = (grossSalary - 100000) / 2;
            var workOut2 = taxFreeAllowance - workOut1;
            var taxableSalary = grossSalary - workOut2;

            //Calculating tax for 40% and 20%. 
            var totaltaxpaid = (taxableSalary - 32000) * 0.4;
            var total2 = totaltaxpaid + 6400;

            //workout net salary.
            var netSalary = taxableSalary - total2;

            taxFreeLbl.Text = workOut2.ToString();
           
         
            if (workOut2 <= 0)
            {
                var salary = (grossSalary - 32000) * 0.4;
                var total = salary + 6400;
                var netSalary2 = grossSalary - total;
                taxableSalary = grossSalary;
                totaltxbleLbl.Text = taxableSalary.ToString(); 
                taxFreeLbl.Text = 0.ToString();
                netSalarylbl.Text = netSalary2.ToString();
                taxPaidlbl.Text = total.ToString();
                
            }

            //Display on screen
            totaltxbleLbl.Text = taxableSalary.ToString();
            grossSalarylbl.Text = grossSalary.ToString();
            //taxPaidlbl.Text = total2.ToString();
            //netSalarylbl.Text = netSalary.ToString();

        }







        //if (int.Parse(grossSalary.ToString()) <= 8060)
        //{
        //    grossSalarylbl.Text = grossSalary.ToString();
        //    taxFreeLbl.Text = 0.ToString();
        //    totaltxbleLbl.Text = 0.ToString();
        //    taxPaidlbl.Text = 0.ToString();
        //    netSalarylbl.Text = grossSalary.ToString();
        //    nIlbl.Text = 0.ToString();

        //}

        //else if (int.Parse(grossSalary.ToString()) >= 43004)
        //{
        //    var workout1 = (grossSalary- 43004) * 0.2;// = 34994 (12% will be applied on this)
        //    var workout2 = 8060 * 12;
        //    var total = workout1 + workout2;

        //    grossSalarylbl.Text = grossSalary.ToString();
            
          

        //}



    }
    
}