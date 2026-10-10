using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Zmienne_i_typy_danych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wiek; // Deklaracja
            wiek = 20; // Przupisanie wartości
            int liczbaLat = 30; // Deklaracja i przypisanie wartości (inicjalizacja)

            // Liczby całkowite
            byte calkowita_byte; // 0 do 255
            int calkowita_int; // od -2,147,483,648 do 2,147,483,647
            long calkowita_long; // ok. 9.2 * 10^18
            long populacjaZiemi = 8_000_000_000; // Nie mieści się w int, można używać podkreślenia dla czytelności

            // Liczby z częścią ułamkową
            double liczba_double = 1.78; // 15-17 cyfr, domyślny wybór dla liczb ułamkowych
            float liczba_float = 1.78f; // 6-9 cyfr, wymaga litery f na końcu
            decimal liczba_decimal = 1.78m; // 28-29 cyfr, wymaga litery m na końcu, bardzo dokładny

            // Wartości logiczne
            bool wartoscBool = true; // true lub false
            bool czyPada = false;

            // Znak
            char ocena = 'A';

            // Tekst
            string imie = "Jan";
            string pusty = ""; // pusty tekst

            // WYPISYWANIE ZMIENNYCH
            Console.WriteLine(wiek); // Wypisze: 20

            // Sklejanie operatorem +
            Console.WriteLine("Cześć " + imie + "!"); // Cześć Jan!

            // Interpolacja
            Console.WriteLine($"Mam {wiek} lat."); // Mam 20 lat.

            // Słowo var
            var cos = 20; // Kompilator wie, że to int
            var cosInnego = "Tekst"; // To string
            var cosJeszczeInnego = 1.78; // A to double

            // STAŁE
            const double PI = 3.14159; // Nie można już później zmienić tej wartości

            // Zad 1
            string mojeImie = "Cichy";
            int mojWiek = 17;
            double mojWzrost = 1.72;
            bool czyLubisz = true;
            Console.WriteLine($"Imie: {mojeImie}, Wiek: {mojWiek}, Wzrost: {mojWzrost}, Czy lubisz programowanie: {czyLubisz}");

            // Zad 2
            int punkty = 100;
            punkty = punkty + 50;
            punkty = punkty - 30;
            Console.WriteLine(punkty);

            // Zad 3
            decimal cenaChleba = 4.50m;
            decimal cenaMasla = 7.80m;
            decimal cenaMleka = 3.20m;
            decimal suma = cenaChleba + cenaMasla + cenaMleka;
            Console.WriteLine(suma);

            // Zad 4
            const double Pi = 3.14159;
            double promien = 5;
            double pole = Pi * promien * promien;
            Console.WriteLine(pole);

            // Zad 5
            char ulubiona = 'J';
            string slowo = "Moja ulubiona liczba to: ";
            Console.WriteLine($"{slowo}{ulubiona}");
        }
    }
}
