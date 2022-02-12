using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoinProgram
    {
        static void Main(string[] args )
        {
            Console.WriteLine("Welcome to Basic Core Program");
            FlipCoinProgram1 program = new FlipCoinProgram1();
            program.PercentageCheck();
            Console.ReadLine();
        }
    }
}
