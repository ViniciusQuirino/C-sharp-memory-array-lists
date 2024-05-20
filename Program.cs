using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double[,] mat= new double[2,3];

           System.Console.WriteLine(mat.Length); //Quantidade de itens
           System.Console.WriteLine(mat.Rank); //Quantidade de linha
           System.Console.WriteLine(mat.GetLength(0)); //Quantidade de linha
           System.Console.WriteLine(mat.GetLength(1)); //Quantidade de coluna
        }
    }
}