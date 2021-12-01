using System;

namespace ProgamaMSDev
{
    internal class Program
    {

        // Criar um app que diga se o número é par ou ímpar
        static void Main(string[] args)
        {
            int numberToCheck = 0;

            numberToCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckIfNumberIsPair(numberToCheck));
        }

        static string CheckIfNumberIsPair(int number) => number % 2 == 0 ? "É par!" : "É ímpar!";
    }
}
