using System;
using System.Globalization;
using System.Numerics;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Vinicius", "Beto" };

            foreach (string obj in vect)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}