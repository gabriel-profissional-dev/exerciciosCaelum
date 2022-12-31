using System;

namespace desafios
{
    public static class Exercicio014
    {
        public static void ConversorDeTemperaturas()
        {
            Console.Clear();
            Console.WriteLine("Exercício Python 014: Escreva um programa que converta uma temperatura");
            Console.WriteLine("digitando em graus Celsius e converta para graus Fahrenheit.");
            Console.WriteLine(" ");

            Console.Write("Temperatura em graus Celsius: ");
            double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
            double calculoparaF = (temperaturaCelsius * 1.8) + 32;

            Console.WriteLine($"{temperaturaCelsius} °C Equivalem a {calculoparaF} °F");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}