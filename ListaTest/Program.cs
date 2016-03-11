using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ListaTest
{
    class Program
    {
        const int max = 10;
        const int troca = 0;
        /* LIST OF FUCNTIONS
         * 
            *  list.insert("6"); CREAT AN ITEM
               list.insertInto(10, "7"); INSERT INTO LIST POSITION
               list.insertIntoValue("7","8"); INSERT INTO POSITION WITH A PRE-DETERMINED VALUE
               list.ChangeBetween(1, 2); CHANGE BETWEEN NODES WITHIN TWO POSITIONS
               list.Organize(List list);
            *  list.write(); WRITE THE NODES IN CONSOLE
         *  
         */
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Code
            List list = new List();
            list.RandomValues(max, list);
            list.QuickSort(list,0,list.number); 
            /*while(list.number < 30)
            {
                list.RandomValues(5, list);
                list.Organize(list);
            }*/
            list.write();
            stopwatch.Stop();
            Console.WriteLine("Quanto tempo demorou esta caralha: {0}", stopwatch.Elapsed);
            Console.WriteLine("Quantos itens: {0}", list.trocas);
            Console.Read();
        }
    }
}
