using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RPG
{
    using System;

    namespace RPG
    {
        enum KlasaRzadkosci
        {
            Powszechny,
            Rzadki,
            Unikalny,
            Epicki
        }

        enum TypPrzedmiotu
        {
            Bron,
            Zbroja,
            Amulet,
            Pierscien,
            Helm,
            Tarcza,
            Buty
        }

        struct Przedmiot
        {
            public float Waga;
            public int Wartosc;
            public KlasaRzadkosci Rzadkosc;
            public TypPrzedmiotu Typ;
            public string NazwaWlasna;

            public void WyswietlInformacje()
            {
                Console.WriteLine("Przedmiot: " + NazwaWlasna);
                Console.WriteLine("Typ: " + Typ);
                Console.WriteLine("Rzadkosc: " + Rzadkosc);
                Console.WriteLine("Waga: " + Waga);
                Console.WriteLine("Wartosc: " + Wartosc + " szt. złota");
                Console.WriteLine();
            }
        }

        class Program
        {
            static Random random = new Random();

            static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
            {
                int index = random.Next(0, przedmioty.Length);
                return przedmioty[index];
            }

            static void Main(string[] args)
            {
                Przedmiot[] przedmioty = new Przedmiot[5];
                przedmioty[0] = new Przedmiot { Waga = 1.5f, Wartosc = 200, Rzadkosc = KlasaRzadkosci.Unikalny, Typ = TypPrzedmiotu.Bron, NazwaWlasna = "Excalibur" };
                przedmioty[1] = new Przedmiot { Waga = 2.0f, Wartosc = 150, Rzadkosc = KlasaRzadkosci.Epicki, Typ = TypPrzedmiotu.Zbroja, NazwaWlasna = "Zbroja Herkulesa Maksymiliana II" };
                przedmioty[2] = new Przedmiot { Waga = 0.5f, Wartosc = 50, Rzadkosc = KlasaRzadkosci.Rzadki, Typ = TypPrzedmiotu.Amulet, NazwaWlasna = "Amulet mądrości" };
                przedmioty[3] = new Przedmiot { Waga = 0.3f, Wartosc = 10, Rzadkosc = KlasaRzadkosci.Powszechny, Typ = TypPrzedmiotu.Pierscien, NazwaWlasna = "Pierścień mocy" };
                przedmioty[4] = new Przedmiot { Waga = 1.2f, Wartosc = 100, Rzadkosc = KlasaRzadkosci.Epicki, Typ = TypPrzedmiotu.Helm, NazwaWlasna = "Hełm koryncki" };

                Przedmiot wylosowanyPrzedmiot = LosujPrzedmiot(przedmioty);

                Console.WriteLine("Wylosowany przedmiot:");
                wylosowanyPrzedmiot.WyswietlInformacje();

                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                Console.ReadKey();
            }
        }
    }

}
