using System;

namespace Atividade_Diagnóstica___Questão_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1 - Somar dois números");
                Console.WriteLine("2 - Subtrair dois números");
                Console.WriteLine("3 - Multiplicar dois números");
                Console.WriteLine("4 - Dividir dois números");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao >= 1 && opcao <= 4)
                {
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Resultado: " + (num1 + num2));
                            break;

                        case 2:
                            Console.WriteLine("Resultado: " + (num1 - num2));
                            break;

                        case 3:
                            Console.WriteLine("Resultado: " + (num1 * num2));
                            break;

                        case 4:
                            if (num2 != 0)
                                Console.WriteLine("Resultado: " + (num1 / num2));
                            else
                                Console.WriteLine("Não é possível dividir por zero.");
                            break;
                    }
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Programa encerrado.");
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.WriteLine();
            }
        }
    }
}


