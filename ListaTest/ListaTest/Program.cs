using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTest
{
    class Program
    {
        const int max = 10;
        
        static void Main(string[] args)
        {
            List enter = new List();

            enter.insert("acho");
            enter.insert("que");
            enter.insert("consegui");

            Console.Read();
        }
    }
}
