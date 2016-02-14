using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List enter = new List();

            enter.insert("1");
            enter.insert("2");
            enter.insert("3");

            Console.WriteLine(enter);
        }
    }
}
