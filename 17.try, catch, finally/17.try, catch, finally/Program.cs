using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.try__catch__finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TRY i CATCH
            try     // Błąd który może rzucić wyjątek, jeśli wszystko jest dobrze catch jest omijany
            {       // Jeśli w try pojawi się wyjątek reszta kodu jest pomijana, a program skacze do catch
                Console.Write("Podaj liczbę: ");
                int liczba = int.Parse(Console.ReadLine());
                Console.WriteLine($"Kwadrat: {liczba * liczba}");
            }
            catch // Tutaj jeśli nie podamy liczby to nie wywali błędu tylko wypisze że coś poszło nie tak
            {
                Console.WriteLine("Coś poszło nie tak.");
            }


            // Łapanie konkretnego wyjątku
            try
            {
                int liczba = int.Parse(Console.ReadLine());
                Console.WriteLine(100 / liczba);
            }
            catch (FormatException) // Może być wiele bloków catch, każdy do innego błędu
            {
                Console.WriteLine("To nie jest liczba.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie można dzielić przez zero.");
            }

            // Odczytanie informacji o wyjątku
            try
            {
                int ex = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            // Blok finally
            try
            {
                Console.WriteLine("Otwieram zasób.");
                int x = int.Parse("abc");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd formatu.");
            }
            finally // Finally wykonuje się zawsze, niezależnie od tego czy wyjątek wystąpił
            {
                Console.WriteLine("Sprzątam.");
            }
            // Finally służy do: zamykania plików, połączeń z bazą, zwalniania zasobów
        }
    }
}
