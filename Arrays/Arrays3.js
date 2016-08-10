/*Add and Remove first and last elements  on and off an array using shift, unshift, push and pop methods*/


//var myArray = []//needs to be outside the function. If inside the function then it will keep executing and it will overwrite the previous
    
var firstArray = [];
var event1 = document.getElementById("button1");
event1.addEventListener('click', viewArray, false);


function viewArray(){//This views the array.
  
    
    firstArray[0] = "apple";
    firstArray[1] = "strawberry";
    firstArray[2] = "mango";
    
    document.getElementById("demo").innerHTML = firstArray;
    
 
    
}

var event2 = document.getElementById("button2");
event2.addEventListener('click', addFirstArray, false);

function addFirstArray(){//Adds an item to the start of an array.
    
    firstArray.unshift("pear");
    
    document.getElementById("demo2").innerHTML = firstArray;
}

var event3 = document.getElementById("button3");
event3.addEventListener('click', removeLastArray, false);



function removeLastArray(){//Removes the last item from the array.
    
    firstArray.pop();
    
    document.getElementById("demo3").innerHTML = firstArray;
}



var event4 = document.getElementById("button4");
event4.addEventListener('click', removeFirstArray, false);

function removeFirstArray(){
    
    firstArray.shift();
    
    document.getElementById("demo4").innerHTML = firstArray;
}
