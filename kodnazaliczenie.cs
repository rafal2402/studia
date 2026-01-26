using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> wydatki = new Dictionary<string, int>();
        
        while(true)
        {
            
            
            Console.WriteLine("KALKULATOR WYDATKOW DOMOWYCH");
            Console.WriteLine("1. Dodaj wydatek.");
            Console.WriteLine("2. Wyswietl liste wydatkow.");
            Console.WriteLine("3. Oblicz laczna kwote wydatkow.");
            Console.WriteLine("4. Znajdz najwiekszy wydatek.");
            Console.WriteLine("5. Wyjdz.");
            Console.Write("Wybierz opcje: ");
            string input = Console.ReadLine();
            
            if(input == "1")
            {   
                Console.Write("Nazwa wydatku jaki chcesz dodac: ");
                string wydatek = Console.ReadLine();
                
                if(wydatki.ContainsKey(wydatek))
                {
                    int przeznaczenie = wydatki[wydatek];
                    Console.WriteLine($"Taki wydatek juz istnieje. Przeznaczono: {przeznaczenie}.");
                    Console.Write("Kwota jaka chcesz przeznaczyc na ten wydatek: ");
                    int kwota = int.Parse(Console.ReadLine());
                    wydatki[wydatek] += kwota;
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Kwota jaka chcesz przeznaczyc na ten wydatek: ");
                    int kwota = int.Parse(Console.ReadLine());
                    wydatki[wydatek] = kwota;
                    Console.WriteLine("");
                }
            }
            else if(input == "2")
            {
                
                
                if(wydatki.Count == 0)
                {
                    Console.WriteLine("Brak dodanych wydatkow.");
                    Console.WriteLine("");
                }
                else
                {
                    foreach(var wydatek in wydatki)
                    {
                        Console.WriteLine($"Wydatek: {wydatek.Key}, kwota: {wydatek.Value} zl");
                        
                    }
                    Console.WriteLine("");
                }
                
            }
            else if(input == "3")
            {   
                int suma = 0;
                foreach(var kwota in wydatki.Values)
                {
                    suma += kwota;
                }
                Console.WriteLine($"Laczna kwota wydatkow: {suma} zl.");
                Console.WriteLine("");
            }
            else if(input == "4")
            {
                int maksWydatek = wydatki.Values.Max();
                Console.WriteLine($"Najwieksza wartosc wydatku: {maksWydatek}."); 
                Console.WriteLine("");
            }
            else if(input == "5")
            {
                Console.WriteLine("Do zobaczenia!");
                break;
            }
            else
            {
                Console.WriteLine("Brak dostepnej opcji. Sprobuj ponownie!");
                Console.WriteLine("");
            }
        }
    }
}
