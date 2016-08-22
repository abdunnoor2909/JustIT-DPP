using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string author;
            string ISBN;
            int price;

            Console.WriteLine("Enter books into your list");
            Console.WriteLine("Type A to add book , L to list all books , D to delete book");
            List<string> books = new List<string>(new string[] { });
            string userInput;

            do
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("Type the name of your book");

                        
                }
            }
        }
    }
}
