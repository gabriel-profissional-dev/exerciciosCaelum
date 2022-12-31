using System;

namespace desafios
{
    public static class Exercicio011
    {
        public static void PintandoUmaParede()
        {
            Console.Clear();
            Console.WriteLine("Exercício Python 011: Faça um programa que leia a largura e a altura de uma parede em");
            Console.WriteLine("metros, calcule a sua área e a quantidade de tinta necessária para pintá-la,");
            Console.WriteLine("sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.");
            Console.WriteLine(" ");

            Console.Write("Digite o valor da largura da parede (em metros): ");
            double larguraDaParede = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Digite o valor da altura da parede (em metros): ");
            double alturaDaParede = Convert.ToDouble(Console.ReadLine());

            double areaDaParede = larguraDaParede * alturaDaParede;

            double tintaParaPintar = areaDaParede/2;

            Console.WriteLine(" ");
            Console.WriteLine($"Para pintar uma área de {Math.Round(areaDaParede, 2)} metros quadrados precisaremos de {Math.Round(tintaParaPintar, 2)} litros de tinta.");

            Console.ReadKey();

            Menu.Opcao();

        }
    }
}