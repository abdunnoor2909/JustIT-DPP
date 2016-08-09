//Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1");
event1.addEventListener("click", myFirst, false);

function myFirst()
{
    var userInput1 = document.getElementById("input1").value;
   
   
 if(userInput1<0){
     document.getElementById("demo").innerHTML = "Your number is a negative number"
 }

else if(userInput1<10){
        document.getElementById("demo").innerHTML = "Your number is less than 10"
        }
    

else if (userInput1==10) {
    document.getElementById("demo").innerHTML = "Your number is equal to 10"
}

else{
    document.getElementById("demo").innerHTML = "Your number is more than 10"
}
    
}