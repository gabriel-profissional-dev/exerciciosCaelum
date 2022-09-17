using System;

namespace desafios
{
    public static class Exercicio002
    {
        public static void RespostaAoUsuario()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercício 002:  Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas-vindas.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.Write("Digite seu nome: ");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine($"Olá {nome} !!! Seja bem vindo ao mundo da programação!!!");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}