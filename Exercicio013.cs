using System;
using System.Globalization;

namespace desafios
{
    public static class Exercicio013
    {
        public static void ReajusteSalarial()
        {
            Console.Clear();
            Console.WriteLine("Exercício Python 013: Faça um algoritmo que leia o salário");
            Console.WriteLine("de um funcionário e mostre seu novo salário, com 15% de aumento.");
            Console.WriteLine(" ");
            
            Console.Write("Digite o valor do salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" ");

            decimal porcentagem = 0.15m;
            decimal valorDeReajuste = salario * porcentagem;
            decimal salarioReajustado = salario + valorDeReajuste;

            string valorFinalConvertido = salarioReajustado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            string valorSalarioConvertido = salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine($"Para o salário de {valorSalarioConvertido} seu valor ajustado em 15 % será igual a: {valorFinalConvertido}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}