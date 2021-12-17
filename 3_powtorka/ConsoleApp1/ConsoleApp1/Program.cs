using System;

namespace ConsoleApp1
{
    class Program
    {
        private const double V = 125.555;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            int result = 5 + 9;
            Console.WriteLine(result);
            int number = 10;
            float money = 15;
            string text = "Program 1";
            bool isLoged = true;
            char myChar = '@';
            decimal price = 125;
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLoged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);
            int myAge = 22;
            int wifeAge = 18;
            result = myAge + wifeAge;
            Console.WriteLine(result);
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue & isFalse;
            bool or = isTrue ^ isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);
            double a = 5;
            double b = 12;
            double add = a + b;
            double sub = a - b;
            double div = a / b;
            double mul = a * b;
            double mod = a % b;
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);
        }
    }
}
