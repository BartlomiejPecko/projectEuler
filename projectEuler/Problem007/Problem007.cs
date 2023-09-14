using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectEuler.Methods;

namespace projectEuler.Problem007
{
    // https://projecteuler.net/problem=7
    // I've extended the use-case so that not only it solves the 10001th prime number problem, it can calculate any Nth prime number all up to the 10001th prime.
    // User only provides the number and the program will calculate the value.
    // Contains methods from another folder so will not work on its own.
    class Problem007
    {
        public static void Run()
        {
            Console.WriteLine("Enter the Nth prime number you want to find. Max val= 10001");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n <= 10001)
            {
                int nthPrime = FindNthPrime(n);
                Console.WriteLine($"The {n}th prime number is {nthPrime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a positive int between 1 and 10001.");
            }
        }

        static int FindNthPrime(int n)
        {
            if (n == 1)
                return 2;

            int count = 1;
            int cand = 1;

            while (count < n)
            {
                cand += 2;
                if (IsPrime.Check(cand)) // Note that this method is in the folder methods. 
                    count++;
            }
            return cand;
        }

    }
}
