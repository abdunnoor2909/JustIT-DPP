/*Salary Tax Calculator

1. Calculate tax due on a salary input on a webpage by the user, using the 2016-2017 tax allowances and rates as follows:*/



var event1 = document.getElementById("button1");//Function for button1. The function is for question 1.
event1.addEventListener('click', calculateTax, false);

function calculateTax()//Taking user input and calculating tax to pay.
{

//Declaring the variables.
    
var salaryAmount = document.getElementById("input1").value;
var salaryAmountInt = parseInt(salaryAmount);

var taxFreeAllowance = 11000;

var amountToBeTaxed = salaryAmountInt - taxFreeAllowance;


//tax for basic rate
var taxAt20 = 32000 * 0.2;

//tax for higher rate
var taxAt40 = (amountToBeTaxed - 32000) * 0.4;
var addTax = taxAt20 + taxAt40;
    
var netSalaryTax20 = salaryAmountInt - addTax;
    
if(salaryAmountInt <= 11000){
    
    
    document.getElementById("demo").innerHTML = "Gross Salary: " + salaryAmountInt;
    document.getElementById("demo2").innerHTML = "Personal Allowance: " + taxFreeAllowance;
    document.getElementById("demo3").innerHTML = "Tax paid at 20%: " + 0;
    document.getElementById("demo4").innerHTML = "Tax paid at 40%: " + 0;
    document.getElementById("demo5").innerHTML = "Net Salary: " + salaryAmountInt;
}
    

  else if (salaryAmountInt > 43000) {
    document.getElementById("demo").innerHTML = "Gross Salary: " + salaryAmountInt;
    document.getElementById("demo2").innerHTML = "Personal Allowance: " + taxFreeAllowance;
    document.getElementById("demo3").innerHTML = "Tax paid at 20%: " + taxAt20;
    document.getElementById("demo4").innerHTML = "Tax paid at 40%: " + taxAt40;
    document.getElementById("demo5").innerHTML =  "Net Salary: " + (salaryAmountInt - addTax);
  } 
    
    else if (salaryAmountInt > 11000 ){
    document.getElementById("demo").innerHTML = "Gross Salary: " + salaryAmountInt
    document.getElementById("demo2").innerHTML = "Personal Allowance: " + taxFreeAllowance;
    document.getElementById("demo3").innerHTML = "Tax paid at 20%: " + taxAt20;
    document.getElementById("demo4").innerHTML = "Tax paid at 40%: " + 0;
    document.getElementById("demo5").innerHTML = "Net Salary: " + (salaryAmountInt - taxAt20);
    
}
}