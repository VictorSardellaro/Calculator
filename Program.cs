using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            static void Menu()
            {
                Console.Clear();

                System.Console.WriteLine("Lista de Operações:");
                System.Console.WriteLine("Digite 1 para Soma");
                System.Console.WriteLine("Digite 2 para Subtração");
                System.Console.WriteLine("Digite 3 para Divisão");
                System.Console.WriteLine("Digite 4 para Multiplicação");
                System.Console.WriteLine("Digite 5 para Sair");
                System.Console.WriteLine("");
                System.Console.Write("Digite o número para a opção desejada: ");
                int operacaoOpcao = int.Parse(Console.ReadLine());

                switch (operacaoOpcao)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Menu();
                        break;
                }
            }

            static void Soma()
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                float resultado = v1 + v2;

                Console.WriteLine("");
                // Console.WriteLine("O resultado da soma é " + resultado);
                Console.WriteLine($"O resultado da soma é {resultado}");
                // Console.WriteLine($"O resultado da soma é {v1 + v2}");
                // Console.WriteLine("O resultado da soma é " + (v1 + v2));
                Console.ReadKey();
                Menu();
            }

            static void Subtracao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                System.Console.WriteLine("");

                float resultado = v1 - v2;

                System.Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
                Menu();

            }

            static void Divisao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                System.Console.WriteLine("");

                float resultado = v1 / v2;

                System.Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.ReadKey();
                Menu();

            }

            static void Multiplicacao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                System.Console.WriteLine("");

                float resultado = v1 * v2;

                System.Console.WriteLine($"O resultado da multiplicação é {resultado}");
                Console.ReadKey();
                Menu();

            }
        }
    }
}