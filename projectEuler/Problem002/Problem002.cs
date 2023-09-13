using System;

namespace projectEuler.Problem002
{
    
    class Problem002
    {
        // https://projecteuler.net/problem=2
        public static void Run()
        {
            int a = 1;
            int b = 2;
            int sum = 0;

            while (a <= 4000000)
            {
                if (a % 2 == 0) //Checks if Fibbonacci number is even
                {
                    sum += a;
                }

                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("The sum of the even-valued terms is " + sum);
        }
    }
}
