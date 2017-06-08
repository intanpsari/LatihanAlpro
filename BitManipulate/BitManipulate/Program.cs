using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(10 ^ 10);
            /*int n = 1234;
            string b = Convert.ToString(n,2);
            var biner = b.ToCharArray();
            int count = 0;

            foreach (var a in biner)
            {
                if (a == '1')
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            string num1 = "10";
            string num2 = "0";

            char[] des1 = num1.ToCharArray();

            List<int> des1a = new List<int>();
            for (int i=0;i<des1.Length;i++)
            {
                if(des1[i] == '1')
                {
                    des1a.Add(1);
                }else if(des1[i] == '0')
                {
                    des1a.Add(0);
                }
            }
            double jum1=0;
            foreach(var a in des1a)
                 Console.Write(a);

            int k = 0;
            for(int i = des1a.Count()-1; i >=0 ; i--)
            {
                jum1 = jum1 + (Math.Pow(2, k) * des1a[i] );
                k++;
            }
            Console.WriteLine();

            Console.WriteLine(jum1);

            //--
            char[] des2 = num2.ToCharArray();

            List<int> des2a = new List<int>();
            for (int i = 0; i < des2.Length; i++)
            {
                if (des2[i] == '1')
                {
                    des2a.Add(1);
                }
                else if (des2[i] == '0')
                {
                    des2a.Add(0);
                }
            }
            double jum2 = 0;
            foreach (var a in des2a)
                Console.Write(a);

            int j = 0;
            for (int i = des2a.Count() - 1; i >= 0; i--)
            {
                jum2 = jum2 + (Math.Pow(2, j) * des2a[i]);
                j++;
            }
            Console.WriteLine();

            Console.WriteLine(jum2);

            int total = (int)(jum1) + (int)(jum2);
            Console.WriteLine(total);




        }
    }
}
