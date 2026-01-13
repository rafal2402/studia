using System;
public class HelloWorld
{

    
    public static void Main(string[] args)
    {
        Console.WriteLine ("Podaj liczbe n.");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;
        
        for(int i = 0; i < n + 1; i++)
        {
            suma += i;
            
        }
        Console.WriteLine($"Suma wynosi {suma}");
    }
}
