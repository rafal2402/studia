using System;
using System.Collections.Generic;

public class HelloWorld
{
    static bool Podzielnosc(int a, int b)
    {
        if(b == 0)
            return false;
            
        return a % b == 0;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwsza liczbe");
        int pierwsza = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj druga liczbe. Jesli pierwsza liczba dzieli sie przez druga wyswietli sie true.");
        int druga = int.Parse(Console.ReadLine());
        bool wynik = Podzielnosc(pierwsza, druga);
        Console.WriteLine(wynik);
    }
}
