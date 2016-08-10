/*Collect 3 user inputs and allocate them to three members of a new array. Display the array on the webpage.*/

var event1 = document.getElementById("button1");
event1.addEventListener('click', getArray, false);



function getArray(){
   var input1 = document.getElementById("input1").value;
    var input2 = document.getElementById("input2").value;
    var input3 = document.getElementById("input3").value;
    
    var array = [3];
    
    array[0] = [input1];
    array[1] = [input2];
    array[2] = [input3];
    
    document.getElementById("demo").innerHTML = array;
}

