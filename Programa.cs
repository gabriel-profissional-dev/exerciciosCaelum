/*
using System;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Bhaskara();
        }

        static void Bhaskara()
        {   
            Console.Clear();
            Console.WriteLine("Fórmula de Bhaskara. Insira abaixo os valores de a, b e c para começar.");
            Console.WriteLine("Valor de a:");

            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de b:");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de c:");
            double valorC = double.Parse(Console.ReadLine());

            double v = (Math.Pow(valorB,2)) - (4 * valorA * valorC);
            double valorDelta = v;

            Console.WriteLine($"O valor de Delta é igual a {valorDelta}");

            double valorX1 = ((-valorA) + (Math.Pow(valorDelta,1/2)))/(2*valorA*valorB);

            double valorX2 = ((+valorA) + (Math.Pow(valorDelta,1/2)))/(2*valorA*valorB);

            Console.WriteLine($"O valor de X1 é igual a = {Math.Round(valorX1,2)}");
            Console.WriteLine($"O valor de X2 é igual a = {Math.Round(valorX2,2)}");

            Console.ReadKey();

        }

    }
}
*/