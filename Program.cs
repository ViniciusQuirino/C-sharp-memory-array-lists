using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual é quantidade de pessoas que deseja fazer a média da altura: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            
            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}