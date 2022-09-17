using System;

namespace desafios
{
    public static class Exercicio006
    {
        public static void DobroTriploRaiz()
        {
            Console.Clear();
            Console.WriteLine("Exercício006: Crie um algoritmo que leia um número e mostre o seu dobro, triplo e raiz quadrada.");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.Write("Digite um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double valorDobro = valor * 2;

            double valorTriplo = valor * 3;

            double valorRaiz = Math.Sqrt(valor);

            Console.WriteLine($"O dobro de {valor} é igual a: {valorDobro}");
            Console.WriteLine($"O triplo de {valor} é igual a: {valorTriplo}");
            Console.WriteLine($"A raíz quadrada de {valor} é igual a: {Math.Round(valorRaiz, 4)}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}