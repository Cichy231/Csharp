using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13.Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie tablic
            int[] oceny = new int[5]; // Utworzenie tablicy dla typu: int, rozmiar: 5 elementów
            string[] imiona = { "Anna", "Kasia", "Piotr" }; // Utworzenie tablicy z gotowymi wartościami
            // Indeksy liczymy od 0 a nie od 1
            Console.WriteLine(imiona[0]); // Wypisze pierwszy element
            imiona[1] = "Kamil"; // Zmiana drugiego elementu
            Console.WriteLine(imiona[1]); // Wypisze 6

            Console.WriteLine(imiona.Length); // Wypisze długość tablicy imiona: 3

            int[] wartosci = { 5, 4, 3, 5, 2 };
            for (int i = 0; i < wartosci.Length; i++)
            {
                Console.WriteLine($"Ocena {i + 1}: {wartosci[i]}"); // Wypisze wszystkie elementy tablicy
            }

            foreach (int wartosc in wartosci)
            {
                Console.WriteLine(wartosc); // Tak samo jak pętla for (tu czytelniej)
            }

            // OBLICZENIA NA TABLICACH

            // Suma i średnia
            int suma = 0;
            foreach (int wartosc in wartosci)
            {
                suma += wartosc;
            }
            double srednia = (double)suma / wartosci.Length;
            Console.WriteLine($"Średnia: {srednia:F2}");

            // Największa wartość
            int max = wartosci[0]; // Zakładamy, że pierwszy jest największy
            foreach (int wartosc in wartosci)
            {
                if (wartosc > max)
                {
                    max = wartosc;
                }
            }
            Console.WriteLine($"Największa: {max}");

            // Wyszukiwanie elementu
            int szukana = 3;
            bool znaleziono = false;
            
            foreach (int wartosc in wartosci)
            {
                if (wartosc == szukana)
                {
                    znaleziono = true;
                    break;
                }
            }
            Console.WriteLine(znaleziono ? "Jest" : "Nie ma");

            // Gotowe metody klasy Array
            int[] liczby = { 5, 2, 8, 1, 9 };
            Array.Sort(liczby); // Sortuje rosnąco
            Array.Reverse(liczby); // Odwraca kolejność
            int indeks = Array.IndexOf(liczby, 8); // Indeks wartości 8 (lub -1 gdy brak)


            // Tablice a typy referencyjne
            // Gdy przypiszesz jedną tablicę do drugiej to nie powstaje kopia, tylko obie zmienne wskazują na te same dane
            int[] a = { 1, 2, 3 };
            int[] b = a;
            b[0] = 99;

            int[] kopia = (int[])a.Clone(); // To jest utworzenie prawdziwej kopii

            // Tablice a metody
            Console.WriteLine(Srednia(liczby)); // Wypisze 5


            // Tablice dwuwymiarowe
            int[,] plansza = new int[3, 3];
            plansza[0, 0] = 1;
            plansza[1, 2] = 5;
            for(int w = 0; w < 3; w++)
            {
                for(int k = 0; k < 3; k++)
                {
                    Console.WriteLine($"{plansza[w, k]} ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine();


            // ZADANIA
            // Zad 1
            int[] tablica = new int[5];
            int sumaTablicy = 0;
            double sredniaTablicy = 0;
            for (int i = 1; i <= 5; i++) 
            {
                Console.Write($"Podaj {i} liczbę do tablicy: ");
                tablica[i - 1] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(tablica);
            Console.Write("Tablica w odwrotnej kolejności: ");
            foreach (int tab in tablica)
            {
                Console.Write(tab + " ");
                sumaTablicy += tab;
            }
            Console.WriteLine();
            sredniaTablicy = (double)sumaTablicy / tablica.Length;
            Console.WriteLine($"Suma liczb tablicy wynosi: {sumaTablicy} a średnia: {sredniaTablicy}");


            Console.WriteLine();
            Console.WriteLine();


            // Zad 2
            Console.Write("Podaj długość tablicy: ");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tablicaZad2 = new int[dlugosc];
            for (int i = 0; i < tablicaZad2.Length; i++)
            {
                Console.Write($"Podaj wartość dla {i + 1} elementu: ");
                tablicaZad2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Największa liczba wynosi: " + Najwieksza(tablicaZad2));
            Console.WriteLine("Najmniejsza liczba wynosi: " + Najmniejsza(tablicaZad2));

            Console.WriteLine();


            // Zad 3 
            int[] tablicaZad3 = { 3, 8, 12, 7, 4, 1 };
            Console.WriteLine($"W tej tablicy występuje: " + PoliczParzyste(tablicaZad3) + " liczby parzystych");
        }

        // Tablice a metody
        static double Srednia(int[] liczby)
        {
            int suma = 0;
            foreach (int x  in liczby)
            {
                suma += x;
            }
            return (double)suma / liczby.Length;
        }

        // Zad 2
        static int Najwieksza(int[] t)
        {
            int najwieksza = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > najwieksza)
                {
                    najwieksza = t[i];
                }
            }
            return najwieksza;
        }
        static int Najmniejsza(int[] t)
        {
            int najmniejsza = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < najmniejsza)
                {
                    najmniejsza = t[i];
                }
            }
            return najmniejsza;
        }

        // Zad 3
        static int PoliczParzyste(int[] t)
        {
            int licznik = 0;
            foreach (int x in t)
            {
                if (x % 2 == 0)
                {
                    licznik++;
                }
            }
            return licznik;
        }
    }
}
