using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

            string answer;

            codingLanguages.Add("C#" , "Best programming langueage");
            codingLanguages.Add("JS", "My personal favourite");
            codingLanguages.Add("Python", "Easy but powerful");

            Console.WriteLine("Coding languages dictionary.  Type K to look for a language, D to look for a description, C to count the list and X to exit:");



            char response =  Convert.ToChar(Console.ReadLine().ToUpper());

        }
    }
}
