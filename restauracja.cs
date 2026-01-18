using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        Dictionary<string, int> slownik = new Dictionary<string, int>();
        
        while(true)
        {
            Console.WriteLine("");
            Console.WriteLine("Wybierz dzialanie.");
            Console.WriteLine("1. Zloz zamowinie.");
            Console.WriteLine("2. Wyswietl wszystkie zamowienia.");
            Console.WriteLine("3. Wyswietl liczbe sztuk, kazdego zamowionego dania.");
            Console.WriteLine("4. Anuluj zamowienie.");
            Console.WriteLine("5. Wyjdz.");
            Console.WriteLine("");
            string wybor = Console.ReadLine();
            
            if(wybor == "1")
            {
                Console.WriteLine("Co chcesz zamowic?");
                string zamowienie = Console.ReadLine();
                lista.Add(zamowienie);
                if(slownik.ContainsKey(zamowienie))
                {
                    slownik[zamowienie]++;
                }
                else
                {
                    slownik.Add(zamowienie, 1);
                }
            }
            else if(wybor == "2")
            {
                if(lista.Count == 0)
                {
                    Console.WriteLine("Brak zlozonych zamowien");
                }
                else
                {
                    Console.WriteLine("Zamowienia w kolejnosci zamawiania.");
                    foreach(var s in lista)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if(wybor == "3")
            {
                if(slownik.Count == 0)
                {
                    Console.WriteLine("Brak zlozonych zamowien");   
                }
                else
                {
                    foreach(var t in slownik)
                    {
                        Console.WriteLine($"{t.Key}, ilosc zamowionych: {t.Value}");
                    }
                }
            }
            else if(wybor == "4")
            {
                Console.WriteLine("Ktore zamowienie chcesz anulowac?");
                string usuwanie = Console.ReadLine();
                if(slownik.ContainsKey(usuwanie))
                {
                    lista.Remove(usuwanie);
                    slownik[usuwanie]--;
                    Console.WriteLine($"Usunieto pomyslnie: {usuwanie}");
                    if(slownik[usuwanie] <= 0)
                    {
                        slownik.Remove(usuwanie);
                    }
                }
                else
                {
                    Console.WriteLine("Takie zamowienie nie istnieje.");
                }
            }
            else if(wybor == "5")
            {
                Console.WriteLine("Do zobaczenia!");
                break;
            }
            else
            {
                Console.WriteLine("Wystapil blad. Sprobuj ponownie!");
            }
        }
    }
}
