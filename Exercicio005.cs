using System;

namespace desafios
{
    public static class Exercicio005
    {
        public static void AntecessorESucessor()
        {
            Console.Clear();
            Console.WriteLine("Exercício005: Faça um programa que leia um número Inteiro e mostre na tela o seu sucessor e seu antecessor.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.Write("Digite um valor: ");

            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine($"{valor - 1} é o antecessor de {valor} e seu sucessor é {valor + 1}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}