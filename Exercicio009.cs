using System;

namespace desafios
{
    public static class Exercicio009
    {
        public static void Tabuada()
        {
            Console.Clear();
            Console.WriteLine("Exercício009: Faça um programa que leia um número Inteiro qualquer e mostre na tela a sua tabuada.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.Write("Digite um valor para obter sua tabuada: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Tabuada completa de {valor}:");
            Console.WriteLine("-----------------------");
            
            for (double n = 1; n <= 10; n ++)
            {
                Console.WriteLine($"{valor} X {n} = {valor*n}");
            }

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}