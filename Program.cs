using System;
using System.Globalization;
using C_sharp_memory_array_lists;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual é quantidade de produtos que deseja fazer a média dos preços: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Digite o nome: ");
                string name = Console.ReadLine();
                System.Console.Write("Digite o preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;

            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}