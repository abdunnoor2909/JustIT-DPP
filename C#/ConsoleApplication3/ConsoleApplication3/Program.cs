using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
   
        class Program
        {
            static void Main(string[] args)
            {


                Console.WriteLine("Enter books into the list");//prints to the console
                Console.WriteLine("A = Add , R = Remove, S = Sort , L = List");//prints to console
                List<string> books = new List<string>(new string[] {});//creates the new list template and to add to the list.
                string userInput;

                //for (int i = 0; i < books.Count; i++)
                {

                    do

                    {
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {

                            case "a":
                                Console.WriteLine("Type a book you would like to add");
                                string addBook = Console.ReadLine();
                                books.Add(addBook);
                                Console.WriteLine("Please enter an option");
                                break;

                            case "r":
                                Console.WriteLine("Type a book you would like to remove");
                                string removeBook = Console.ReadLine();
                                books.Remove(removeBook);
                                Console.WriteLine("Please enter an option");
                                break;

                            case "l":
                                Console.WriteLine("Here is a list of the books");
                                foreach (string count in books)
                                    Console.WriteLine(count);
                                Console.WriteLine("Please enter an option");
                                break;

                            case "s":
                                books.Sort();
                                foreach (string count in books)
                                    Console.WriteLine(count);
                                Console.WriteLine("Please enter an option");
                                break;

                            default:
                                Console.WriteLine("Please enter an option");
                                break;




                        }



                    } while (userInput != "x");


                }


            }



        }
    }

