using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory
{
    public interface Moto
    {
        //Se crea una interfaz moto la cual se va a implementar en 
        //Las clases motoagua y motocampo
        //y la cual lleva el metodo que obtiene el numero de ruedas que va a llevar
        public int getRuedas();
    }
}