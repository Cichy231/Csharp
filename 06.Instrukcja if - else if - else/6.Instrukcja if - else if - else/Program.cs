using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Instrukcja_if___else_if___else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int punkty = 75;
            if (punkty >= 90)
            {
                Console.WriteLine("Ocena: 5");
            } 
            else if (punkty >= 70)
            {
                Console.WriteLine("Ocena: 4");
            }
            else if (punkty >= 50)
            {
                Console.WriteLine("Ocena: 3");
            }
            else
            {
                Console.WriteLine("Ocena: 2");
            }

            // ŁĄCZENIE WARUNKÓW
            int wiek = 25;
            bool maBilet = true;
            if (wiek >= 18 && maBilet) // Oba warunki muszą być spełnione
            {
                Console.WriteLine("Wejście dozwolone.");
            }


            string dzien = "sobota";
            if(dzien == "sobota" || dzien == "niedziela") // Wystarczy tylko jeden prawdziwy warunek
            {
                Console.WriteLine("Weekend");
            }


            bool czyZalogowany = false; 
            if(!czyZalogowany) // Odwraca wartość
            {
                Console.WriteLine("Zaloguj się.");
            }


            if(wiek > 18)
                Console.WriteLine("Pełnoletni"); // Jeśli jest jeden warunek to można pominąć klamry
                Console.WriteLine("Możesz głosować"); // Pomimo wcięcia ten kod wykona się zawsze, poniewaź nie podlega pod if


            // Operator ?
            string status = wiek >= 18 ? "Pełnoletni" : "Niepełnoletni"; // Skrócony zapis if
            Console.WriteLine(status); // Jeśli true wypisze lewą stronę a jeśli false to prawą


            // ZADANIA
            // Zad 1
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());
            if(liczba < 0)
            {
                Console.WriteLine("Ujemna");
            } 
            else if (liczba > 0)
            {
                Console.WriteLine("Dodatnia");
            } else
            {
                Console.WriteLine("Liczba jest równa zero.");
            }

            
            // Zad 2
            if(liczba % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta.");
            }


            // Zad 3
            Console.WriteLine("Podaj swój wiek: ");
            int wiekOsoby = int.Parse(Console.ReadLine());
            if(wiekOsoby < 13)
            {
                Console.WriteLine("Dziecko");
            } 
            else if (wiekOsoby < 17)
            {
                Console.WriteLine("Nastolatek");
            }
            else if (wiekOsoby < 65)
            {
                Console.WriteLine("Dorosły");
            } 
            else
            {
                Console.WriteLine("Senior");
            }

            // Zad 4
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int pierwsza = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int druga = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int trzecia = int.Parse(Console.ReadLine());
            if (pierwsza > druga && pierwsza > trzecia)
            {
                Console.WriteLine($"{pierwsza} jest największe");
            }
            else if (druga > pierwsza && druga > trzecia)
            {
                Console.WriteLine($"{druga} jest największa");   
            }
            else
            {
                Console.WriteLine($"{trzecia} jest największa");
            }

            // Zad 5
            Console.WriteLine("Podaj jakiś rok: ");
            int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0)) {
                Console.WriteLine("Rok przestępny");
            } 
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }

            // Zad 6
            Console.Write("Wpisz liczbę punktów(0-100): ");
            int liczbaPunktow = int.Parse(Console.ReadLine());
            if (liczbaPunktow >= 90 && liczbaPunktow <= 100)
            {
                Console.WriteLine("Ocena to 5");
            } 
            else if (liczbaPunktow >= 75)
            {
                Console.WriteLine("Ocena to 4");
            }
            else if (liczbaPunktow >= 50)
            {
                Console.WriteLine("Ocena to 3");
            }
            else if (liczbaPunktow < 50)
            {
                Console.WriteLine("Ocena to 2");
            }
            else
            {
                Console.WriteLine("Niepoprawna liczba punktów");
            }
        }
    }
}
