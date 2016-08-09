var event1 = document.getElementById("button1");
event1.addEventListener("click", sum, false);

function sum(){
    //get values form text boxes
  var userInput1 = document.getElementById("input1");
    var userInput2 = document.getElementById("input2");
    var userInput3 = document.getElementById("input3");
//convert strings to numbers
    var number1 = parseInt(userInput1);
    var number2 = parseInt(userInput2);
    var number3 = parseInt(userInput3);
    
    //call function to add the numbers
    var output = addThree(number1, number2, number3);
    document.getElementById("demo").innerHtml = output;
}
    function addthree (number1 , number2, number3){
        return number1 + number2 + number3;
    }



    
    
    
