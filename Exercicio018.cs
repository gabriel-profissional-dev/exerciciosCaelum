using System;

namespace desafios
{
    public static class Exercicio018
    {
        public static void SenoCossenoTangente()
        {
            Console.Clear();
            Console.WriteLine("Exercício018: Faça um programa que leia um ângulo qualquer e mostre na tela o valor do"); 
            Console.WriteLine("seno, cosseno e tangente desse ângulo.");
            Console.WriteLine(" ");

            Console.Write("Digite o valor do ângulo: ");
            Single angulo = Convert.ToSingle(Console.ReadLine());

            Single anguloRadiano = (MathF.PI * angulo) / 180 ;

            Console.WriteLine($"Para o valor do ângulo de {angulo}°, seu valor em radianos é {MathF.Round(anguloRadiano, 4)}");
            Console.WriteLine(" ");

            Single seno = MathF.Sin(anguloRadiano);
            Single cosseno = MathF.Cos(anguloRadiano);
            Single tangente = MathF.Tan(anguloRadiano);
            
            Console.WriteLine($"Para o ângulo de {Math.Round(anguloRadiano, 6)} temos que:");
            Console.WriteLine(" ");

            Console.WriteLine($"O valor de Seno é igual a: {MathF.Round(seno, 4)}");
            Console.WriteLine($"O valor de Cosseno é igual a: {MathF.Round(cosseno, 4)}");
            Console.WriteLine($"O valor da Tangente é igual a: {MathF.Round(tangente, 4)}");

            Console.ReadKey();

            Menu.Opcao();
        }
    }
}