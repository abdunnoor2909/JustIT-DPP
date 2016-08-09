
//var event1 = document.getElementById("button1");
//event1.addEventListener("click", loop, false);



 document.getElementById("button1").onclick = function loop(){
    
    var outputString = "";
    
    
    for(var i = 0; i <= 50; i++){
        outputString += i + "<br/>";
        document.getElementById("demo").innerHTML = outputString;
}
        
}
