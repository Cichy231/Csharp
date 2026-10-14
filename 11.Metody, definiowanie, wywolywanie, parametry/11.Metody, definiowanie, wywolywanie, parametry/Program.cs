using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _11.Metody__definiowanie__wywolywanie__parametry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Przywitaj(); // Wywołanie metody
            Powitaj("Kacper");

            WypiszOsobe("Anna", 20);
            // WypiszOsobe(20, "Adam"); To jest błąd ponieważ jest zła kolejność argumentów

            // Console.WriteLine(x); Zmienne w metodach są lokalne i nie istnieją poza nią


            WypiszNaglowek("Tytuł");


            WypiszMenu();
            
            
            WypiszLinie(10, 'a');
            Console.WriteLine();
            WypiszLinie(20, '*');
            Console.WriteLine();


            WypiszTabliczke(8);
            Console.WriteLine();
            WypiszTabliczke(4);


            WypiszTrojkat(5);
            Console.WriteLine();
            WypiszTrojkat(12);
        }

        // Żeby móc stworzyć statyczną (static) metodę trzeba wyjść z Main
        // Metody
        static void Przywitaj() // Utworzenie metody bez parametrów
        {
            Console.WriteLine("Cześć!");
            Console.WriteLine("Miło cię widzieć.");
        }

        static void Powitaj(string imie) // Utworzenie metody z parametrem
        {
            Console.WriteLine($"Cześć {imie}");
        }

        
        static void WypiszOsobe(string imie, int wiek) // Wiele parametrów
        {
            Console.WriteLine($"{imie} ma {wiek} lat");
        }

        static void Test()
        {
            int x = 5;
        }

        static void WypiszNaglowek(string tytul)
        {
            WypiszLinie(20); // Można wywoływać metodę z metody
            Console.WriteLine(tytul);
            WypiszLinie(20);
        }

        static void WypiszLinie(int dlugosc)
        {
            for (int i = 0; i < dlugosc; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        // ZADANIA
        // Zad 1
        static void WypiszMenu()
        {
            Console.WriteLine("KALKULATOR");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("0. Koniec");
        }
        

        // Zad 2
        static void WypiszLinie(int dlugosc, char znak)
        {
            for (int i = 1; i <= dlugosc; i++)
            {
                Console.Write(znak);
            }
        }


        // Zad 3
        static void WypiszTabliczke(int liczba)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * liczba);
            }
        }


        // Zad 4
        static void WypiszTrojkat(int wysokosc)
        {
            for (int i = 1; i <= wysokosc; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
