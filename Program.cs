using System;
using System.Globalization;
using C_sharp_memory_array_lists;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int triple;
            Calculator.Triple(x, out triple);
            System.Console.WriteLine(triple);
        }
    }
}