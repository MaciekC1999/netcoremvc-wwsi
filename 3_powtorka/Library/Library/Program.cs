using System;
using Library.Domain;
using Library.Persistence;

namespace Library
{
    class Program
    {
        static void Main(string[] args)

        {
            Book book = new Book(/*uzupelnij parametry*/);
            BooksRepository repository = new BooksRepository();
            string login;
            string haslo;
            Console.WriteLine("Podaj nazwe uzytkownika: ");
            login = Console.ReadLine();
            Console.WriteLine("Podaj haslo: ");
            haslo = Console.ReadLine();
            if (login == "Admin" && haslo == "password")
            {
                Console.WriteLine("Access Granted");
                for (int i = 0; i < 100; i++)
                {
                    string komenda;
                    Console.WriteLine("dodaj -> proba dodania ksiazki");
                    Console.WriteLine("usun -> proba usuniecia ksiazki");
                    Console.WriteLine("wypisz -> proba wypisania wszystkich ksiazek");
                    Console.WriteLine("zmien -> proba zmiany stanu magazynowego ksiazek");
                    Console.WriteLine("dodaj zamowienie -> proba dodania nowego zamowienia");
                    Console.WriteLine("lista zamowien -> proba wypisania wszystkich zamowien");
                    komenda = Console.ReadLine();
                    if (komenda == "wyjdz")
                    {
                        break;
                    }
                    else if (komenda == "dodaj")
                    {
                        Console.WriteLine("proba dodania ksiazki");
                        
                    }
                    else if (komenda == "usun")
                    {
                        Console.WriteLine("proba usuniecia ksiazki");
                        
                    }
                    else if (komenda == "wypisz")
                    {
                        Console.WriteLine("proba wypisania wszystkich ksiazek");
                        
                    }
                    else if (komenda == "zmien")
                    {
                        Console.WriteLine("proba zmiany stanu magazynowego ksiazek");
                        
                    }
                    else if (komenda == "dodaj zamowienie")
                    {
                        Console.WriteLine("proba dodania nowego zamowienia");
                    
                    }
                    else if (komenda == "lista zamowien")
                    {
                        Console.WriteLine("proba wypisania wszystkich zamowien");
                        
                    }
                    Console.Clear();
                }
                
                
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            
        }
    }
}
