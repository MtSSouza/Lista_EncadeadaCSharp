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
        private string _valor;
        public string valor
        {
            get 
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }

        private Node _proximo;
        public Node proximo
        {
            get
            {
                return _proximo;
            }
            set
            {
                _proximo = value;
            }
        }
    }
}
