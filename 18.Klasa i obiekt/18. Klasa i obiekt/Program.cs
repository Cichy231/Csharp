using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Klasa_i_obiekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektów
            Osoba anna = new Osoba(); // Utworzenie nowego obiektu
            anna.Imie = "Anna";
            anna.Wiek = 25;
            anna.Przedstaw(); // Cześć, jestem Anna i mam 25 lat
            Console.WriteLine(anna.CzyPelnoletnia()); // True

            Osoba piotr = new Osoba();
            piotr.Imie = "Piotr";
            piotr.Wiek = 31;

            Console.WriteLine($"{anna.Imie} ma {anna.Wiek} lat");
            Console.WriteLine($"{piotr.Imie} ma {piotr.Wiek} lat");

            // Obiekty można trzymać w listach
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba { Imie = "Jan", Wiek = 18 });
            osoby.Add(new Osoba { Imie = "Kasia", Wiek = 22 });

            foreach(Osoba o in osoby)
            {
                o.Przedstaw();
            }

            // ZADANIA
            // Zad 1
            List<Ksiazka> ksiazki = new List<Ksiazka>();
            ksiazki.Add(new Ksiazka { Tytul = "Pan Tadeusz", Autor = "Adam Mickiewicz", LiczbaStron = 400 });
            ksiazki.Add(new Ksiazka { Tytul = "Zbrodnia i kara", Autor = "Fiodor Dostojewski", LiczbaStron = 200 });
            ksiazki.Add(new Ksiazka { Tytul = "Lalka", Autor = "Bolesław Prus", LiczbaStron = 300 });
            foreach(Ksiazka k in ksiazki)
            {
                k.Wypisz();
            }

            // Zad 2
            Prostokat prostokat1 = new Prostokat();
            prostokat1.Szerokosc = 10;
            prostokat1.Wysokosc = 8;
            Console.WriteLine(prostokat1.Pole());
            Console.WriteLine(prostokat1.Obwod());

            Prostokat prostokat2 = new Prostokat();
            prostokat2.Szerokosc = 15;
            prostokat2.Wysokosc = 6;
            Console.WriteLine(prostokat2.Pole());
            Console.WriteLine(prostokat2.Obwod());
        }

        class Osoba // Deklaracja klasy / (Osoba) - Nazwa klasy
        {
            public string Imie; // Pole czyli zmienna należąca do obiektu
            public int Wiek;

            // Metody
            public void Przedstaw()
            {
                Console.WriteLine($"Cześć, jestem {Imie} i mam {Wiek} lat.");
            }

            public bool CzyPelnoletnia()
            {
                return Wiek >= 18;
            }
        }

        // ZADANIA
        // Zad 1
        class Ksiazka
        {
            public string Tytul;
            public string Autor;
            public int LiczbaStron;

            public void Wypisz()
            {
                Console.WriteLine($"{Tytul} napisana przez {Autor}, ma {LiczbaStron} stron");
            }
        }

        // Zad 2
        class Prostokat
        {
            public int Szerokosc;
            public int Wysokosc;

            public double Pole()
            {
                return Szerokosc * Wysokosc;
            }

            public double Obwod()
            {
                return (2 * Szerokosc) + (2 * Wysokosc);
            }
        }
    }
}
