using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie listy
            List<int> liczby = new List<int>();
            List<string> imiona = new List<string>();
            // List<int> liczby2 = new(); // Skrócony zapis (Dostępny od wersji 9.0)
            List<string> nazwiska = new List<string> { "Kowalski", "Nowak", "Lewandowski" }; // Z gotowymi wartościami

            // Dodawanie elementów
            imiona.Add("Anna");
            imiona.Add("Kasia");
            imiona.Add("Piotr");

            imiona.Insert(1, "Ola"); // Wstawia na 1 pozycje a reszta się przesuwa
            // Lista wygląda tak: Anna, Ola, Kasia, Piotr


            // Odczyt i zmiana
            Console.WriteLine(imiona[0]); // Anna
            imiona[1] = "Zosia"; // Zmiana elementu
            Console.WriteLine(imiona.Count); // WAŻNE!!! - Nie Length tylko Count

            // Usuwanie elementów
            imiona.Remove("Piotr"); // Usuwa pierwszy element o tej wartości
            imiona.RemoveAt(0); // Usuwa element o indeksie 0
            imiona.Clear(); // Usuwa wszystko
            // Remove zwraca true, jeśli coś usunięto i false jeśli nie było elementu


            // Przechodzenie po liście
            foreach (string imie in imiona)
            {
                Console.WriteLine(imie);
            }
            for (int i = 0; i < imiona.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {imiona[i]}");
            }

            liczby.Add(1);
            liczby.Add(5);
            liczby.Add(3);
            liczby.Add(2);
            for (int i = liczby.Count - 1; i >= 0; i-- )
            {
                if (liczby[i] % 2 == 0) 
                {
                    liczby.RemoveAt(i); // Usuwamy parzyste
                }
                // Trzeba iść od końca, bo usunięcie elementu przesuwa kolejke i pominelibyśmy niektóre
            }


            // Przydatne metody
            List<int> liczby2 = new List<int> { 5, 2, 8, 1, 9 };

            bool jest = liczby2.Contains(8); // Sprawdza czy jest (true)
            int indeks = liczby2.IndexOf(8); // Sprawdza na którym indeksie (2 lub -1 kiedy nie ma)
            liczby2.Sort(); // Sortuje 1 2 5 8 9
            liczby2.Reverse(); // Odwraca 9 8 5 2 1
            int max = liczby2.Max(); // Maksymalna wartość: 9
            int min = liczby2.Min(); // Minimalna wartość: 1
            int suma = liczby2.Sum(); // Suma: 25
            double srednia = liczby2.Average(); // Średnia: 5


            // Konwersje
            int[] tablica = { 1, 2, 3 };
            List<int> lista = tablica.ToList(); // tablica -> lista
            int[] zNowu = lista.ToArray(); // lista -> tablica


            // Lista i metody
            List<int> liczby3 = new List<int>();
            DodajDwa(liczby3);
            Console.WriteLine(liczby3.Count); // 1

            // ZADANIA 
            // Zad 1
            // Wypisanie liczby, sumy, największej, średniej i najmniejszej liczby z listy utworzonej przez użytkownika
            int liczba;
            List<int> liczbyZad1 = new List<int>();
            do
            {
                Console.Write("Podaj liczbę która będzie dodana do listy: ");
                liczba = int.Parse(Console.ReadLine());
                if (liczba != 0)
                {
                    liczbyZad1.Add(liczba);
                }
            }
            while (liczba != 0);
            Console.WriteLine("Liczba podanych cyfr: " + liczbyZad1.Count);
            Console.WriteLine("Suma podanych liczb wynosi: " + liczbyZad1.Sum());
            Console.WriteLine("Największa liczba wynosi: " + liczbyZad1.Max());
            Console.WriteLine("Średnia liczb wynosi: " + liczbyZad1.Average());
            Console.WriteLine($"Najmniejsza liczba wynosi: {liczbyZad1.Min()}");

            Console.WriteLine();
            Console.WriteLine();


            // Zad 2
            // Usunięcie liczb parzystych
            List<int> listaParzysta = new List<int> { 4, 7, 12, 3, 18, 9, 22 };
            for(int i = listaParzysta.Count - 1; i >= 0; i--)
            {
                if (listaParzysta[i] % 2 == 0)
                {
                    listaParzysta.RemoveAt(i);
                }
            }
            foreach (int liczbaNieParzysta in listaParzysta)
            {
                Console.Write(liczbaNieParzysta + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // Zad 3
            // Lista zakupów
            Console.WriteLine("----------------- LISTA ZAKUPÓW -----------------");
            int wybor;
            List<string> zakupy = new List<string>();
            do
            {
                Console.Write("Wybierz opcje: \n 1. Dodaj produkt \n 2. Usuń produkt \n 3. Wypisz liste z numerami \n 0. Wyjście \n ");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.Write("Wpisz nazwe produktu: ");
                        string nazwa = Console.ReadLine();
                        zakupy.Add(nazwa);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Wpisz nazwe produktu: ");
                        nazwa = Console.ReadLine();
                        zakupy.Remove(nazwa);
                        Console.WriteLine();
                        break;
                    case 3:
                        for (int i= 0; i < zakupy.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {zakupy[i]}");
                        }
                        Console.WriteLine();
                        break;
                }
            }
            while (wybor != 0);
        }
        // Lista i metody
        static void DodajDwa(List<int> l)
        {
            l.Add(2);
        }
    }
}
