using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation_ex2
{

    class Car//Blueprint for the object
    {
        public string name;
        public string model;
        public int price;
        public bool sold;


        public static int numberOfCars;//records the number of cars. Static field.

    

        public void addCar(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberOfCars++;
        }

        public void carSold(bool sold, int price)
        {
            this.sold = sold;
            this.price = price;   
            Car.numberOfCars--;
        }

        public void listCar()
        {
            Console.WriteLine("The details of this car are:");
            Console.WriteLine("Name and model: {0} {1}, price: £{2:N0}.", name, model, price);
            if (sold)
            {
                Console.WriteLine("The car has been sold");
            }
            else
            {
                Console.WriteLine("The car is unsold");
            }
            Console.WriteLine();
        }
    }

    class Program
 

    {
        List<Car> ListOfCars = new List<Car>();
         

        static void Main(string[] args)
        {

            Car.numberOfCars = 0;
            
            Car myCar1 = new Car();
            myCar1.addCar("Porsche", "911", 45000);

            Car myCar2 = new Car();
            myCar2.addCar("BMW", "i8", 98000);

            Car myCar3 = new Car();
            myCar3.addCar("VW", "Golf", 12000);

            
            Console.WriteLine("The number of cars we have in the shop is: " + Car.numberOfCars);

            Console.WriteLine();

            myCar1.listCar();
            myCar2.listCar();
            myCar3.listCar();

            
            myCar1.carSold(true , 45000);

            Console.WriteLine("Total number of car is " + Car.numberOfCars);

            myCar1.listCar();
            myCar2.listCar();
            myCar3.listCar();

           

        }
    }


}
