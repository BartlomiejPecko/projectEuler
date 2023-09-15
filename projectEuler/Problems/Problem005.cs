using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler.Problems
{
    class Problem005
    {
        // https://projecteuler.net/problem=5
        // Solved with a form of brute force approach so not very optimized and also might take a while to complete.
        public static void Run()
        {
            int number = 1;

            while (true)
            {
                if(Divisible(number, 20))
                {
                    Console.WriteLine(number);
                    break;
                }
                number++;
            }

        }

        public static bool Divisible(int number, int n)
        {
            for(int i = 1; i <=n; i++)
            {
                if(number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
