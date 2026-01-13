using System;
using System.Collections.Generic;

public class HelloWorld
{
    static double Zamiana(double cel)
    {
        return cel * 1.8 + 32;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj temperature w stopniach Celsjusza: ");
        double input = double.Parse(Console.ReadLine());
        double far = Zamiana(input);
        Console.WriteLine($"{far}F");
    }
}
