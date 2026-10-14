using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _04.Wejscie_i_wyjscie_w_konsoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Znaki specjalne
            Console.WriteLine("Linia 1\nLinia 2"); // Każde w nowej linii
            Console.WriteLine("Imię:\t Anna"); // tabulator, większy odstęp
            Console.WriteLine("Powiedział: \"Cześć\""); // Pozwala na cudzysłow w stringu
            Console.WriteLine("Ścieżka: C:\\Users\\Anna"); // Zwykły ukośnik

            Console.WriteLine();
            
            // Wejście: ReadLine
            Console.Write("Podaj imię: ");
            string Imie = Console.ReadLine();
            Console.WriteLine($"Cześć, {Imie}"); // Wyświetli podane przez użytkownika imię

            Console.WriteLine();

            // Wczytywanie liczb
            Console.WriteLine("Podaj wiek: ");
            string tekst = Console.ReadLine();
            int wiek = int.Parse(tekst);
            Console.WriteLine($"Za rok będziesz mieć {wiek + 1} lat");

            Console.WriteLine();

            // Formatowanie wyniku
            double wynik = 10.0 / 3;
            Console.WriteLine($"Wynik: {wynik}"); // 3,3333333
            Console.WriteLine($"Wynik: {wynik:F2}"); // 3,33

            // FORMATY
            // F2 - 2 miejsca po przecinku
            // F0 - Brak miejsc po przecinku
            // C - Waluta (według ustawień systemu) np: 19,99 zł
            // N0 - Liczba z separatorami tysięcy, np: 1 234 567
            // P0 - Procent (0.25 -> 25%)

            Console.WriteLine();

            // Przydatne polecenia
            // Console.Clear();  Czyści okno konsoli
            // Console.ReadKey();  Czeka na naciśniecie dowolnego przycisku
            // Console.Title = "Mój program"; Ustawia tytuł okna

            Console.ForegroundColor = ConsoleColor.Green; // Zmiana koloru czciomki na zielony
            Console.WriteLine("Zielony tekst");
            Console.ResetColor(); // Wraca do domyślnych ustawień

            Console.WriteLine();

            // ZADANIA
            // Zad 1
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.Write("Napisz z jakiego jesteś miasta: ");
            string miasto = Console.ReadLine();
            Console.WriteLine($"Cześć {imie} z {miasto}");

            Console.WriteLine();

            // Zad 2
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba_a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę całkowitą: ");
            int liczba_b = int.Parse(Console.ReadLine());
            Console.WriteLine(liczba_a + liczba_b);
            Console.WriteLine(liczba_a - liczba_b);
            Console.WriteLine(liczba_a * liczba_b);
            Console.WriteLine(liczba_a / liczba_b);
            Console.WriteLine(liczba_a % liczba_b);

            Console.WriteLine();

            // Zad 3
            Console.Write("Podaj promień koła: ");
            double promien = double.Parse(Console.ReadLine());
            const double Pi = 3.14159;
            double obwod = 2 * Pi * promien;
            double pole = Pi * promien * promien;
            Console.WriteLine($"Pole koła wynosi: {pole:F2}");
            Console.WriteLine($"Obwód koła wynosi: {obwod:F2}");

            Console.WriteLine();

            // Zad 4
            Console.Write("Podaj cene produktu: ");
            decimal cena = decimal.Parse(Console.ReadLine());
            Console.Write("Podaj ilość sztuk: ");
            int sztuki = int.Parse(Console.ReadLine());
            decimal wszystko = cena * sztuki;
            Console.WriteLine($"Całkowita cena to: {wszystko:C}");

            Console.WriteLine();

            // Zad 5
            Console.Write("Napisz coś(może być liczba): ");
            if (int.TryParse(Console.ReadLine(), out int wpisane))
            {
                Console.WriteLine(wpisane * wpisane);
            } else
            {
                Console.WriteLine("To nie jest poprawna liczba");
            }
        }
    }
}
