/*Collect a user input and allocate it to a new array using the push method.

Display the array and the length of the array (number of elements) using array.length on the webpage.*/

var myArray = []//needs to be outside the function. If inside the function then it will keep executing and it will overwrite the previous.
    

var event1 = document.getElementById("button1");
event1.addEventListener('click', getArray, false);




function getArray(){
   var input1 = document.getElementById("input1").value;
   
    
  
    myArray.push(input1);//This function will add another value to var myArray, which is outside the function.

    var lengthOfArray = myArray.length;

   
    
    document.getElementById("demo").innerHTML = myArray;
    document.getElementById("demo2").innerHTML = lengthOfArray;
    
    
    
}

