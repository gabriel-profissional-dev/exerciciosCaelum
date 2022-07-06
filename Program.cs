using System;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Media();
        }

        static void Media()
        {
            double idadeGabriel = 36;
            double idadeAdryelle = 33;
            double idadeAdryan = 11;

            double resultado = (idadeGabriel + idadeAdryelle + idadeAdryan)/3;

            Console.Clear();
            Console.WriteLine(Math.Round(resultado,2));
            Console.ReadKey();
        }
    }
}