
//var event1 = document.getElementById("button1");
//event1.addEventListener("click", loop, false);



 document.getElementById("button1").onclick = function dateAndTime(){
    
    var day = "";
     //create a new date object
    var today = new Date();
    //get the day and switch on the value (0-6) to set the day string
    
    switch(today.getDay()){
            
        case 0:
            day = "Sunday";
            break;
        
        case 1:
            day = "Monday";
            break;
        
        case 2:
            day = "Tuesday"
            break;
        
        case 3:
            day = "Wednesday"
            break;
            
        case 4:
            day = "Thursday"
            break;
            
        case 5:
            day = "Friday"
            break;
            
        case 6:
            day = "Saturday"
            break;
            
        default:
            day = "I don't know what day it is"
            break;
        
    }
  
    //get the time for display
    var hours = today.getHours();
    var minutes = today.getMinutes();
    var time = hours + ":" + minutes;
     
    //display the time
    document.getElementById("demo").innerHTML = "It's " + day + " and the time is " + time;
     
     
     
     
}
