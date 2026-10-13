using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Pętle_for_i_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pętla while
            int licznik = 1;
            while (licznik <= 5)
            {
                Console.WriteLine(licznik);
                licznik++; // Musi być inkrementacja, ponieważ pętla była by nieskończona
            }

            Console.WriteLine();

            // Pętla while jest dobra kiedy nie wiemy ile będzie powtórzeń
            Console.Write("Podaj liczbę dodatnią: ");
            int liczba = int.Parse(Console.ReadLine());
            while (liczba <= 0)
            {
                Console.Write("To nie jest liczba dodatnia: Spróbuj jeszcze raz: ");
                liczba = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Podałeś: {liczba}");

            Console.WriteLine();


            // Pętla for (kiedy wiemy ile będzie powtórzeń)
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.Write("Ile razy powtórzyć? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Cześć!");
            }

            Console.WriteLine();


            // Pętle zagnieżdżone
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {                                     // 1     2     3
                    Console.Write($"{i * j}\t");      // 4     5     6
                                                      // 7     8     9
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // ZADANIA
            // Zad 1
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i}  ");
            }

            Console.WriteLine();


            // Zad 2
            for (int i = 2; i <= 50; i += 2)
            {
                Console.Write($"{i}  ");
            }

            Console.WriteLine();


            // Zad 3
            Console.Write("Podaj jakąś liczbę: ");
            int koniec = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= koniec; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Suma od 1 do {koniec} wynosi {suma}");

            Console.WriteLine();


            // Zad 4
            Console.WriteLine("Podaj liczbe (silnia): ");
            int liczbaSilnia = int.Parse(Console.ReadLine());
            long silnia = 1;
            for (int i = 1; i <= liczbaSilnia; i++)
            {
                silnia *= i;
            }
            Console.WriteLine($"Silnia z {liczbaSilnia} wynosi {silnia}");

            Console.WriteLine();


            // Zad 5
            Console.Write("Wpisz liczbę: ");
            int liczbaTabliczka = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {liczbaTabliczka} = {i * liczbaTabliczka}");
            }

            Console.WriteLine();


            // Zad 6
            Console.Write("Podaj jakąś liczba: ");
            int wpisana = int.Parse(Console.ReadLine());
            while (wpisana < 1 || wpisana > 10)
            {
                Console.Write("Podana liczba jest spoza zakresu 1- 10. Spróbuj ponownie: ");
                wpisana = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Wpisana liczba mieści się w zakresie");

            Console.WriteLine();


            // Zad 7
            Console.Write("Wpisz liczbe(*): ");
            int gwiazdki = int.Parse(Console.ReadLine());
            for (int i = 1; i <= gwiazdki; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            // Zad 8
            Console.Write("Podaj liczbe (0 = koniec): ");
            int napisana = int.Parse(Console.ReadLine());
            int iteracja = 0;
            int srednia = 0;
            while (napisana != 0)
            {
                iteracja++;
                srednia += napisana;
                Console.Write("Podaj następną liczbę: ");
                napisana = int.Parse(Console.ReadLine());
            }

            if (iteracja == 0)
            {
                Console.WriteLine("Nie podano żadnych liczb (od razu wpisano 0).");
            }
            else
            {
                Console.WriteLine($"Podano łącznie liczb: {iteracja}");
                Console.WriteLine($"Średnia wynosi: {srednia / iteracja:F2}");
            }

        }
    }
}
