using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Dinners

You are Snow White and you are serving the seven dwarves with their dinner and a nice warm drink

Declare an array of strings for the dwarves’ names, e.g.
string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
Using a for loop, tell each dwarf by name that his dinner is ready
Using a foreach loop, tell each dwarf by name that his drink is ready
 

Extension: ask each dwarf what he wants for his dinner and drink, then tell each dwarf by name 
that his meal/drink is ready, naming his choice as well: e.g. "Doc, your roast beef is ready" or "Sleepy, your cocoa is ready"
*/
namespace Dinners_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            string dinner = "";//will allow each element/item in the array to be printed individually.
           
            for (int i = 0; i < 7; ++i)
            {

                dinner += sevenDwarves[i] + "Your dinner is ready";//Prints out each element in the array(sevenDwarves). '[i]' is a counter.
            }
            Console.WriteLine(dinner);
          
            //***********Second example (foreach)*********
        
            foreach (string dwarves in sevenDwarves)//foreach goes through each element/item in an array. 
            {
                Console.WriteLine(dwarves);//Prints out each string dwarves in the array sevenDwarves.
            }

        }
    }
}
