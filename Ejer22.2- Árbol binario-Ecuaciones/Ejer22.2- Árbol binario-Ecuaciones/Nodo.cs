using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer22._2__Árbol_binario_Ecuaciones
{
    class Nodo
    {
        public char dato;
        public Nodo anterior, siguiente;
        public Nodo hijoIzq, hijoDer;


        public Nodo(char dato)
        {
            this.dato = dato;
            anterior = null;
            siguiente = null;
            hijoIzq = null;
            hijoDer = null;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
