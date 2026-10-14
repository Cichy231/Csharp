using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operatory_i_konwersje_typow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // OPERATORY ARYTMETYCZNE
            int liczba_a = 7;
            int liczba_b = 3;
            Console.WriteLine(liczba_a + liczba_b); // 10
            Console.WriteLine(liczba_a - liczba_b); // 4
            Console.WriteLine(liczba_a * liczba_b); // 21
            Console.WriteLine(liczba_a / liczba_b); // 2
            Console.WriteLine(liczba_a % liczba_b); // 1

            // DZIELENIE CAŁKOWITE
            // Gdy dzielimy 2 inty wynik też jest int
            Console.WriteLine(7 / 3); // 2 a nie 2.33
            Console.WriteLine(9 / 10); // 0 a nie 0.9

            // Jeśli choć jedna liczba jest double wynik jest double
            Console.WriteLine(7.0 / 3); // 2.33333
            Console.WriteLine(7 / 3.0); // Też 2.3333


            int zmienna = 0;
            zmienna++; // Inkrementacja
            zmienna--; // Dekrementacja

            // OPERATORY LOGICZNE
            // && TO AND (oba muszą być spełnione)
            // || TO OR (wystarczy jeden spełniony)
            // ! Odwraca wartość (true na false)
            int wiek = 20;
            bool maPrawoJazdy = false;

            Console.WriteLine(wiek >= 18 && maPrawoJazdy);   // False (drugi warunek nie jest spełniony)
            Console.WriteLine(wiek >= 18 || maPrawoJazdy);   // True (pierwszy jest spełniony)
            Console.WriteLine(!maPrawoJazdy);                // True (odwrócone false)

            // KONWENCJE TYPÓW

            // Konwencja Niejawna (mniejszy typ na większy)
            int liczba = 100;
            long duza = liczba; // OK; int mieści się w long
            double ulamek = liczba; // OK; int mieści się w double

            // Konwencja Jawna (kiedy można stracić dane)
            double cena = 19.99;
            int zaokraglona = (int)cena; // 19, część ułamkowa jest ODCIĘTA

            // Konwersja teksu na liczbę
            string tekst = "42";
            int liczbaTekstu = int.Parse(tekst);

            // Konwersja dowolnej wartości na tekst
            int liczbaDoTekstu = 50;
            string tekstLiczby = liczba.ToString(); // "42"


            Console.WriteLine();
            
            // ZADANIA 

            // Zad 1
            int a = 17;
            int b = 5;
            Console.WriteLine($"{a} + {b} = {a + b}"); // 22
            Console.WriteLine($"{a} - {b} = {a - b}"); // 12
            Console.WriteLine($"{a} * {b} = {a * b}"); // 85
            Console.WriteLine($"{a} / {b} = {a / b}"); // 3
            Console.WriteLine($"{a} % {b} = {a % b}"); // 2

            Console.WriteLine();
            
            // Zad 2
            int x = 9;
            int y = 2;
            Console.WriteLine(x/y); // 4
            Console.WriteLine((double)x / y); // 4.5

            Console.WriteLine();

            // Zad 3
            int sekundy = 3725;
            int godziny = sekundy / (60 * 60);
            int resztaGodzin = sekundy % (60 * 60);
            int minuty = resztaGodzin / 60;
            int liczbaSekund = resztaGodzin % 60;
            Console.WriteLine($"{godziny} godz. {minuty} min {liczbaSekund} s"); // 1 godz 2 min 5 s;

            Console.WriteLine();

            // Zad 4
            int licznik = 10;
            licznik += 5;
            licznik *= 2;
            licznik -= 3;
            licznik++;
            Console.WriteLine(licznik); // 28

            Console.WriteLine();

            // Zad 5
            double temperaturaC = 36.6;
            double temperaturaF = temperaturaC * 9 / 5 + 32;
            Console.WriteLine(temperaturaF); // 97.88
            Console.WriteLine((int)temperaturaF); // 97
        }
    }
}
