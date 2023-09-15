using System;

namespace projectEuler.Problems
{
    // https://projecteuler.net/problem=4
    class Problem004
    {
        public static void Run()
        {
            int largestPalindrome = FindLargestPalindrome();
            Console.WriteLine("The largest palindromic number that is the product of two 3-digit numbers is: " + largestPalindrome);
        }

        static int FindLargestPalindrome()
        {
            int largestPalindrome = 0;

            // Start looping from 999 (largest 3-digit number)
            for (int i = 999; i >= 100; i--)
            {
                // To avoid duplicates
                for (int j = i; j >= 100; j--)
                {
                    int n = i * j;

                    if (IsPalindrome(n) && n > largestPalindrome)
                    {
                        largestPalindrome = n;
                    }
                }
            }
            return largestPalindrome;
        }
        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length - i - 1])
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
