using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTest
{
    class Node
    {
        // Creating the node parameters
        public int _intvalor = 0;
        private string _valor;
        public string valor
        {
            get 
            {
                _intvalor = int.Parse(_valor);
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }

        private Node _next;
        public Node next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
        public Node ShallowCopy()
        {
            return (Node)this.MemberwiseClone();
        }

    }
}
