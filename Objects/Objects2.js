/*Create an object variable and output each object property in a concatenated string onto the webpage*/


//The object is the car and the properties are its: name, color and doors. This is a literal object.
var car = {
    
    name: "Porsche",
    color: "Blue",
    doors: 5,
    
};


var event1 = document.getElementById("button1");
event1.addEventListener('click', outputProperties, false);



    
 function outputProperties(){
    
    var carName = car.name + "<br/>" + car.color + "<br/>" + car.doors;
    
    document.getElementById("demo").innerHTML = carName;
}





