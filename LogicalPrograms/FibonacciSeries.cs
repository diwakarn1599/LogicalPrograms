using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void GenerateFibonacciSeries()
        {
            int n1 = 0, n2 = 1, sum, limit;
            Console.WriteLine("Enter How many numbers in the series should be generated");

            //getting limit from the user
            limit = Convert.ToInt32(Console.ReadLine());

            if (limit == 1)
            {
                Console.WriteLine(n1);
            }
            else
            {

                Console.WriteLine(n1);
                Console.WriteLine(n2);
                limit -= 2;
                //loop for generating fibbonacci series
                while (limit > 0)
                {
                    sum = n1 + n2;
                    Console.WriteLine(sum);
                    n1 = n2;
                    n2 = sum;
                    limit -= 1;
                }
            }
        }
    }
}
