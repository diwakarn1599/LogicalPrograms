using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");

            //Menu for list of programs
            Console.WriteLine("Menu\n1.Fibbonacci Series\n2.Exit");

            Console.WriteLine("Enter the option");

            //Switch case
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    FibonacciSeries.GenerateFibonacciSeries();
                    break;
                case 2:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;

            }
        }
    }
}
