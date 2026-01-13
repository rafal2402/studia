using System;
using System.Collections.Generic;

public class HelloWorld
{
    static bool Pelnoletnosc(int wiek)
    {
        return wiek >= 18;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wiek: ");
        int wiek = int.Parse(Console.ReadLine());
        
        bool pelnoletni = Pelnoletnosc(wiek);
        Console.WriteLine(pelnoletni);
    }
 }
