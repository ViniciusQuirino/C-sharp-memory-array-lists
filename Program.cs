using System;
using System.Globalization;
using C_sharp_memory_array_lists;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos quartos será ocupados: ");
            int n = int.Parse(Console.ReadLine());

            Students[] vect = new Students[10];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Digite o nome do estudante: ");
                string name = Console.ReadLine();
                System.Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();
                System.Console.Write("Digite o quarto que será ocupado pelo estudante: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Students(name, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}