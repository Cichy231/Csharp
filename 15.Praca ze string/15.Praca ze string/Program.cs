using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Praca_ze_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tekst jest niezmienny, żadna metoda nie zmienia istniejącego tekstu, tylko zwraca nowy, trzeba go gdzieś zapisać
            string imie = "anna";
            imie.ToUpper(); // Wynik przepada, imie to nadal "anna"
            imie = imie.ToUpper(); // Teraz imie to "ANNA"

            string slowo = "Kotek";
            Console.WriteLine(slowo[0]);     // K
            Console.WriteLine(slowo.Length); // 5

            // Zmiana wielkości liter i białe znaki
            string t = "   Hello World   ";
            t.ToUpper();   // "   HELLO WORLD   "
            t.ToLower();   // "   hello world   "
            t.Trim();      // "Hello World" (usuwa spacje z obu końców)
            t.TrimStart(); // "Hello World   " 
            t.TrimEnd();   // "   Hello World"

            // Wyszukiwanie
            string zdanie = "Ala ma kota, kot ma Alę";
            zdanie.Contains("kot");     // true
            zdanie.StartsWith("Ala");   // true
            zdanie.EndsWith("Alę");     // true
            zdanie.IndexOf("kot");      // 7 (indeks pierwszego wystąpienia, -1 gdy brak)
            zdanie.LastIndexOf("kot");  // 16 (ostatnie wystąpienie)

            // Wycinanie, zmiana, usuwanie
            string z = "Programowanie";
            z.Substring(3);         // "gramowanie" (od indeksu 3 do końca)
            z.Substring(0, 7);      // "Program" (od indeksu 0, długość 7)
            z.Replace("a", "A");    // "ProgrAmowAnie" (zamienia wszystkie wystąpienia)
            t.Remove(7);            // "Program" (usuwa od indeksu 7 do końca)
            t.Insert(0, "Nauka: "); // "Nauka: Programowanie"

            // Dzielenie i łączenie
            string dane = "Anna,25,Warszawa";
            string[] czesci = dane.Split(',');

            Console.WriteLine(czesci[0]); // Anna
            Console.WriteLine(czesci[1]); // 25
            Console.WriteLine(czesci[2]); // Warszawa

            string[] slowa = "Ala ma kota".Split(' ');
            Console.WriteLine(slowa.Length); // 3

            string[] slowaDoSklejenia = { "Ala", "ma", "kota" };
            string zdanieSklejone = string.Join(" ", slowaDoSklejenia); // "Ala ma kota"
            string lista = string.Join(", ", slowaDoSklejenia);         // "Ala, ma, kota"

            // Formatowanie i interpolacja
            double cena = 19.5;
            int ilosc = 3;

            Console.WriteLine($"Razem: {cena * ilosc:F2} zł");  // Wyrażenie w klamrach
            Console.WriteLine($"Cena: {cena,10:F2}");           // Wyrównanie do prawej, szerokość 10
            Console.WriteLine($"Cena: {cena,-10:F2}|");         // Wyrówanie do lewej

            Console.WriteLine($"{"Produkt",-12}{"Cena",8}");
            Console.WriteLine($"{"Chleb",-12}{4.5,8:F2}");
            Console.WriteLine($"{"Mleko",-12}{3.2,8:F2}");

            string sciezka = @"C:\Users\Anna\plik.txt"; // @ = tekst dosłowny (bez podwójnych ukośników

            // Klasa char
            char l = 'a';
            char.IsLetter(l);       // true
            char.IsDigit('5');      // true
            char.IsUpper('A');      // true
            char.IsWhiteSpace(' '); // true
            char.ToUpper(l);        // 'A'
        }
    }
}
