using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_studenci
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;

        public void WyswietlInformacje()
        {
            Console.WriteLine("Student: " + Nazwisko + ", Nr albumu: " + NrAlbumu + ", Ocena: " + Ocena + ", Płeć: " + Plec);
        }
    }

    class Program
    {
        static void DaneStudenta(ref Student student)
        {
            Console.WriteLine("Podaj nazwisko studenta:");
            student.Nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj numer albumu:");
            student.NrAlbumu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ocenę:");
            double ocena = Convert.ToDouble(Console.ReadLine());

            if (ocena < 2.0)
                student.Ocena = 2.0;
            else if (ocena > 5.0)
                student.Ocena = 5.0;
            else
                student.Ocena = ocena;

            int plec;

            do
            {
                Console.WriteLine("Podaj płeć (0 - Mężczyzna, 1 - Kobieta):");
                bool isValid = int.TryParse(Console.ReadLine(), out plec);

                if (isValid && (plec == 0 || plec == 1))
                {
                    break; // Poprawna wartość, przerywamy pętlę
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość. Podaj 0 lub 1.");
                }
            } while (true);

            if (plec == 0)
            {
                student.Plec = Plec.Mezczyzna;
            }
            else if (plec == 1)
            {
                student.Plec = Plec.Kobieta;
            }

        }

        static double ObliczSrednia(Student[] grupa)
        {
            double suma = 0;

            foreach (Student student in grupa)
            {
                suma += student.Ocena;
            }

            return suma / grupa.Length;
        }

        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            for (int i = 0; i < grupa.Length; i++)
            {
                Console.WriteLine("Wprowadzanie danych studenta " + (i + 1));
                DaneStudenta(ref grupa[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Studenci w grupie:");

            foreach (Student student in grupa)
            {
                student.WyswietlInformacje();
            }

            double sredniaOcen = ObliczSrednia(grupa);
            Console.WriteLine("Średnia ocen w grupie: " + sredniaOcen);

            Console.ReadKey();
        }
    }
}
