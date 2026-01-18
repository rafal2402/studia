using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> produkty = new Dictionary<string, int>();
        
        while(true)
        {
            Console.WriteLine("");
            Console.WriteLine("Wybierz dzialanie.");
            Console.WriteLine("1. Wyswietl stan magazynu.");
            Console.WriteLine("2. Dodaj produkt.");
            Console.WriteLine("3. Zwieksz ilosc.");
            Console.WriteLine("4. Usun produkt po nazwie.");
            Console.WriteLine("5. Wyjdz");
            Console.WriteLine("");
            string wybor = Console.ReadLine();
            
            if(wybor == "1")
            {
                if(produkty.Count == 0)
                {
                    Console.WriteLine("Magazyn jest pusty.");
                }
                else
                {
                    foreach(var produkt in produkty)
                    {
                        Console.WriteLine($"{produkt.Key}, ilosc: {produkt.Value}");
                    }
                }
            }
            else if(wybor == "2")
            {
                Console.WriteLine("Podaj nazwe produktu, ktory chcesz dodac.");
                string produkt = Console.ReadLine();
                Console.WriteLine("Podaj ilosc jaka chcesz dodac");
                int ilosc = int.Parse(Console.ReadLine());
                produkty[produkt] = ilosc;
            }
            else if(wybor == "3")
            {
                Console.WriteLine("Podaj nazwe produktu, ktorego chcesz zwiekszyc ilosc.");
                string zwiekszanie = Console.ReadLine();
                if(produkty.ContainsKey(zwiekszanie))
                {
                    produkty[zwiekszanie]++;
                }
                else
                {
                    produkty[zwiekszanie] = 1;
                }
            }
            else if(wybor == "4")
            {
                Console.WriteLine("Podaj nazwe produktu, ktory chcesz ususnac.");
                string usuwanie = Console.ReadLine();
                if(produkty.ContainsKey(usuwanie))
                {
                    produkty.Remove(usuwanie);
                    Console.WriteLine($"Usunieto pomyslnie: {usuwanie}");
                }
                else
                {
                     Console.WriteLine("Wybrany produkt nie istnieje.");
                }
            }
            else if(wybor == "5")
            {
                Console.WriteLine("Do zobaczenia!");
                break;
            }
            else
            {
                 Console.WriteLine("Nieprawidlowe dzialanie. Prosze wybrac ponownie.");
            }
        }
    }
}
