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
            List<string> list = new List<string>();
            //ADICIONAR NA LSITA
            list.Add("Vinicius");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            list.Insert(2, "Jonas");

            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine("list count: " + list.Count);

            //RECEBE PREDICADO
            string s1 = list.Find(x => x[0] == 'A');
            System.Console.WriteLine("First A: " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("first position: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("last position: " + pos2);

            //FILTRO = RECEBE PREDICADO
            List<string> list2 = list.FindAll(x => x.Length == 5);
            System.Console.WriteLine(list2);
            foreach (string obj in list2)
            {
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine("--------------------");
            //REMOVER
            list.Remove("Alex");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }
            //RECEBE PREDICADO
            list.RemoveAll(x => x[0] == 'M');
            System.Console.WriteLine("--------------------");
            //REMOVER TODOS
            list.Remove("Alex");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            //Remover pelo indice
            list.RemoveAt(2);
            System.Console.WriteLine("--------------------");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            //Remover uma faixa = a partir, quantidade
            list.RemoveRange(0, 2);
            System.Console.WriteLine("--------------------");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}