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
            enter.insert("1");
            enter.insert("2");
            enter.insert("3");
            enter.insert("4");
            enter.insert("5");
            enter.insert("6");
            enter.insertInto(10, "7");
            enter.insertIntoValue("7","8");
            enter.write();
            Console.Read();
        }
    }
}
