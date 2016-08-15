using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 While and do-while loop exercise

Ask the user 2 riddles and loop until they get the right answer or give up

Use a while loop for the first riddle
Use a do while loop for the second riddle
 
Extension 1:  allow two or more versions of the answer for each riddle

Extension 2: add several more riddles to the program and tell the user how many they got right at the end, 
allowing a maximum of 3 attempts per riddle*/

namespace Iteration_structures_riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddle1Ans = "mailbox";
            Console.WriteLine("What is a seven letter word that contains a thousand letters?");
            string answer = Console.ReadLine();


            while(answer!=riddle1Ans)
            {
             
                Console.WriteLine("Incorrect, try again");
                answer = Console.ReadLine();

            }
            if (answer == riddle1Ans)
            {
                Console.WriteLine("Correct!");
            }


            Console.WriteLine("Feed me and I live, yet give me a drink and I die. What am i?");

            string response = Console.ReadLine();
            string answer2 = "fire";

            do
                Console.WriteLine("Incorrect, try again");

            while (response != answer2);

            if (response == answer2) ;

            Console.WriteLine("Correct!");
            

            

       



      

           

        }

    }
}
