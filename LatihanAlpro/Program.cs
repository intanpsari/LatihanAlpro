using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAlpro
{
    class Program
    {
        static void Main(string[] args)
        {
            //no1();
            //givenValue();
            //triplet();
            //triplet2();
            //no5();
            /*
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;
            no6(arr,n);

            int[] arr2 = { 1, 1, 1, 1 };
            int n2 = arr2.Length;
            no6(arr2, n2);

            int[] arr3 = { 1, 1, 3, 4 };
            int n3 = arr3.Length;
            no6(arr3, n3);

            int[] arr4 = { 1, 3, 6, 10, 11, 15 };
            int n4 = arr4.Length;
            no6(arr4, n4);
            */
            int n = 5;
            Console.WriteLine("Factorial " + n + " is: " + factorial(n));

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

        static void no1()
        {
            
            Console.WriteLine("Inputkan string: ");
            var kata = Console.ReadLine();
            char[] huruf = kata.ToCharArray();
            

            List<char> tampList = new List<char>();
           

            for (int i = 0; i < huruf.Length; i++)
            {
                if (char.IsLetter(huruf[i])) { 
                    tampList.Add(huruf[i]);
                }
                
            }

            int count = tampList.Count();
            Console.WriteLine(count);
            tampList.Reverse();
            int j = 0;
            for(int i = 0; i < huruf.Length; i++)
            {
                if (char.IsLetter(huruf[i])){
                    huruf[i] = tampList[j];
                    j++;
                }
            }

            Console.WriteLine();
            
            foreach (var a in huruf)
                Console.Write(a);

            Console.WriteLine();
        }

        static void givenValue()
        {
            List<int> tamp = new List<int>();
            int[] arr = { 5, 1, 3, 4, 7 };
            int sum = 12;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    for(int k = j + 1; k < arr.Length; k++)
                    {
                        if((arr[i] + arr[j] + arr[k]) < sum)
                        {
                            Console.WriteLine(arr[i] +" "+ arr[j] +" "+ arr[k]);
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }

        static void triplet()
        {
            int[] arr = { 10, 4, 6, 12, 5 };
            bool status = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    double a = arr[i];
                    double b = arr[j];
                    double c = Math.Sqrt((a * a) + (b * b));
                    for(int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] == c)
                        {
                            status = true;
                        }
                    }

                }
            }

            Console.WriteLine(status);
        }

        static void triplet2()
        {
            int[] arr = { 1,2,4,5,3 };
            bool status = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                double a = arr[i];
                double b = arr[i+1];
                double c = Math.Sqrt((a * a) + (b * b));
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == c)
                    {
                        status = true;
                    }
                }
            }
            Console.WriteLine(status);
        }

        static void no5()
        {
            int[] arr = { 1, 56, 58, 57, 90, 92, 94, 93, 91, 45 };
            //urutin dulu
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var a in arr)
                Console.Write(a + " ");

            Console.WriteLine();
            int count = 1;
            int cek = 0;

            for(int i = 1; i < arr.Length; i++)
            {
               if ((arr[i]) == (arr[i-1] + 1))
                {
                    count++;
                    Console.WriteLine(count +" "+ cek);
                }
                else 
                {
                    count = 1;
                }

                if (count > cek)
                {
                    cek = count;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cek);
        }

        static void no6(int[] arr, int n)
        {
            foreach (var a in arr)
                Console.Write(a + " ");

            Console.WriteLine();

            int jum = 1;
            for(int i = 0; i < n  ; i++)
            {
                if(arr[i] <= jum)
                {
                    Console.WriteLine(jum + " + " + arr[i] + " = " + (jum + arr[i]));
                    jum = jum + arr[i];
                }
                
            }

            Console.WriteLine(jum);
        }

    }
}
