// ZADANIE 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private string imie;
    private int wiek;
    private string kierunek;
    
    public Student(string imie, string kierunek)
    {
        this.imie = imie;
        this.kierunek = kierunek;
    }
    
    public int Wiek
    {
        get { return wiek; }
        set 
        {
            if(value < 0)
            {
                Console.WriteLine("Wiek nie moze byc ujemny.");
            }
            else
            {
                wiek = value;
            }
            
        }
    }
    
    public override string ToString()
    {
        return $"Imię: {imie}, wiek: {wiek}, kierunek: {kierunek}";
    }
}

class Super_student : Student
{
    private int stypendium;
    private List <string> zainteresowania;
    
    public Super_student(string imie, string kierunek, int stypendium) : base(imie, kierunek)
    {
        this.stypendium = stypendium;
        Console.WriteLine("Zainteresowania naukowe: ");
        zainteresowania = new List<string>();
    }
    
    public void dodajZainteresowania(string dodawanie)
    {
        zainteresowania.Add(dodawanie);
    }
    
    public List<string> pobierzZainteresowania()
    {
        return zainteresowania;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        
        Student st1 = new Student("Rafał", "Informatyka");
        st1.Wiek = 22;
        Console.WriteLine(st1.ToString());
        
        Super_student st2 = new Super_student("Paulina", "Chemia", 200);
        st2.Wiek = 24;
        List<string> zaintersowania = new List<string>();
        st2.dodajZainteresowania("Zabawa z kotami");
        st2.dodajZainteresowania("Kodowanie");
        st2.dodajZainteresowania("Granie w farmę");
        zainteresowania = st2.pobierzZaintersowania();
        foreach(var i in zainteresowania)
            Console.WriteLine(i);
        
    }
}
