// See https://aka.ms/new-console-template for more information
  Console.WriteLine("Hello, World!");

//Zadanie 111

//namespace Lab2.Model
//{
//    internal class Person
//    {
//        private string imie;
//        private string nazwisko;
//        private int wiek;
//        private string pesel;

//        public string Imie
//        {
//            get { return imie; }
//            set { imie = value; }
//        }

//        public string Nazwisko
//        {
//            get { return nazwisko; }
//            set { nazwisko = value; }
//        }

//        public int Wiek
//        {
//            get { return wiek; }
//            set
//            {
//                if (value < 0)
//                    wiek = 0;
//                else
//                    wiek = value;
//            }
//        }

//        public string Pesel => pesel;

    

//        public Person(string imie, string nazwisko, int wiek, string pesel)
//        {
//            this.imie = imie;
//            this.nazwisko = nazwisko;
//            Wiek = wiek; 
//            this.pesel = pesel;
//        }

//        public string PrzedstawSie()
//        {
//            return $"Nazywam się {imie} {nazwisko} i mam {wiek} lat.";
//        }
//    }
//}


// Zdanie 2222222

namespace Lab2.Model

    public class Licz (double val)
{
    private double value = val;

    public void Add(double value)
    { 
        this.value += value; 
    }
    public void DisplayValue()
    { 
        Console.Write(value);
    }
}

