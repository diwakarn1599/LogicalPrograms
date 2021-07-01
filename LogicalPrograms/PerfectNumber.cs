using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {

        public static void CheckPerfectNumber()
        {
            int number,sum=0;
            Console.WriteLine("Enter the number");

            //getting number from the user
            number = Convert.ToInt32(Console.ReadLine());

            //loop for checking divisors
            for(int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

            }
            //condition to check if its a perfect number
            if (sum == number)
            {
                Console.WriteLine("{0} is a Perfect number",number);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect number", number);
            }
        }
    }
}
