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
        public void PercentageCheck()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin");
            int CoinFlip = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < CoinFlip; i++)
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
            }
            
            HeadPercentage = HeadCount * (100 / CoinFlip);
            TailPercentage = TailCount * (100 / CoinFlip);
            Console.WriteLine("Percentage of head :" + HeadPercentage);
            Console.WriteLine("Percentage of head :" + TailPercentage);
            Console.ReadKey();
        }

    }
}
