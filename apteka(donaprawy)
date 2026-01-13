using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] stan = {2, 3, 10, 12, 4, 17, 26, 55, 78, 3};
        int[] minimum = {10, 10, 5, 10, 5, 10, 10, 5, 10, 5};
        int[] cena = {100, 12, 2, 30, 45, 10, 10, 15, 6, 50};
        int do_dokupienia;
        int koszt;
        int suma_kosztow = 0;
        int suma_lekow = 0;
        int maksymalny_koszt = 0;
        
        for (int i = 0; i < 10; i++)
        { 
            if (stan[i] < minimum[i])
            {
                Console.WriteLine($"Leku o nr ID {i} jest za malo");
                do_dokupienia = minimum[i] - stan[i];
                koszt = do_dokupienia * cena[i];
                Console.WriteLine($"Trzeba dokupic {do_dokupienia} koszt tego {koszt}");
                suma_kosztow += koszt;
                suma_lekow += do_dokupienia;
            
                if(koszt > maksymalny_koszt)
                {
                    maksymalny_koszt = koszt;
                }
                Console.WriteLine($"{maksymalny_koszt}");
            }    
        }   
    }   
}
