using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzystaNieparzysta
{
    class Program
    {
        private static string _endProgram;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzam czy liczba jest parzysta lub nieparzysta.");

            CheckNumber();

            Console.WriteLine("Zamykam program.");
        }

        private static void CheckNumber()
        {
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Nie wprowadziłeś poprawnej liczby. Spróbuj jeszcze raz.");
                    continue;
                }

                if (userNumber % 2 == 0)
                    Console.WriteLine("Podana liczba jest parzysta.");

                if (userNumber % 2 != 0)
                    Console.WriteLine("Podana liczba jest nieparzysta.");

                Console.WriteLine("Aby zakończyć program kliknij 'X', aby podać kolejną liczbę wprowadź dowolny znak");

                _endProgram = Console.ReadLine();
                if (_endProgram.ToUpper() == "X")
                    break;

            }
        }
    }
}
