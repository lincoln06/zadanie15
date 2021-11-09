using System;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Podaj liczbę całkowitą większą lub równą 0");
            double potega = double.Parse(Console.ReadLine());
            double bufor = 1;
            double licznik = 1;
            while(potega<0)
            {
                Console.Clear();
                Console.WriteLine("Podałeś nieprawidłową liczbę. Naciśnij dowolny klawisz aby spróbować jeszcze raz...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Podaj liczbę całkowitą większą lub równą 0");
                potega = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            if (potega == 0)
            {
                Console.WriteLine("2 do potęgi 0 wynosi: \t 1");
            }
            else
            {
                Console.WriteLine("2 do potęgi 0 wynosi: \t 1");
                while (licznik < potega + 1)
                {
                    bufor = bufor * 2;
                    Console.WriteLine($"2 do potęgi {licznik} wynosi: \t {bufor}");
                    licznik++;
                }
            }
            Console.ReadKey();
        }
    }
}
