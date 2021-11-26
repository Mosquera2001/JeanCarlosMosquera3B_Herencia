using System;
using System.Collections.Generic;
using System.Text;

namespace Pila_JeanCarlosMosquera3B
{
    public class Nodo
    {
        private int dato;

        private Nodo siguiente;

        public int Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }

}
