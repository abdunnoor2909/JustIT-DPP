using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classes, objects and properties - excercise.

   //- You are writing an application for a car dealership.
   //- Create a car class with some non - static fields and a static field to record the total number of cars in the program.

   // - Instatiate 3 Objects
   //     - Assign values to their properties.
   //     - Increment the total number of cars each time you
   //       instatiate another car object
   
   // - Display thevalues of the object and the static field.  




namespace ObjectOrientation_ex_1
{

    class Car//Blueprint for the object
    {
        public string name;
        public string model;
        public int price;
        public bool sold;

        public static int numberOfCars;//records the number of cars. Static field.

    }//ends Car class

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();//creating a "new object" template.

            //object one
            myCar.name = "Porsche";
            myCar.model = "911";
            myCar.price = 65000;
            myCar.sold = false;
            Car.numberOfCars++;//increments the number of cars. Is another car(object) is made then the number of cars will increase.

            //object two
            Car myCar2 = new Car();
            myCar2.name = "BMW";
            myCar2.model = "i8";
            myCar2.price = 120000;
            myCar2.sold = false;
            Car.numberOfCars++;

            //object three
            Car myCar3 = new Car();
            myCar3.name = "Mercedes";
            myCar3.model = "E250";
            myCar3.price = 20000;
            myCar3.sold = false;
            Car.numberOfCars++;



            Console.WriteLine("The number of cars we have in the shop is: " + Car.numberOfCars);
            Console.WriteLine("The details of the cars are:");
            Console.WriteLine(("Name and model: {0} {1}, price: £{2:N0}"), myCar.name, myCar.model, myCar.price);//plceholders are used to correspond to the positions of the value to write to the console. 
            Console.WriteLine(("Name and model: {0} {1}, price: £{2:N0}"), myCar2.name, myCar2.model, myCar2.price);
            Console.WriteLine(("Name and model: {0} {1}, price: £{2:N0}"), myCar3.name, myCar3.model, myCar3.price);




        }
    }

    
}
