/*Create an array of Countries England, France, Italy, Mexico, 

Poland, Russia, China, Greece, Egypt, India

Create a  user text input field. User can enter a country. The array is searched and when a match is found the position in the array is displayed and the user is given a message to inform whether the country is present or not in the array.*/


//var myArray = []//needs to be outside the function. If inside the function then it will keep executing and it will overwrite the previous
    
var firstArray = []; //This is the array variable. Includes 10 elements passed into it.

    firstArray[0] = "England";
    firstArray[1] = "France";
    firstArray[2] = "Italy";
    firstArray[3] = "Mexico";
    firstArray[4] = "Poland";
    firstArray[5] = "Russia";
    firstArray[6] = "China";
    firstArray[7] = "Greece";
    firstArray[8] = "Egypt";
    firstArray[9] = "India";
   

var event1 = document.getElementById("button1");
event1.addEventListener('click', viewArray, false);


function viewArray(){//This views the array.
  
    
    
 var userinput = document.getElementById("input1").value;
 var searchArray = firstArray.indexOf(userinput);//firstArray.indexOf(userinput) will return the index number of the value that is found in that position. When user types the word thats in the array. userinput communicates with the firstArray to get positon.
    
  if(searchArray >= 0)
  {
       document.getElementById("demo").innerHTML = "MATCHED" + "<br/>" + "Country is positioned " + searchArray;
  }
    
 else{
     document.getElementById("demo").innerHTML = "No match";
 }
    
}

