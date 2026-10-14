using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Projekt_Zgadnij_Liczbę
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowanie = new Random(); // Utowrzenie klasy random
            int tajna;
            int proby;
            int strzal;
            int odpowiedz;

            // Zmienne do obsługi poziomów trudności
            int maxLiczba = 100;
            int maxProby = 7;

            do
            {
                proby = 0;

                Console.Clear();
                Console.WriteLine("Wybierz poziom trudności:");
                Console.WriteLine("1. Łatwy (1-50)");
                Console.WriteLine("2. Średni (1-100)");
                Console.WriteLine("3. Trudny (1-200)");
                Console.Write("Twój wybór: ");

                string wyborPoziomu = Console.ReadLine();

                switch (wyborPoziomu)
                {
                    case "1":
                        maxLiczba = 50;
                        maxProby = 10;
                        Console.WriteLine("\nWybrano poziom ŁATWY. Zakres 1-50. Powodzenia!");
                        break;
                    case "2":
                        maxLiczba = 100;
                        maxProby = 10;
                        Console.WriteLine("\nWybrano poziom ŚREDNI. Zakres 1-100. Powodzenia!");
                        break;
                    case "3":
                        maxLiczba = 200;
                        maxProby = 10;
                        Console.WriteLine("\nWybrano poziom TRUDNY. Zakres 1-200. Powodzenia!");
                        break;
                    default:
                        maxLiczba = 100;
                        maxProby = 10;
                        Console.WriteLine("\nNieprawidłowy wybór. Automatycznie ustawiono poziom ŚREDNI.");
                        break;
                }

                // Losowanie liczby na podstawie wybranego zakresu
                tajna = losowanie.Next(1, maxLiczba + 1);
                Console.WriteLine($"Masz maksymalnie {maxProby} prób.\n");

                do
                {
                    Console.Write("Zgadnij: ");
                    if (int.TryParse(Console.ReadLine(), out strzal))
                    {
                        proby++;
                        if (strzal > tajna)
                        {
                            Console.WriteLine("Twoja liczba jest za duża");
                        }
                        else if (strzal < tajna)
                        {
                            Console.WriteLine("Twoja liczba jest za mała");
                        }

                        // Warunek przegranej 
                        if (proby >= maxProby && tajna != strzal)
                        {
                            Console.WriteLine($"Niestety nie udało ci się zgadnąć liczby, liczba to {tajna}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("To nie jest liczba, spróbuj jeszcze raz");
                    }
                } while (tajna != strzal);

                // Warunek wygranej 
                if (tajna == strzal && proby <= maxProby)
                {
                    Console.WriteLine($"Brawo, tajną liczbą była {tajna}, udało ci się zgadnąć za {proby} razem!");
                }

                Console.WriteLine("\nCzy chcesz zagrać jeszcze raz? \n 1. Tak \n 2. Nie");
                odpowiedz = int.Parse(Console.ReadLine());

            } while (odpowiedz != 2);


            // DODATKOWE ZADANIA
            // Zad 1
            // Użycie TryParse zamiast Parse, kiedy wpisana nie jest liczbą liczba prób się nie zwiększa

            // Zad 2
            // Dodanie poziomów trudności
        }
    }
}
