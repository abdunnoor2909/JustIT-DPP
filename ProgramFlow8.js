
//var event1 = document.getElementById("button1");
//event1.addEventListener("click", loop, false);



 document.getElementById("button1").onclick = function loop(){
    
    var i = 0;
     var j =0;
    var number = "";
    
   for(i = 0; i < 10; i++){//if 'i' goes to 10 then dont go above, break! 
       
       number += "<br/> outer loop is: " + (i+1);//write another number in the next line by +1
       
       document.getElementById("demo").innerHTML = number;
    
    for(j = 0; j< 10; j++){
        number +=  "<br>" + (j+1);
    }
   }
    
    
     document.getElementById("demo").innerHTML = number;

     
     
     
}
