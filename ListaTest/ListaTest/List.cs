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
        public Node Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public Node Foot
        {
            get
            {
                return FindLast();
            }
        }
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
                Foot.next = newNode;   
            }
            Console.WriteLine(newNode.valor);
        }
        public Node FindLast()
        {
            Node actual = Head;
            while(actual.next != null)
            {
                actual = actual.next;
            }
            return actual;
        }

        public  string FindSingular(int index)
        {
            int thisIndex = index-1;
            Node actual = head;
            while(thisIndex >= 0)
            {
                actual = actual.next;
                thisIndex--;
            }
            return actual.valor;
        }
        public void insertInto(string Position)
        {

        }
    }
}
