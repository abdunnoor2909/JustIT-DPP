/*Mini Project: Random winner generator       

http://lite-support.co.uk/dev/published/randomwinnergenerator/rwg.html

Users can input elements into an array and then select a random winner from that array and display it on the screen*/

var namesInArray = [];//array has no items.

var event1 = document.getElementById("button1");
event1.addEventListener('click', inputNames, false);



function inputNames(){
    
    var userInput = document.getElementById("input1").value;
    
    var newArray = namesInArray.push(userInput); //to insert new item in array.
    
    document.getElementById("demo").innerHTML = namesInArray;
}

var event2 = document.getElementById("button2");
event2.addEventListener('click', randomWinner, false);

function randomWinner(){
    var random = namesInArray[Math.floor(Math.random()*namesInArray.length)]
    
    document.getElementById("demo2").innerHTML = "Winner is: " + random;
}


