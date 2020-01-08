using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory
{
    public interface Factory
    {
        //En esta interfaz se maneja el metodo que va  crear las motos
        //Es lo que el usuario evita 
        //Y es asi como funciona el patron Factory
        public Moto CrearMoto(String tipo, int ruedas);//Este os devuelve un objeto del tipo motoagua
        // o un objeto motocampo

    }
}