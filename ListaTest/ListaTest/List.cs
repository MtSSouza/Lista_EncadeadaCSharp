using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTest
{
    class List
    {
        // Creating the list;
        private Node head;
        private Node body;

        public void insert(string element) 
        {
            // Creating the node
            Node newNode = new Node();

            newNode.valor = element;
            if (head == null)
            {
                head = newNode;
            }
            else 
            {
                body.proximo = newNode;   
            }

            body = newNode;

            Console.WriteLine(newNode.valor);

        }
    }
}
