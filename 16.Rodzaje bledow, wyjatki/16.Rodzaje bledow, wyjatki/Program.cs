using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Rodzaje_bledow__wyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RODZAJE BŁĘDÓW
            // 1. Błędy Kompilacji
            // int liczba = "tekst";    // Zły typ
            // Console.WriteLine(x);    // Zmienna nie istnieje
            // Console.WriteLine("a")   // Brak średnika

            // 2. Błędy wykonania (wyjątki)
            int a = 10;
            int b = 0;
            // Console.WriteLine(a / b);   // Dzielenie przez zero

            // 3. Błędy logiczne
            double srednia = (a + b) / 2;   // Dla int dzielenie całkowite ucina ułamek
            int wiek = 12;
            if (wiek > 18) { }      // Powinno być >=, 18-latek jest pominięty

            // Co to wyjątki
            Console.WriteLine("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine()); // Wpisanie 'abc' da wyjątek, jeśli nie zostanie obsłużony program się kończy


            // Najsłynniejszy błąd
            string imie = null;
            Console.WriteLine(imie.Length); // Wyjątek 'NullReferenceException'
        }
    }
}
