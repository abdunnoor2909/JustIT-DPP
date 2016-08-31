/*Build an object constructor

Create 2 instances of the object

Display the properties of the object instances on the webpage*/

function car (name, color, doors)//This is the template to make new objects in. In this case its a blueprint for a car.
{
    this.name = name;
    this.color = color;
    this.doors = doors;
    
    
}


var carPorsche = new car("Porsche", "Blue", 5);//New object is created and the properties (Porsche, Blue, 5) are being passed into the function( template for creating objects). *carPorsche is an instance of a object.*

var carFerrari = new car("Ferrari", "Red", 2);

var event1 = document.getElementById("button1");
event1.addEventListener('click', outputProperties, false);

function outputProperties()

{
    var porsche = "The name of the car is: " + carPorsche.name + "<br/>" + "The color of the is: " + carPorsche.color + "<br/>" + "The number of doors are " + carPorsche.doors;
    
    var ferrari = "The name of the car is: " + carFerrari.name + "<br/>" + "The color of the is: " + carFerrari.color + "<br/>" + "The number of doors are " + carFerrari.doors;

    
    document.getElementById("demo").innerHTML = porsche;
    document.getElementById("demo2").innerHTML = ferrari;
}


