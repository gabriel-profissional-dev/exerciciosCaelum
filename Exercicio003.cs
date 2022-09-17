using System;

namespace desafios
{
    public static class Exercicio003
    {
        public static void SomaDeDoisNumeros()
        {
            Console.Clear();

            Console.WriteLine("Exercício 003: Crie um programa que leia dois números e mostre a soma entre eles.");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine((" "));

            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((" "));

            Console.Write("Digite o segundo valor: ");
            double segundoValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double soma = primeiroValor + segundoValor;

            Console.WriteLine($"A soma entre {primeiroValor} e {segundoValor} é igual a: {soma}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}