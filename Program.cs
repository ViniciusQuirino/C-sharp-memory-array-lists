using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Principal;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.Write("Digite os numeros da matriz: ");
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Digite o numero que quer encontrar: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}