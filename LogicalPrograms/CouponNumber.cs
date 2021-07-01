using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        //Initialising random class
        Random rand = new Random();

        //private non-static method for generating random number
        private int GenerateRandomNumber(int start, int end)
        {
            int randNum = rand.Next(start, end);
            return randNum;
        }
        public static void GenerateCoupon()
        {
            int startRange, endRange, genratedCoupon, randomNumberCount = 0; 

            Console.WriteLine("Enter start range of coupon number");
            startRange= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter End range of coupon number");
            endRange = Convert.ToInt32(Console.ReadLine());

            //Set is used to add coupons into it, set has functionality that it can contain only distinct values
            HashSet<int> Coupons = new HashSet<int>();

            //object for CouponNumber class
            CouponNumber cn = new CouponNumber();

            //loop for generating coupon codes
            while(Coupons.Count <= Math.Abs(startRange - endRange))
            {
                genratedCoupon = cn.GenerateRandomNumber(startRange, endRange + 1);
                randomNumberCount++;
                Coupons.Add(genratedCoupon);
            }

            //printing coupons
            Console.WriteLine("The coupons are");
            foreach(int i in Coupons)
            {
                Console.Write(i+", ");
            }

            //generated random number counts
            Console.WriteLine("\n{0} Random number generated to generate coupon", randomNumberCount);


        }
    }
}
