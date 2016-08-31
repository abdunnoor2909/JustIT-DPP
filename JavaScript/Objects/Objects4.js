/*Create an object variable with 3 properties: firstname, surname, fullname. For the fullname value create a method which returns the firstname and surname and display on the webpage*/


 var person = {//this is the object.
    
    firstname: "Fokhrul" ,//these are the properties.
    surname: "Islam",
    fullname: "Fokhrul Islam",

checkProperties: function(){//this is the method. checkProperties is the method. 
    return this.firstname + this.surname; 

}
    
};


var event1 = document.getElementById("button1");
event1.addEventListener('click', outputProperties, false);

function outputProperties(){
    
    var personProperties = person.checkProperties();//accesses the method and displays the code in method on the webpage.
    
    document.getElementById("demo").innerHTML = personProperties;
}

