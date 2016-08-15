//Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1");
event1.addEventListener("click", myFirst, false);

function myFirst()
{
    var userInput1 = document.getElementById("input1").value;
   var userInput2 = document.getElementById("input2").value;

   
   if(userInput1>10 && userInput2 >10){
     document.getElementById("demo").innerHTML = "Both numbers are greater than 10";
 }

    else if(userInput1>10 || userInput2>10){
         document.getElementById("demo").innerHTML = "One number is greater than 10";

    }
    
else
    document.getElementById("demo").innerHTML = "Both your numbers are NOT greater than 10";
}