using System;
using System.Globalization;

namespace desafios
{
    public static class Exercicio012
    {
        public static void CalculandoDescontos()
        {
            Console.Clear();
            Console.WriteLine("Exercício012: Faça um algoritmo que leia o preço de um produto e mostre seu novo preço");
            Console.WriteLine("com 5% de desconto.");
            Console.WriteLine(" ");

            Console.Write("Digite o preço inicial do produto: ");
            decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            decimal porcentagemDesconto = 0.05m;
            decimal valorDescontado = precoInicial * porcentagemDesconto;

            decimal precoComDesconto = precoInicial - valorDescontado;
            
            string precoFinal = precoComDesconto.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            string precoInicialConvertido = precoInicial.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine($"Para o valor de {precoInicialConvertido} seu valor com desconto de 5 % será de {precoFinal}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}