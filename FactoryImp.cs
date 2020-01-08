using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory
{
    public class FactoryImp : Factory
    {
        public static String AGUA = "agua";
        public static String CAMPO = "campo";

        public Moto CrearMoto(String tipo, int ruedas) {
            switch (tipo)
            {
                case AGUA:return new MotoAgua(ruedas);
                    break;
                case CAMPO: return new MotoCampo(ruedas);
                    break;
                default: return null;
            }
        }
    }
}