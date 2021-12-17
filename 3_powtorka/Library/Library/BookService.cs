using System;
using System.Collections.Generic;
using System.Text;


namespace Library.ConsoleApp
{
    class BookService
    {
        public AddBook(string tytul, string autor, int rok, string isbn, int productsavaliable, decimal price)
        {
            tytul = Console.ReadLine();
            autor = Console.ReadLine();
            rok = Convert.ToInt32(Console.ReadLine());
            isbn = Console.ReadLine();
            productsavaliable = Convert.ToInt32(Console.ReadLine());
            price = Convert.ToDecimal(Console.ReadLine());
            
        }
    }
}
