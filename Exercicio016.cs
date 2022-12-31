using System;

namespace desafios
{
    public static class Exercicio016
    {
        public static void QuebrandoUmNumero()
        {
            Console.Clear();
            Console.WriteLine("Exercício016: Crie um programa que leia um número Real qualquer pelo teclado");
            Console.WriteLine("e mostre na tela a sua porção Inteira.");
            Console.WriteLine(" ");

            Console.Write("Digite um número real qualquer: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine($"A porção inteira do número {numero} é igual a {Math.Truncate(numero)}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}