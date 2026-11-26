using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas.Logica
{
    public class Nodo
    {
        //Campos
        public int Dato;
        public Nodo? Siguiente; 

        //Constructor
        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }


    }
}