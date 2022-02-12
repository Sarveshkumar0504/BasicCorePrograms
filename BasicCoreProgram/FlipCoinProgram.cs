using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoinProgram1
    {
        public int HeadCount = 0;
        public int TailCount = 0;
        public int HeadPercentage = 0;
        public int TailPercentage = 0;
        Random random = new Random();
  
        public int reminder1 = 0;
        public int reminder2 = 0;
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin");
            int CoinFlip = Convert.ToInt32(Console.ReadLine());

            //Using For Loop For Number Of Times Coin Flip
            for (int i = 0; i < CoinFlip; i++)
                Console.Write("Please Enter The Four Digit Number =");
            int Year = Convert.ToInt32(Console.ReadLine());
            reminder1 = Year % 4;
            reminder2 = Year % 400;
            if (reminder1 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else if (reminder2 == 0)
            {
                Console.WriteLine("This is leap year");
            }
            else
            {
                double CheckFlip = random.Next(0, 2);
                if (CheckFlip < 0.5)
                {
                    Console.WriteLine("This is Head");
                    HeadCount++;
                }
                else
                {
                    Console.WriteLine("This is Tail");
                    TailCount++;
                }
                Console.WriteLine("This is not a leap year");
            }
            //Calculation of percentage 
            HeadPercentage = HeadCount * (100 / CoinFlip);
            TailPercentage = TailCount * (100 / CoinFlip);
            Console.WriteLine("Percentage of head :" + HeadPercentage);
            Console.WriteLine("Percentage of head :" + TailPercentage);
            Console.ReadKey();
        }
    }
}
