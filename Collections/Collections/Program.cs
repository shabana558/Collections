using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestArrayList();
            Console.ReadLine();
        }
        public static void TestArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(40);
            list.Add(87);
            list.Add(98);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list.Capacity);
            list.Add(78);
            list.Add(40);
            Console.WriteLine("Number of elements present in list;"+list.Count);
            Console.WriteLine("After adding more than 8 elements:" + list.Capacity);
           // list.TrimToSize();
            Console.WriteLine("Removed 40 element from list");
            list.Remove(40);
            Console.WriteLine();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Number of elements present in list:"+list.Count);
            list.Sort();
            Console.WriteLine("After sorting");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


        }
    }
}
