using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Witam na pokladzie!");
        Console.WriteLine("Podaj wysokosc: ");
        int wysokosc = int.Parse(Console.ReadLine());
        
        if (wysokosc > 1000)
        {   
            Console.WriteLine("Lecisz za wysoko!");
        }
        else if (wysokosc > 800 && wysokosc < 1000)
        {
            Console.WriteLine("Lecisz ok! Udanego lotu!");
        }
        else
        {
            Console.WriteLine("Lecisz za nisko!");
        }
    }
}
        
