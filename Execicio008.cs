using System;

namespace desafios
{
    public static class Exercicio008
    {
        public static void ConversorDeMedidas()
        {
            Console.Clear();
            Console.WriteLine("Exercício008: Escreva um programa que leia um valor em metros e o exiba convertido em centímetros e milímetros.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Digite um valor de medida em metros: ");
            double valorMetro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double valorCentimetro = Math.Round((valorMetro * 100), 4);
            double valorMilimetro = Math.Round((valorMetro * 1000), 4);

            Console.WriteLine($"{valorMetro} Metros equivale a: {valorCentimetro} Centímetros e {valorMilimetro} Milímetros");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}