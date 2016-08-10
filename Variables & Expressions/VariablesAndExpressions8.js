//Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1");
event1.addEventListener("click", myFirst, false);

function myFirst()
{
    var userInput1 = document.getElementById("input1").value;
    var userInput2 = document.getElementById("input2").value;
    var userInput3 = document.getElementById("input3").value;
    var userInput4 = parseInt(userInput1) + parseInt(userInput2) + parseInt(userInput3);
    
    var userInput5 = parseInt(userInput1) + parseInt(userInput2)
    
    var answer = userInput5 * parseInt(userInput3)
  document.getElementById("demo").innerHTML = parseInt(userInput4);

    document.getElementById("demo2").innerHTML = parseInt(answer);
  
    
    
}