using System;

namespace inicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var lista = new List<int> {};
            for (int n = 0; n <= 5; n ++)
            {
                Console.WriteLine("Digite um valor");
                int valor = Convert.ToInt32(Console.ReadLine());

                lista.Add(valor);
                Console.WriteLine(lista{valor});
            }

            Console.WriteLine($"Lista criada: {lista}");
        }
    }
}