using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Wartosci_zwracane_i_przeciazanie_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wynik = Dodaj(3, 4); // Wywołanie funkcji można przypisać do zmiennej
            Console.WriteLine(wynik); // 7
            Console.WriteLine(Dodaj(10, 20)); // 30, tak też można wypisać wynik


            // Wczytywanie danych 
            int wiek = WczytajLiczbe("Podaj wiek: ");
            int rok = WczytajLiczbe("Podaj rok urodzenia: ");


            // Przeciążane metod
            Console.WriteLine(Iloczyn(2, 3));       
            Console.WriteLine(Iloczyn(2.5, 4.5)); // Kompilator sam wybiera wersje na podstawie argumentów
            Console.WriteLine(Iloczyn(2, 3, 4));


            // Parametry opcjonalne
            Przywitaj("Anna"); // Cześć Anna
            Przywitaj("Adam", "Witaj"); // Witaj Adam


            // Zwracanie kilku wartości
            var kilka = MinMax(8, 3);
            Console.WriteLine($"Min: {kilka.min}, Max: {kilka.max}");

            // Zad 1
            Console.WriteLine("Liczby pierwsze od 2 do 100:");
            for (int i = 2; i <= 100; i++)
            {
                if (CzyPierwsza(i))
                {
                    Console.WriteLine($"{i} ");
                }
            }
            Console.WriteLine();

            // Zad 2
            Console.WriteLine(Silnia(WczytajLiczbeSilnia("Podaj liczbę: ")));

            Console.WriteLine();

            // Zad 3
            Console.WriteLine(Najwiekszy(4, 5));
            Console.WriteLine(Najwiekszy(4, 5, 6));
            Console.WriteLine(Najwiekszy(4.5, 5.5));
        }
        
        // WARTOŚĆ ZWRACANA
        static int Dodaj(int a, int b)
        {
            int suma = a + b;
            return suma; // Można też skrócić i od razu napisać w return a + b
            // return kończy funkcje, wszystko co jest pod nim się nie wykona
            // return musi być w każdej możliwej sytuacji, sytuacje warunkowe (if)
        }

        static int Roznica(int a, int b) => a - b; // Zapis jeszcze bardziej skrócony (strzałkowy), działa tak jak funkcja powyżej

        static void Dziel(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero.");
                return;  // W void też można użyć return aby wcześnij skończyć działanie
            }
            Console.WriteLine(a / b);
        }


        // METODA WCZYTUJĄCA DANE
        static int WczytajLiczbe(string pytanie) 
        {
            while(true)
            {
                Console.Write(pytanie);
                if(int.TryParse(Console.ReadLine(), out int liczba))
                {
                    return liczba;
                }
                Console.WriteLine("To nie jest poprawna liczba, spróbuj jeszcze raz.");
            }
        }


        // PRZECIĄŻANIE METOD
        // Kilka metod o tej samej nazwie z różnymi parametrami
        static int Iloczyn(int a, int b)
        {
            return a * b;
        }
        static double Iloczyn(double a, double b)
        {
            return a * b;
        }
        static int Iloczyn(int a, int b, int c)
        {
            return a * b * c;
        }


        // PARAMETRY OPCJONALNE
        static void Przywitaj(string imie, string powitanie = "Cześć")
        {
            Console.WriteLine($"{powitanie}, {imie}!");
        }


        // ZWRACANIE KILKU WARTOŚCI
        static (int min, int max) MinMax(int a, int b)
        {
            if (a < b)
            {
                return (a, b);
            }
            return (b, a);
        }

        // ZADANIA
        // Zad 1
        static bool CzyPierwsza(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            // Sprawdzenie dzielników od 3 do pierwiastka
            int granica = (int)Math.Sqrt(n);
            for (int i = 3; i <= granica; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        // Zad 2
        static long Silnia(int n)
        {
            long silnia = 1;
            for (int i = n; i >= 1; i--)
            {
                silnia *= i;
            }
            return silnia;

        }

        static int WczytajLiczbeSilnia(string pytanie)
        {
            while (true)
            {
                Console.Write(pytanie);
                if(int.TryParse(Console.ReadLine(), out int doSilni))
                {
                    return doSilni;
                }
                Console.WriteLine("To nie jest poprawna liczba");
            }
        }

        // Zad 3
        static int Najwiekszy(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static int Najwiekszy(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            } 
            else if (b > c && b > a)
            {
                return b;
            }
            return c;
        }
        static double Najwiekszy(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }
}
