using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A user inputs 5 numbers and the program stores them in an array and finds the average

Extension: create a 5 x 5 array, fill it with numbers, and sum each row and each column 
then calculate the overall total of the numbers in the array
 */ 

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] inputNumbers = new int[5];
           

            for (int i = 0; i < inputNumbers.Length; i++)
            {

                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());

                int sum = inputNumbers.Sum();

                              

            }


            

        }
    }
}
