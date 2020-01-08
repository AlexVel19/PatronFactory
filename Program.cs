using System;

namespace PatronFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            String TipoMoto = "campo";
            int numRuedas = 2;

            Factory factory = new FactoryImp();
            Moto moto = factory.CrearMoto(TipoMoto, numRuedas);
            Console.WriteLine("Es una moto de: "+ moto.getRuedas()+"ruedas.");

        }
    }
}
