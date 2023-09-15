using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectEuler.Methods;

namespace projectEuler.Problems
{
    // https://projecteuler.net/problem=10
    class Problem010
    {
        public static void Run()
        {
            int limit = 2000000;
            long result = SumOfPrimes(limit);
            Console.WriteLine(result);
        }
        public static long SumOfPrimes(int limit)
        {
            long sum = 0;
            for(int i = 2; i< limit; i++)
            {
                if (IsPrime.Check(i)) //Uses IsPrime from Methods folder.
                {
                    sum += i;
                }
            }
            return sum;
        }

    }
}
