using System;

namespace projectEuler.Problem003
{
    // https://projecteuler.net/problem=3
    class Problem003
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: "); // In this case copy '600851475143' and Enter.
            long n = long.Parse(Console.ReadLine());
            if (IsPrime(n))
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
                while (!IsPrime(prime))
                {
                    prime++;
                }
            }
            return prime;
        }

        // Function to check if a number is prime
        static bool IsPrime(long n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (long i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
