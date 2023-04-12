using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("   Menu");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Exercício 6");
            Console.WriteLine("Exercício 7");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    int num;

                    Console.WriteLine("digite um valor\n");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                        Console.WriteLine("valor = " + i);

                    break;

                case 2:

                    Console.WriteLine("entre com um número\n");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i < n; i++)
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    break;

                case 3:

                    Console.WriteLine("entre com um número\n");
                    int nu = int.Parse(Console.ReadLine());
                    for (int i = 1000; i >= nu; i--)
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    break;

                case 4:
                    int nue = 0;
                    for (int i = 0; i <= 200; i += nue)
                    {
                        if (nue < 0)
                        {
                            Console.WriteLine("Número inválido");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("entre com um número para somar\n");
                            Console.WriteLine("número atual = " + i);
                            nue = int.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("entre com um número\n");
                    int ni = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= 10000; i++)
                        if (ni % i == 0)
                            Console.WriteLine("ele é divisivel por : " + i);
                    break;

                case 6:
                    int no = int.MaxValue;
                    int ny = int.MinValue;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("Digite o {0}º número: ", i);
                        int numero = int.Parse(Console.ReadLine());

                        if (numero < no)
                        {
                            no = numero;
                        }

                        if (numero > ny)
                        {
                            ny = numero;
                        }
                    }
                    Console.WriteLine("\nO menor número digitado foi: {0}", no);
                    Console.WriteLine("O maior número digitado foi: {0}", ny);
                    break;

                case 7:
                    int numj, somaPar = 0, somaImpar = 0;

                    Console.Write("Digite um número: ");
                    numj = Convert.ToInt32(Console.ReadLine());

                    for (; numj != 0;)
                    {
                        if (numj % 2 == 0)
                        {
                            somaPar += numj;
                        }
                        else
                        {
                            somaImpar += numj;
                        }

                        Console.Write("Digite um número: ");
                        numj = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("A soma dos números pares é: " + somaPar);
                    Console.WriteLine("A soma dos números ímpares é: " + somaImpar);
                    break;
            }
        }
    }
}
