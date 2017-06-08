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
            //ulong n = 65;
            //Console.WriteLine(factorial(n));
            /*
            int m = 5;
            for(int i = 0; i < m; i++)
            {
                Console.Write(fibbonaci(i)+" ");
            }
            Console.WriteLine();
            */
           // fib2(1, 1, 0, 5);

            int[] arr = { 1, 3, 4, 7 };
            Console.WriteLine(jumArr(arr, 0));
            
        }

        public static ulong factorial(ulong n)
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

        public static int fibbonaci(int m)
        {
            if(m == 0 || m==1)
            {
                return 1;
            }
            else
            {
                return fibbonaci(m - 1) + fibbonaci(m - 2);
            }
        }

        public static void fib2(int a, int b, int counter, int len)
        {
            if (counter < len)
            {
                Console.Write(a+" ");
                fib2(b, a + b, counter + 1, len);
            }
        }

        public static int jumArr(int[] arr,int counter)
        {
            if(counter == arr.Length)
            {
                return 0;
            }
            else
            {
                return arr[counter] + jumArr(arr, counter + 1);
            }
               
              
        }

    }
}
