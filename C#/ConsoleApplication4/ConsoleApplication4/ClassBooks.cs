using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ClassBooks
    {
        public string name;
        public string author;
        public int isbn;
        public int price;


        public ClassBooks(string name, string author, int isbn, int price)
        {
            this.name = name;
            this.author = author;
            this.isbn = isbn;
            this.price = price;
        }
    }
}
