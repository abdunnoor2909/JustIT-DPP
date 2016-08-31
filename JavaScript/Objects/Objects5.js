/*Create an object within an object (nested) and display a nested object property on the webpage*/

var company = 
    {
     
     ceo: "John",
     manager:"Smith",
     sales:["Harry" , "Jason" , "Jesse"],
     cleaners:["Bill" , "Garry" , "Ferris"],
     
    
    checkCompany: function()//this is a method to access the property of the object. In this case is 'company'.
        
    {
        return this.ceo + "<br/>" + this.manager + "<br/>" + this.sales + "<br/>" + this.cleaners;
    },//the comma allows for another object to be added in the previous object. (Nested object)
    
    building:{
        
        rooms: 20,
        lifts: 2,
        kitchen: 4,
           
      checkBuilding: function()
        {
         return this.rooms + "<br/>" + this.lifts + "<br/>" + this.kitchen;   
        }
    }
       
    
}


var event1 = document.getElementById("button1");
event1.addEventListener('click', outputNestedProperties, false);

function outputNestedProperties(){
    
    var companyProperties = company.checkCompany();//accesses the method and displays the code in method on the webpage.
    
    //because there is more than one object the point has to be used to access the other object (top to bottom).
    
    document.getElementById("demo").innerHTML = companyProperties;
}


