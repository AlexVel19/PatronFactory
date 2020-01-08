using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory
{
    public class MotoAgua:Moto
    {
        int ruedas;
        public MotoAgua(int ruedas)
        {
            this.ruedas = ruedas;
        }
        public int getRuedas()
        {
            return this.ruedas;
        }

    }
}