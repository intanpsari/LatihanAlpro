using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAlpro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(factorial(n));
        }

        public static int factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

    }
}
