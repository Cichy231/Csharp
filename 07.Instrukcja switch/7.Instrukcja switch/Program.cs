using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Instrukcja_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wybor = 2;
            switch (wybor) // Wpisuje zmienną którą będziemy sprawdzać
            {
                case 1: // Opcja gdzie wybor == 1
                    Console.WriteLine("Liczba 1");
                    break;
                case 2:
                    Console.WriteLine("Liczba 2");
                    break;
                case 3:
                    Console.WriteLine("Liczba 3");
                    break;
                default:
                    Console.WriteLine("Nieznana opcja");
                    break;
            }


            int miesiac = 4;
            switch (miesiac) // Można sprawdząc kilka warunków na raz
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Zima");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Wiosna");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Lato");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Jesień");
                    break;
                default:
                    Console.WriteLine("Niepoprawny miesiąc");
                    break;
            }
            // Switch działa tak samo na stringach

            Console.WriteLine();
            // ZADANIA


            // Zad 1
            Console.Write("Podaj numer dnia tygodnia: ");
            int dzien = int.Parse(Console.ReadLine());
            switch (dzien)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Brak takiego dnia");
                    break;
            }


            // Zad 2
            switch (dzien)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Dzień roboczy");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Dzień wolny");
                    break;
                default:
                    Console.WriteLine("Brak takiego dnia");
                    break;
            }


            // Zad 3
            Console.Write("Wpisz numer miesiąca: ");
            int numerMiesiac = int.Parse(Console.ReadLine());
            switch (numerMiesiac)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Twój miesiąc ma 31 dni");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Twój miesiąc ma 30 dni");
                    break;
                case 2:
                    Console.WriteLine("Twój miesiąc ma 28 dni");
                    break;
                default:
                    Console.WriteLine("Brak takiego miesiąca");
                    break;
            }


            // Zad 4
            Console.Write("Wpisz ocene (1-6): ");
            int ocena = int.Parse(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczna");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczająca");
                    break;
                case 3:
                    Console.WriteLine("Dostateczna");
                    break;
                case 4:
                    Console.WriteLine("Dobra");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobra");
                    break;
                case 6:
                    Console.WriteLine("Celująca");
                    break;
                default:
                    Console.WriteLine("Brak takiej oceny");
                    break;
            }


            // Zad 5
            Console.WriteLine("Wybierz jedną z 3 opcji \n1. Przeliczenie kilometrów na mile\n2. Przeliczenie kilograma na funty\n3. Przeliczanie stopni Celshusza na Fahrenheita");
            int opcja = int.Parse(Console.ReadLine());
            switch (opcja)
            {
                case 1:
                    Console.Write("Podaj ilość kilometrów: ");
                    int kilometry = int.Parse(Console.ReadLine());
                    double mile = kilometry * 0.621371;
                    Console.WriteLine($"Liczba mil to: {mile:F2}");
                    break;
                case 2:
                    Console.Write("Podaj ilość kilogramów: ");
                    int kilogramy = int.Parse(Console.ReadLine());
                    double funty = kilogramy * 2.20462;
                    Console.WriteLine($"Liczba mil to: {funty:F2}");
                    break;
                case 3:
                    Console.Write("Podaj ilość stopni Celsjusza: ");
                    int stopnieC = int.Parse(Console.ReadLine());
                    double stopnieF = stopnieC * 9 / 5 + 32;
                    Console.WriteLine($"Liczba mil to: {stopnieF:F2}");
                    break;
            }
        }
    }
}
