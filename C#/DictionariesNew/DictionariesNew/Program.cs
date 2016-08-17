using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that contains a dictionary of coding languages in which you can:
//1. Check if a key is in the dictionary 
//2. Check if a value is in the dictionary 
//3. Use a key to look up a value.
//4. Count the list.
//5. Exit.
//Extension:  allow the user to add, edit or remove dictionary entries

namespace DictionariesNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();//Creating a dictionary containing a (1)key and a (2)value in string format.
            codingLanguages.Add("c#", "The best programming language");// adding key(1) and a value(2) to the dictionary.
            codingLanguages.Add("javascript", "Most popular language in the world");//""
            codingLanguages.Add("java", "Named after favourite coffee");//""
            codingLanguages.Add("python", "Easy to understand but very powerful");//""
            
            string userInput;

            Console.WriteLine("Coding languages dictionary.  Type K to look for a language, D to look for a description, C to count the list, L to look for the description and X to exit:");
            userInput = Console.ReadLine();//Allows user to type in the console.


            do
            {
                switch (userInput)// so it goes through each key thats typed from userinput.
                {
                    case "k":
                        Console.WriteLine("Type the language you are looking for");
                        userInput = Console.ReadLine();
                        if (codingLanguages.ContainsKey(userInput))//userinput types a 'key' on the console. Program will look for the 'key' that is assigned in the dictionary (codingLanguages.ContainsKey).
                        {
                            Console.WriteLine(userInput + " is in the dictionary");
                        }

                        else
                        {
                            Console.WriteLine("That language is not in the dictionary");
                        }
                        break;

                    case "d":
                        
                        Console.WriteLine("Type the description for the language");
                        userInput = Console.ReadLine();
                        if (codingLanguages.ContainsValue(userInput)) //userinput types a 'value' on the console. Program will look for the 'value' that is assigned in the dictionary(codingLanguages.ContainsValue).
                        {
                            Console.WriteLine("Desription is in the dictionary");

                        }

                        else
                        {
                            Console.WriteLine("That is not in the dictionary");
                        }
                        break;

                    case "c":

                        int countItem = codingLanguages.Count();//Program will 'count' codingLanguages in the dictionary.
                        Console.WriteLine(countItem);
                        break;



                    case "l":
                        Console.WriteLine("Type the language that you want to search:");
                        userInput = Console.ReadLine();
                        string description;
                        codingLanguages.TryGetValue(userInput, out description );// userinput will tell the console to try and get the value for the key (consoleLanguage.TryGetValue). Has to 2 values in the brackets. (userinput , out description).
                        Console.WriteLine(userInput + "  " + description);//will print the userinput(which is the key) + the description(which is the value).
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Please select an option...");
                userInput = Console.ReadLine();
                //stops the loop from continuing forever.

            } while (userInput != "X");
        }
    }
}
