using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            int number,rev=0,rem;
            Console.WriteLine("Enter the number");

            //getting number from the user
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                rem = number % 10;//getting reminder by modulo operator

                rev = rev * 10 + rem;//forming reverse number

                number /= 10;
            }

            Console.WriteLine("The reversed number is {0}",rev);

        }

    }
}
