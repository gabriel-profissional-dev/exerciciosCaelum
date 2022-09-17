using System;
namespace desafios
{
    public static class Menu
    {
        public static void Opcao()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Curso em vídeo: Python - Exercícios executados em DotNet + Csharp");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(" ");
            
            Console.WriteLine(("Menu").ToUpper());
            
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine(" ");

            Console.WriteLine("001 - Exercício001: Não é um desafio. Apenas configuração do ambiente de desenvolvimento");
            Console.WriteLine("002 - Exercício002");
            Console.WriteLine("003 - Exercício003");
            Console.WriteLine("004 - Exercício004: Em C#, como temos linguagem tipada, ainda não sei como dissecar uma variável");
            Console.WriteLine("005 - Exercício005");
            Console.WriteLine("006 - Exercício006");
            Console.WriteLine("007 - Exercício007");
            Console.WriteLine("008 - Exercício008");
            Console.WriteLine("009 - Exercício009");
            Console.WriteLine("010 - Exercício010");
            
            Console.WriteLine(" ");
            Console.Write("Escolha: ");

            double escolha = Convert.ToDouble(Console.ReadLine());

            switch(escolha)
            {
                case 001: Console.Clear(); Console.WriteLine("Exercício001 Não é um desafio. Apenas configuração do ambiente de desenvolvimento"); Console.ReadKey(); Menu.Opcao(); break;
                case 002: Exercicio002.RespostaAoUsuario(); break;
                case 003: Exercicio003.SomaDeDoisNumeros(); break;
                case 004: Console.Clear(); Console.WriteLine("Exercício004: Em C#, como temos linguagem tipada, ainda não sei como dissecar uma variável"); Console.ReadKey(); Menu.Opcao(); break;
                case 005: Exercicio005.AntecessorESucessor(); break;
                case 006: Exercicio006.DobroTriploRaiz(); break;
                case 007: Exercicio007.MediaAritmetica(); break;
                case 008: Exercicio008.ConversorDeMedidas(); break;
                case 009: Exercicio009.Tabuada(); break;
                case 010: Exercicio010.ConversorEmDolar(); break;

                default: Menu.Opcao(); break;
            }
        }
    }
}