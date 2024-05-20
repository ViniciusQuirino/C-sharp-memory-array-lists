using System;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {  
           //stack
           int x = 10;

           //heap = boxing
           Object obj = 20;

           //unboxing
            int y = (int) obj;
            System.Console.WriteLine(y);
             

        }
    }
}