using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler.Problem001
{
    class Problem001
    {
        public static void Main(String[] args)
        {
            int sum = Enumerable.Range(1, 999) //Generates sequence of numbers from 1 to 999
                .Where(i => i % 3 == 0 || i % 5 == 0) //Filters the numbers that are multiples of 3 or 5
                .Sum(); //Calcs sum of the previously filtered numbers

            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is: {sum}");
            Console.ReadLine();

        }
       
    }
}
