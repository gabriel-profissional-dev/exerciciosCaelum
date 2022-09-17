using System;
namespace desafios
{
    public static class Exercicio007
    {
        public static void MediaAritmetica()
        {
            Console.Clear();
            Console.WriteLine("Exercício007: Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a sua média.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Digite o segundo valor: ");
            double segundoValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double media = (primeiroValor + segundoValor)/2;

            Console.WriteLine($"A média Aritmética entre {primeiroValor} e {segundoValor} é igual a: {Math.Round(media, 4)}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}