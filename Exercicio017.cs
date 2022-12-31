using System;

namespace desafios
{
    public static class Exercicio017
    {
        public static void CatetosEHipotenusa()
        {
            Console.Clear();

            Console.WriteLine("Exercício017: Faça um programa que leia o comprimento do cateto oposto e do cateto adjacente");
            Console.WriteLine("de um triângulo retângulo. Calcule e mostre o comprimento da hipotenusa.");
            Console.WriteLine(" ");

            Console.Write("Digite o valor do Cateto Oposto: ");
            double catetoOposto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Digite o valor do Cateto Ajdacente: ");
            double catetoAdjacente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double hipotenusa = (Math.Pow(catetoAdjacente, 2) + Math.Pow(catetoOposto, 2));

            Console.WriteLine($"O valor da hipotenusa é igual a {hipotenusa}");
            
            Console.ReadKey();

            Menu.Opcao();
        }
    }
}