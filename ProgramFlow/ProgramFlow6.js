
//var event1 = document.getElementById("button1");
//event1.addEventListener("click", loop, false);



 document.getElementById("button1").onclick = function loop(){
    
    var i = 1
    var write = ""
    
    while(i <= 10)
        {
            write += "<br/>" + i++; //write again in another line
        }
     document.getElementById("demo").innerHTML = write;

     
     
     
}
