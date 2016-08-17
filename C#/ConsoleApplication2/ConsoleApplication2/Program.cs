using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesObjectsAndProperties
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        private int _mileage;

        public static int numberOfCars;

        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value > 0)
                    _mileage = value;
            }
        }
    }//end car class

    class Program
    {


        static void Main(string[] args)
        {
            Car.numberOfCars = 0;

            //add cars data
            Car car1 = new Car();
            car1.make = "Rolls Royce";
            car1.model = "Silver Cloud";
            car1.price = 35000;
            car1.Mileage = 25000;
            Car.numberOfCars++;

            Car car2 = new Car();
            car2.make = "Aston Martin";
            car2.model = "DB5";
            car2.price = 750000;
            Car.numberOfCars++;

            Car car3 = new Car();
            car3.make = "Reliant";
            car3.model = "Robin";
            car3.price = 550;
            Car.numberOfCars++;

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}, mileage {3}.", car1.make, car1.model, car1.price, car1.Mileage);  //:N0 formats the number
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}.", car2.make, car2.model, car2.price);
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}.", car3.make, car3.model, car3.price);
            Console.WriteLine();

        }//end main
    }
}


