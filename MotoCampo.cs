using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactory
{
    public class MotoCampo:Moto
    {
        int ruedas;
        public MotoCampo(int ruedas)
        {
            this.ruedas = ruedas;
        }
        public int getRuedas()
        {
            return this.ruedas;
        }
    }
}