using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            int number,Flag=0;
            Console.WriteLine("Enter the number");

            //getting number from the user
            number = Convert.ToInt32(Console.ReadLine());

            //loop for checking divisors
            if (number == 1)
            {
                Console.WriteLine("{0} is neither prime nor composite",number);
            }
            else if(number==2)
            {
                Console.WriteLine("{0} is a prime number",number);
            }
            else if(number%2 == 0)
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
            else
            {
                for (int i = 3; i*i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Flag = 1;
                        break;
                    }

                }
                if(Flag==1)
                {
                    Console.WriteLine("{0} is not a Prime Number", number);
                }
                else
                {
                    Console.WriteLine("{0} is a Prime Number", number);
                }
            }
        }
    }
}
