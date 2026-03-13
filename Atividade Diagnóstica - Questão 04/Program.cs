using System;
namespace Atividade_Diagnóstica___Questão_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double[] notas = new double[5];

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Mostrar média das notas");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Nome: ");
                            nomes[i] = Console.ReadLine();

                            Console.Write("Nota: ");
                            notas[i] = double.Parse(Console.ReadLine());
                        }
                        break;

                    case 2:
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Aluno: " + nomes[i] + " Nota: " + notas[i]);
                        }
                        break;

                    case 3:
                        double soma = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            soma += notas[i];
                        }

                        Console.WriteLine("Média geral: " + (soma / 5));
                        break;
                }
            }
        }
    }
}