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
        int number;
        #region Insert
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
            number++;
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
        #endregion
        #region Insert Into Value
        public Node FindValor(string valor)
        {
            int thisIndex = number;
            Node actual = head;
            Node next = actual;
            while (valor != actual.valor)
            {
                actual = actual.next;
                thisIndex--;
            }
            return actual;
        }
        public void insertIntoValue(string A_element, string element)
        {
            Node Next = new Node(); ;
            Node Actual = new Node(); ;
            Actual = FindValor(A_element);
            Next = Actual.next;
            Node newNode = new Node();
            number++;
            newNode.valor = element;
            if (Actual.next == null)
            {
                Foot.next = newNode;
            }
            else
            {
                newNode.next = Next;
            }
            Actual.next = newNode;
        }
        #endregion
        #region InsertInto
        public Node FindSingular(int index)
        {
            int thisIndex = 0;
            if (index > number)
            {
                index = number;
                thisIndex = index - 2;
            }
            else
            {
                thisIndex = index - 2;
            }
            Node actual = head;
            Node next = actual;
            while (thisIndex >= 0)
            {
                actual = actual.next;
                thisIndex--;
            }
            return actual;
        }
        public void insertInto(int Position, string element)
        {
            Node Next = new Node(); ;
            Node Actual = new Node(); ;
            Actual = FindSingular(Position);
            Next = Actual.next;
            Node newNode = new Node();
            number++;
            newNode.valor = element;
            if(Actual.next == null)
            {
                Foot.next = newNode;
            }
            else if(Position < 1)
            {
                newNode.next = Head.ShallowCopy();
                Head = newNode;
                newNode = Actual;
            }
            else
            {
                newNode.next = Next;
            }
            Actual.next = newNode;
        }
        #endregion
        #region Change Position
        public void insertInto(int Position, string Position2)
        {
            Node Node2 = new Node(); ;
            Node Node1 = new Node(); ;
            Node1 = FindSingular(Position);
            Node2 = FindSingular(Position2);
            number++;
            if (Node2.next == null)
            {
                Foot.next = Node1;
            }
            else if (Position < 1)
            {
                newNode.next = Head.ShallowCopy();
                Head = newNode;
                newNode = Actual;
            }
            else
            {
                newNode.next = Next;
            }
            Actual.next = newNode;
        }
        #endregion
        #region Write
        public void write()
        {
            Node actual = head;
            while (number >= 1)
            {
                Console.WriteLine(actual.valor);
                actual = actual.next;
                number--;
            }
        }
        #endregion
    }
}
