using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ListaTest
{
    class List
    {
        // Creating the list;
        private Node head;
        public int number;
        public int trocas;
        public Stopwatch stopwatch = new Stopwatch();
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
        public void ChangeBetween(int Position, int Position2)
        {
            Node Node1 = new Node();
            Node Node2 = new Node();
            Node Copy2 = new Node();
            Node1 = FindSingular(Position);
            Node2 = FindSingular(Position2);
            Copy2 = Node2.ShallowCopy();
            Node2.valor = Node1.valor;
            Node1.valor = Copy2.valor;
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
        #region Organize
        public Node FindItem(int index)
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
        public void Organize(List list)
        {
            stopwatch.Start();
            int troca = 0;
            int comp=0;
            int length=list.number;

            for(int i=length;i>0;i--)
            {
                for (int j=0;j<i; j++)
                {
                    comp++;
                    Node actual=FindItem(j);
                    Node next=actual.next;
                    int counts=0;
                    if(int.Parse(actual.valor)>int.Parse(next.valor))
                    {
                        counts++;
                        ChangeBetween(j, j+counts);
                        actual=FindItem(j+counts);
                        next=actual.next;
                        troca++;
                    }
                    else if(int.Parse(actual.valor)==int.Parse(next.valor))
                    {
                        actual = FindItem(j + counts);
                        next = actual.next;
                        troca++;
                    }
                    else
                    {
                        next=next.next;
                    }
                }
            }
            trocas = troca;
            stopwatch.Stop();
        }
        #endregion
        #region Quick Sort
        public int Noded(List list,int left,int right)
        {
            Node pivot = Head;
            Node LeftAnchor = FindItem(left);
            Node RightAnchor = FindItem(left);
            while (true)
            {
                while (LeftAnchor._intvalor < pivot._intvalor)
                {
                    left++;
                    LeftAnchor = FindItem(left);
                }
                while (RightAnchor._intvalor > pivot._intvalor)
                {
                    right++;
                    RightAnchor = FindItem(right);
                }

                if (left < right)
                {
                    Node Copy = RightAnchor.ShallowCopy();
                    RightAnchor = LeftAnchor;
                    LeftAnchor = Copy;
                }
                else
                {
                    return right;
                }
            }
        }
        public void QuickSort(List list,int left,int right)
        {
            if (left < right)
            {
                int pivot = Noded(list, 0, number);
                if (pivot > 1)
                {
                    QuickSort(list, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(list, pivot + 1, right);
                }
            }
        }
        #endregion
        #region Random Values
        public void RandomValues(int max, List list)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 999+number);

            for(int i=0;i<max-4;i++)
            {
                list.insert(randomNumber.ToString());
                randomNumber = random.Next(0, 999+number);
            }
            
        }
        #endregion
    }
}
