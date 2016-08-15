using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Switch-case exercise

Several people are standing for the Presidency of the United States

tell the user who is standing
ask them who they think will win
using a switch-case statement, make a comment about their choice



Extension 1: match user input even if it isn't in the right case

Extension 2: allow users to enter the first name, surname or full name of the candidate
*/



namespace Switch_case_excercise.President_election
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            Console.WriteLine("Donald Trump , Hilary Clinton , xyz are running to become president");
            Console.WriteLine("Who do you think will win?");
            name = Console.ReadLine();

          switch (name.ToLower()) {

                case "donald trump":
                    Console.WriteLine("That would be bad for US");
                    break;

                case "hilary clinton":
                    Console.WriteLine("That would be bad for US");
                    break;
            }

        }
    }
}
