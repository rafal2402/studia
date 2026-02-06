using System;
using System.Collections.Generic;
using System.Linq;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Kodowanie polskich znaków
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        Dictionary<string, double> wydatki = new Dictionary<string, double>();
        
        // Nieskończona pętla (while true), dzięki której wraca się do menu po każdym działaniu
        while(true)
        {
            Console.WriteLine("KALKULATOR WYDATKÓW DOMOWYCH");
            Console.WriteLine("1. Dodaj wydatek.");
            Console.WriteLine("2. Wyświetl listę wydatków.");
            Console.WriteLine("3. Oblicz łączną kwotę wydatków.");
            Console.WriteLine("4. Znajdź największy wydatek.");
            Console.WriteLine("5. Wyjdź.");
            Console.Write("Wybierz opcję: ");
            
            string input = Console.ReadLine();
            
            // 1: DODAWANIE
            if(input == "1")
            {   
                Console.Write("Nazwa wydatku jaki chcesz dodać: ");
                string wydatek = Console.ReadLine();
                
                Console.Write("Kwota jaką chcesz przeznaczyć na ten wydatek: ");
                double kwota;
                
                // Walidacja danych:
                // !double.TryParse -> sprawdza, czy wpisano liczbę
                // || kwota < 0     -> sprawdza, czy liczba nie jest ujemna
                while(!double.TryParse(Console.ReadLine(), out kwota) || kwota < 0)
                {
                    Console.Write("Błąd! Wpisz poprawną, dodatnią kwotę: ");
                }

                // Sprawdzamy, czy wydatek o takiej nazwie już istnieje w słowniku
                if(wydatki.ContainsKey(wydatek))
                {
                    double obecnaKwota = wydatki[wydatek];
                    // :F2 oznacza formatowanie do 2 miejsc po przecinku
                    Console.WriteLine($"Taki wydatek już istnieje ({obecnaKwota:F2} zł). Dodaję nową kwotę.");
                    
                    // Jeśli wydatek istnieje, dodajemy nową kwotę do tej już zapisanej
                    wydatki[wydatek] += kwota;
                }
                else
                {
                    // Jeśli nie istnieje, tworzymy nowy wpis w słowniku
                    wydatki[wydatek] = kwota;
                    Console.WriteLine("Dodano nowy wydatek.");
                }
                Console.WriteLine("");
            }
            // 2: WYŚWIETLANIE LISTY
            else if(input == "2")
            {
                // Sprawdzamy, czy słownik jest pusty
                if(wydatki.Count == 0)
                {
                    Console.WriteLine("Brak dodanych wydatków.\n");
                }
                else
                {
                    Console.WriteLine("Twoja lista wydatków:");
                    // Pętla foreach przechodzi przez każdy element słownika
                    foreach(var item in wydatki)
                    {
                        // Wyświetlamy nazwę (Key) i wartość (Value) sformatowaną do 2 miejsc po przecinku
                        Console.WriteLine($"{item.Key}: {item.Value:F2} zł");
                    }
                    Console.WriteLine("");
                }  
            }
            // 3: SUMA WYDATKÓW
            else if(input == "3")
            {   
                // Sumujemy wszystkie wartości ze słownika
                double suma = wydatki.Values.Sum();
                Console.WriteLine($"Łączna kwota wydatków: {suma:F2} zł.\n");
            }
            // 4: NAJWIĘKSZY WYDATEK
            else if(input == "4")
            {
                if(wydatki.Count == 0)
                {
                    Console.WriteLine("Brak wydatków.\n");
                }
                else
                {
                    // 1. Znajdujemy największą liczbę w wartościach słownika
                    double wydatekMax = wydatki.Values.Max();
                    
                    // 2. Szukamy klucza (nazwy), który odpowiada tej wartości
                    string nazwaMax = "";
                    foreach (var item in wydatki) 
                    {
                        if (item.Value == wydatekMax) 
                        {
                            nazwaMax = item.Key;
                            break;
                        }
                    }
                    
                    Console.WriteLine($"Największy wydatek: {nazwaMax} ({wydatekMax:F2} zł).\n"); 
                }
            }
            // 5: WYJŚCIE
            else if(input == "5")
            {
                Console.WriteLine("Do zobaczenia!");
                break; // break przerywa pętlę while i kończy program
            }
            // --- BŁĘDNA OPCJA ---
            else
            {
                Console.WriteLine("Brak dostępnej opcji. Spróbuj ponownie!\n");
            }
        }
    }
}
