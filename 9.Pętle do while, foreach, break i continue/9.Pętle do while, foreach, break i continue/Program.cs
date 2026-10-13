using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Pętle_do_while__foreach__break_i_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Pętla do while (zawsze wykona się chociaż raz)
            //int liczba;
            //do // Najpierw się wykonuje
            //{
            //    Console.Write("Podaj liczbę dodatnią: ");
            //    liczba = int.Parse(Console.ReadLine());
            //}
            //while (liczba <= 0); // Później sprawdza warunek
            //Console.WriteLine($"Podałeś: {liczba}");

            //Console.WriteLine();


            //// Pętla foreach
            //string slowo = "Kot";
            //foreach (char znak in slowo) // Przechodzi po każdym elemencie kolekcji
            //{                            // K
            //    Console.WriteLine(znak); // o                                        
            //}                            // t

            //Console.WriteLine();


            //// Instrukcja break (natychmiast kończy pętle)
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i); // 1 2 3 4 5 (reszta się nie wypisze bo przy 6 jest break)
            //}

            //Console.WriteLine();


            //// Instrukcja continue (pomija reszte obecnej iteracji)
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i); // 1 3 5 7 9 (dla parzystych przerywa iteracje)
            //}

            //Console.WriteLine();


            // ZADANIA
            // Zad 1
            int wiek;
            do
            {
                Console.Write("Podaj swój wiek: ");
                wiek = int.Parse(Console.ReadLine());
            }
            while (wiek < 1 || wiek > 120);

            Console.WriteLine();


            // Zad 2
            int akcja, a, b;
            do
            {
                Console.WriteLine("Wybierz akcje: \n 0. Koniec programu \n 1. Sumowanie 2 liczb \n 2. Mnożenie 2 liczb \n ");
                akcja = int.Parse(Console.ReadLine());
                switch (akcja)
                {
                    case 1:
                        Console.Write("Podaj liczbę a: ");
                        a = int.Parse(Console.ReadLine());

                        Console.Write("Podaj liczbę b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Suma wynosi: {a + b}");
                        break;
                    case 2:
                        Console.Write("Podaj liczbę a: ");
                        a = int.Parse(Console.ReadLine());

                        Console.Write("Podaj liczbę b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Mnożenie wynosi: {a * b}");
                        break;
                }
            }
            while (akcja != 0);

            Console.WriteLine();


            // Zad 3
            Console.Write("Napisz jakieś słowo: ");
            string slowo = Console.ReadLine();
            int licznik = 0;
            foreach (char s in slowo)
            {
                if (s == 'a')
                {
                    licznik++;
                }
                Console.WriteLine(s);
            }
            Console.WriteLine($"Litera 'a' występuje {licznik} razy");

            Console.WriteLine();


            // Zad 4
            for (int i = 1; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                    continue;
                }
                Console.Write(i + "  ");
            }

            Console.WriteLine();

        }
    }
}


