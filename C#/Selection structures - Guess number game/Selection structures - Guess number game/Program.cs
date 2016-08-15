using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are thinking of a particular number
//Write a simple program that prompts a user to enter numbers to help them guess which number you are thinking of
//Use one or more if-else statements to check whether the number they entered is greater or less than the number you are thinking of
//Extension 1: use a do-while loop to allow the user to make many guesses
//Extension 2: use a random number generator to select the number to guess
//Extension 3: rewrite the code as a 'Guess the Data Type' game, making sure that it accepts decimals.


namespace Selection_structures___Guess_number_game

{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();// Generates a random number.
            int guessNumb = rnd.Next(1, 10);//Creates a random number between 1 - 10.

            int userInputNumb;


            do
            {
                Console.WriteLine("Guess the number i am thinking of...");//Writes line to console

                userInputNumb = Convert.ToInt32(Console.ReadLine());//Asking user for input. In this case asking for a number. (Convert.ToInt32) converts string to number.  

                if (userInputNumb == guessNumb)
                    Console.WriteLine("Correct");

                else
                    Console.WriteLine("That is not the number, guess again");

            } while (userInputNumb != guessNumb); //loop again to the beginning of the code from 'do while' if the number does not equal to the random number.
        }

    } 
}
