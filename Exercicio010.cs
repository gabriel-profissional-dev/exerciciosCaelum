using System;
using System.Globalization;

namespace desafios
{
    public static class Exercicio010
    {
        public static void ConversorEmDolar()
        {
            Console.Clear();
            Console.WriteLine("Exercício010: Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e mostre quantos dólares ela pode comprar.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            
            Console.Write("Digite quanto dinheiro, em Reais R$, você tem na carteira: ");
            decimal valorEmReal = Convert.ToDecimal(Console.ReadLine());
            
            decimal dolarHoje = 5.25m;
            decimal realParaDolar = valorEmReal/dolarHoje;
            
            string valorEmDolar = realParaDolar.ToString("C", CultureInfo.CreateSpecificCulture("es-US"));
            string valorRealString = valorEmReal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine(" ");
            
            Console.WriteLine($"O valor {valorRealString} nos permite comprar {valorEmDolar} em dólares");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}