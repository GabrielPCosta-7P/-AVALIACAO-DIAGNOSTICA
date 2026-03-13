using System;
namespace Atividade_Diagnóstica___Questão_02
{
internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fim;

            Console.Write("Digite o número inicial: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            fim = int.Parse(Console.ReadLine());

            if (inicio < fim)
            {
                Console.WriteLine("Números no intervalo:");
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("Erro: o número inicial deve ser menor que o número final.");
            }
        }
    }
}
// Não entendi bem se era pra mostrar quando o final for menor que o inicio tbm, deixei só quando o final for maior (: