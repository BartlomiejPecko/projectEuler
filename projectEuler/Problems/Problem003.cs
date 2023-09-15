using System;
using projectEuler.Methods;

namespace projectEuler.Problems
{
    // https://projecteuler.net/problem=3
    // Note this program requires IsPrime method from another directory.
    class Problem003
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: "); // In this case copy '600851475143' and Enter.
            long n = long.Parse(Console.ReadLine());
            if (IsPrime.Check((int)n))
            {
                Console.WriteLine("{0} is a prime number.", n); //If entered number is prime, program will say so.
            }
            else
            {
                Console.WriteLine("The largest prime factor of {0} is {1}", n, LargestPrimeFactor(n));
            }
        }

        // Function to find the largest prime factor of a number
        static long LargestPrimeFactor(long n)
        {
            long prime = 2;
            while (n > 1)
            {
                while (n % prime == 0)
                {
                    n /= prime;
                }
                if (n == 1)
                    break;
                prime++;
                // Find the next prime number
                while (!IsPrime.Check((int)prime))
                {
                    prime++;
                }
            }
            return prime;
        }

    }
}
