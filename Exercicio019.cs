using System;

namespace desafios
{
    public static class Exercicio019
    {
        public static void SorteandoUmItemNaLista()
        {
            Console.Clear();
            Console.WriteLine("Exercício 019: Um professor quer sortear um dos seus quatro alunos para apagar o quadro.");
            Console.WriteLine("Faça um programa que ajude ele, lendo o nome dos alunos e escrevendo na tela o nome do escolhido.");
            Console.WriteLine(" ");

            var grupoDeAlunos = new string[4];

            for (var aluno = 0; aluno <= 3; aluno ++)
            {
                Console.Write($"Digite o nome do {aluno + 1}° anulo: ");
                grupoDeAlunos[aluno] = Convert.ToString(Console.ReadLine());     
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Dos 4 Alunos selecionados para sorteio: ({string.Join(", ",grupoDeAlunos)}) o aluno escolhido para apagar o quadro é: ");
            
            var rand = new Random();
            var alunoEscolhido = rand.Next(0, grupoDeAlunos.Length - 1);
            Console.WriteLine(grupoDeAlunos[alunoEscolhido]);
            
            
        
        }
    }
}