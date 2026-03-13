using System;
namespace Atividade_Diagnóstica___Questão_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maior;

            Console.Write("Digite o 1º número: ");
            maior = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                Console.Write("Digite o " + i + "º número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("O maior número digitado foi: " + maior);

            Console.ReadKey();
        }
    }
}