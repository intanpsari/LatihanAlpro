using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "makers", "institute", "bandung" };
            LinkedList<string> lL = new LinkedList<string>(words);

            //add
            lL.AddFirst("intan");
            lL.AddLast("sari");

            //remove
            lL.RemoveFirst();
            lL.RemoveLast();

            Console.WriteLine(lL.First());

            //find
            LinkedListNode<string> nodef = lL.Find("bandung");
            Console.WriteLine(nodef.Value);

            //add before after nodef
            lL.AddBefore(nodef, "provinsi");
            lL.AddAfter(nodef, "kota");

            //remove node tertentu
            lL.Remove("kota");

            //count (berapa banyak lL)
            Console.WriteLine(lL.Count);

            //mengecek konten
            Console.WriteLine(lL.Contains("bandung"));
            
            foreach (var linked in lL)
            {
                Console.Write(linked+" ");
            }
            Console.WriteLine();

            //mengambil elemen tertentu
            string a = lL.ElementAt(1);
            Console.WriteLine(a);

            string b = lL.ElementAtOrDefault(12);
            Console.WriteLine(b);

            //copy ke array
            string[] arr = new string[lL.Count];
            lL.CopyTo(arr, 0);

            foreach (var ar in arr)
                Console.Write(ar+" ");

            Console.WriteLine("\n");

            //---

            //moving
            LinkedListNode<string> mark1 = lL.First;
            lL.RemoveFirst();
            lL.AddLast(mark1);

            foreach (var linked in lL)
            {
                Console.Write(linked + " ");
            }
            Console.WriteLine();

            //modifying
            lL.RemoveLast();
            lL.AddLast("permata");

            foreach (var linked in lL)
            {
                Console.Write(linked + " ");
            }
            Console.WriteLine();

            mark1 = lL.Last;
            lL.RemoveLast();
            lL.AddFirst(mark1);

            foreach (var linked in lL)
            {
                Console.Write(linked + " ");
            }
            Console.WriteLine();

            //dynamic data structure
            //addafter
            LinkedList<string> linkedd = new LinkedList<string>();
            linkedd.AddLast("one");
            linkedd.AddLast("two");
            linkedd.AddLast("three");
            LinkedListNode<string> node = linkedd.Find("one");
            linkedd.AddAfter(node, "inserted");

            foreach (var linked in linkedd)
            {
                Console.Write(linked + " ");
            }
            Console.WriteLine();

            //addbefore
            LinkedList<string> linkedb = new LinkedList<string>();
            linkedb.AddLast("intan");
            linkedb.AddLast("permata");
            linkedb.AddLast("sari");
            LinkedListNode<string> nodeb = linkedb.Find("intan");
            linkedb.AddBefore(nodeb, "inserted");

            foreach (var linked in linkedb)
            {
                Console.Write(linked + " ");
            }
            Console.WriteLine();


        }
    }
}
