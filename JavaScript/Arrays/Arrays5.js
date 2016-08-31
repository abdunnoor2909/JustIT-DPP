/*Create an array variable with 10 elements and using a for loop  display each element on the webpage*/


//var myArray = []//needs to be outside the function. If inside the function then it will keep executing and it will overwrite the previous
    
var firstArray = [10]; //This is the array variable. Includes 10 elements passed into it.
var msg = ""; 
var event1 = document.getElementById("button1");
event1.addEventListener('click', viewArray, false);


function viewArray(){//This views the array.
  
    
    firstArray[0] = "United Kingdom";
    firstArray[1] = "United States";
    firstArray[2] = "Canada";
    firstArray[3] = "Brazil";
    firstArray[4] = "France";
    firstArray[5] = "Belgium";
    firstArray[6] = "Russia";
    firstArray[7] = "China";
    firstArray[8] = "Saudi Arabia";
    firstArray[9] = "Japan";
    firstArray[10] = "Ireland";
    
    for(i = 0; i <=10; i++){
        
        
        msg += firstArray [i] + "<br/>";//if count is less or equal to 10, then keep going until you reach 10. For each loop, message/write the loop on the window(DOM).  
        
    }
    
    document.getElementById("demo").innerHTML = msg;
    
 
    
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

var event5 = document.getElementById("button5");
event5.addEventListener('click', addSpecificItem, false);

function addSpecificItem(){//adding item to a specific point in an array.
    
    firstArray.splice(2 , 0 ,"kiwi");//2 means will add item to the second position in array. 0 means it will not remove/replace an item while adding.
    
    document.getElementById("demo5").innerHTML = firstArray;
    
}