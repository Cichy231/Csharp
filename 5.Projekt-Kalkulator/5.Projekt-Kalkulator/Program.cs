using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Projekt_Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============== KALKULATOR ===============");
            Console.ResetColor();
            Console.Write("Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

            // DODATEK 1
            Console.WriteLine($"Średnia z {a} i {b} = {(a + b) / 2}");
            Console.WriteLine($"Kwadrat {a} wynosi {a * a}");
            Console.WriteLine($"Kwadrat {b} wynosi {b * b}");

            // DODATEK 2
            // Dodatki wizualne

            // DODATEK 3
            Console.WriteLine($"Pierwiastek z {a} wynosi " + Math.Sqrt(a));
            Console.WriteLine($"Pierwiastek z {b} wynosi " + Math.Sqrt(b));
            Console.ResetColor();
            Console.ReadKey(); 

        }
    }
}
