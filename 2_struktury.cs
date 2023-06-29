using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_struktury
{
    internal class Program
    {
        public struct Student
        {
            public int NumerIndeksu;
            public string Imie;
            public string Nazwisko;
            public string Kierunek;
            public string RokStudiow;
        }

        public struct Przedmiot
        {
            public int PrzedmiotID;
            public string Nazwa;
            public string Opis;
            public string RodzajZajec;
            public string FormaZaliczenia;
            public int ECTS;
        }

        public struct NauczycielAkademicki
        {
            public int NauczycielID;
            public string Imie;
            public string Nazwisko;
            public string Tytul;
            public string Wydzial;
        }

        static void Main(string[] args)
        {
        
        }
    }
}
