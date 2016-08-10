
var event1 = document.getElementById("button1");
event1.addEventListener("click", myFirst, false);


 var globeV = document.getElementById("input1").value;
    document.getElementById("demo").innerHTML = globeV;


function myFirst(){
   

    var localV = document.getElementById("input2").value;
    
    
    
    document.getElementById("demo2").innerHTML = localV;
    
}


