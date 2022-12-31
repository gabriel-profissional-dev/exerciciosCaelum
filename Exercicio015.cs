using System;
using System.Globalization;

namespace desafios
{
    public static class Exercicio015
    {
        public static void AluguelDeCarros()
        {
            Console.Clear();
            Console.WriteLine("Exercício015: Escreva um programa que pergunte a quantidade de Km percorridos");
            Console.WriteLine("por um carro alugado e a quantidade de dias pelos quais ele foi alugado. ");
            Console.WriteLine("Calcule o preço a pagar sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado.");
            Console.WriteLine(" ");

            Console.Write("Dias que o veículo foi alugado: ");
            decimal diasAlugados = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Km percorridos pelo veículo: ");
            decimal quilometragemRodada = Convert.ToDecimal(Console.ReadLine());

            decimal diaria = 60m;
            decimal precoPorQuilometragem = 0.15m;
            
            decimal totalPorDia = diaria * diasAlugados;
            decimal totalPorKm = quilometragemRodada * precoPorQuilometragem;
            decimal totalAluguel = totalPorDia + totalPorKm;

            string totalDiariaConvertido = totalPorDia.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            string totalKmConvertido = totalPorKm.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            string totalConvertido = totalAluguel.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            Console.WriteLine(" ");

            Console.WriteLine($"Totais");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Kilometragem: {quilometragemRodada} --------- Total: {totalKmConvertido}");
            Console.WriteLine($"Diárias: {diasAlugados} ---------------- Total: {totalDiariaConvertido}");
            Console.WriteLine($"Valor a Pagar: {totalConvertido}");

            Console.ReadKey();

            Menu.Opcao();

        }
    }
}