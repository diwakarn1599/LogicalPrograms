using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");

            //Menu for list of programs
            Console.WriteLine("Menu\n1.Fibbonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a Number\n5.Coupon Number\n6.Exit");

            Console.WriteLine("Enter the option");

            //Switch case
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    FibonacciSeries.GenerateFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                case 5:
                    CouponNumber.GenerateCoupon();
                    break;
                case 6:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;

            }
        }
    }
}
