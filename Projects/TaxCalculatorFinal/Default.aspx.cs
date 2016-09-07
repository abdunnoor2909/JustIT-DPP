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
       
    }

    double basicTax = 0.2;
    double higherTax = 0.4;
    double additionalTax = 0.45;
    int taxfreeAllowance = 11000;
    int addRateThrs = 150000;
    int highRatethrs = 43000;
    int basicRatethrs = 32000;
    double taxPaid = 0;
    double taxPaid45 = 0;
    double taxPaid40 = 0;
    double taxPaid20 = 0;
    double taxPaidBelow11 = 0;
    double totalTaxAtAdd = 0;
    double totalTaxAt40 = 0;
    double totalTax = 0;
    double taxableSalary = 0;
    double netSalary = 0;
    double niPaidAt2 = 0;
    double niPaidAt12 = 0;
    double highNi = 0.02;
    double basicNi = 0.12;
    double totalNi = 0;
    double totalDeduction = 0;


    private double niHighRate()
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);

        niPaidAt12 = (43004 - 8060) * basicNi;
        niPaidAt2 = (grossSalary - 43004) * highNi;
        totalNi = niPaidAt2 + niPaidAt12;

        return totalNi;
    }
   
    private double niBasicRate()
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);

        niPaidAt12 = (grossSalary - 8060) * basicNi;
        totalNi = niPaidAt12;
        return niPaidAt12;

    }
   

    private double taxAt45()
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);
        

            taxPaid45 = (grossSalary - 150000) * additionalTax;
            taxPaid40 = 118000 * higherTax;
            taxPaid20 = 32000 * basicTax;
            totalTaxAtAdd = taxPaid45 + taxPaid40 + taxPaid20;

        taxfreeAllowance = 0;

        taxableSalary = grossSalary - taxfreeAllowance;
        totalTax = totalTaxAtAdd;

        //netSalary = grossSalary - totalTax;
        
        return taxableSalary;
    }


    private double decreasedTaxAlwnce()//Gross salary above 100,000
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);

            //Now this gives you how much tax free allowance your entitled to.
            int workOutAllowance = (grossSalary - 100000) / 2;
            int newFreeAllowance = taxfreeAllowance - workOutAllowance;
            taxfreeAllowance = newFreeAllowance;
            taxableSalary = grossSalary - taxfreeAllowance;
            //Working out tax
            taxPaid40 = (taxableSalary - 32000) * higherTax;
            taxPaid20 = 6400;
            totalTax = taxPaid40 + taxPaid20;

        taxableSalary = grossSalary - taxfreeAllowance;//taxable income changes because tax free allowance changes.
        //netSalary = grossSalary - totalTax;
                
        if(newFreeAllowance < 0)
        {
            taxableSalary = grossSalary;
            taxfreeAllowance = 0;
            taxPaid40 = (taxableSalary - 32000) * higherTax;
            taxPaid20 = 6400;
            totalTax = taxPaid40 + taxPaid20;
           // netSalary = grossSalary - totalTax;
            return taxableSalary;
        }
                    

        return taxableSalary;
    }


    private double taxAt40()
    {
        
        int grossSalary = Convert.ToInt32(TextBox1.Text);
        
        //works out tax paid at 40%
        taxPaid40 = (grossSalary - 43000) * higherTax;
        taxPaid20 = 32000 * basicTax;
        totalTaxAt40 = taxPaid40 + taxPaid20;
        totalTax = totalTaxAt40;

        taxableSalary = grossSalary - taxfreeAllowance;
       // netSalary = grossSalary - totalTax;
      
        return totalTax;
    }

    private double taxAt20()
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);

        taxPaid20 = (grossSalary - taxfreeAllowance) * basicTax;     
        totalTax = taxPaid20;

        taxableSalary = grossSalary - taxfreeAllowance;
        //netSalary = grossSalary - totalTax;
        return taxPaid20;
    }

    private double taxBelow11()
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);
        taxPaidBelow11 = 0;
        totalTax = taxPaidBelow11;
        taxableSalary = grossSalary;
       // netSalary = grossSalary - totalTax;

        return taxPaidBelow11;
    }

    protected void calculate_Click(object sender, EventArgs e)
        
    {
        int grossSalary = Convert.ToInt32(TextBox1.Text);

        if(grossSalary > 150000)
        {
            taxAt45();
            niHighRate();
            totalDeduction = totalTax + totalNi;
            netSalary = grossSalary - totalDeduction;

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = 0.ToString();
            totaltxbleLbl.Text = taxableSalary.ToString();
            taxPaidlbl.Text = totalTax.ToString();
            nIlbl.Text = totalNi.ToString();
            netSalarylbl.Text = netSalary.ToString();
        }

        else if (grossSalary > 100000)
        {
            decreasedTaxAlwnce();
            niHighRate();
            totalDeduction = totalTax + totalNi;
            netSalary = grossSalary - totalDeduction;

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxfreeAllowance.ToString();
            totaltxbleLbl.Text = taxableSalary.ToString();
            taxPaidlbl.Text = totalTax.ToString();
            nIlbl.Text = totalNi.ToString();
            netSalarylbl.Text = netSalary.ToString();
        }

        else if(grossSalary >= 43000)
        {
            niHighRate();
            taxAt40();
            totalDeduction = totalTax + totalNi;
            netSalary = grossSalary - totalDeduction;

            if (grossSalary < 43004)
            {
                niBasicRate();
                totalDeduction = totalTax + totalNi;
                netSalary = grossSalary - totalDeduction;
            }

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxfreeAllowance.ToString();
            totaltxbleLbl.Text = taxableSalary.ToString();
            taxPaidlbl.Text = totalTax.ToString();
            nIlbl.Text = totalNi.ToString();
            netSalarylbl.Text = netSalary.ToString();
        }

        else if(grossSalary > 11000)
        {
            taxAt20();
            niBasicRate();
            totalDeduction = totalTax + totalNi;
            netSalary = grossSalary - totalDeduction;

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxfreeAllowance.ToString();
            totaltxbleLbl.Text = taxableSalary.ToString();
            taxPaidlbl.Text = totalTax.ToString();
            nIlbl.Text = niPaidAt12.ToString();
            netSalarylbl.Text = netSalary.ToString();
        }

        else if (grossSalary <= 11000)
        {
            taxBelow11();

            if (grossSalary > 8060)
            {
                niBasicRate();   totalDeduction = totalTax + totalNi;
                netSalary = grossSalary - totalDeduction;
            }
                                  

            grossSalarylbl.Text = grossSalary.ToString();
            taxFreeLbl.Text = taxfreeAllowance.ToString();
            totaltxbleLbl.Text = taxableSalary.ToString();
            taxPaidlbl.Text = totalTax.ToString();
            nIlbl.Text = niPaidAt12.ToString();
            netSalarylbl.Text = netSalary.ToString();
        }
            
     }



    }
    
