using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Ala ";
            string b = "ma ";
            string c = "kota.";
            string result = a + b + c;
            Console.WriteLine(result);
            int n1 = 10;
            int n2 = 20;
            if (n1 > n2)
            {
                Console.WriteLine("n1 jest wieksze od n2");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("n1 jest rowne n2");
            }
            else
            {
                Console.WriteLine("n2 jest wieksze od n1");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("C#");
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("C#");
                j++;
            }
            
           for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }
            string[] colours = {"niebieski", "czarny", "zielony", "czerwony"};
            Console.WriteLine("Moj pierwszy kolor to: " + colours[0]);
            Console.WriteLine("Moj ostatni kolor to: " + colours[3]);
            int[] liczby = { 22, 10, 37, 25, 67, 75, 21, 32, 48, 53 };
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Liczba: " + liczby[k]);
            }
            j = 0;
            while (j < 10)
            {
                Console.WriteLine("Liczba: " + liczby[j]);
                j++;
            }
            foreach (int item in liczby)
            {
                Console.WriteLine("Liczba: " + item);
            }
            List<string> fruits = new List<string>();
            fruits.Add("Pomidor");
            fruits.Add("Jablko");
            fruits.Add("Marchewka");
            fruits.Add("Banan");
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + ", ");
            }
            fruits.Remove("Pomidor");
            fruits.Remove("Banan");
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + ", ");
            }
        }
    }
}
