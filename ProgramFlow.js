var event1 = document.getElementById("button1");
event1.addEventListener("click", myFirst, false);

function myFirst(){
    var userInput1 = document.getElementById("input1").value;
    
    window.alert(userInput1)
}