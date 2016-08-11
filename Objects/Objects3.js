/*Create an object with properties and a method

Access the method*/


//The object is the car and the properties are its: name, color and doors. This is a literal object.

 var car = {
    
    name: "Porsche",
    color: "Blue",
    doors: 5,

checkProperties: function(){
    return this.doors; 

}
    
};


var event1 = document.getElementById("button1");
event1.addEventListener('click', outputProperties, false);



