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
            TestList();
            TestDictionary();
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
            Console.WriteLine("Number of elements present in list;" + list.Count);
            Console.WriteLine("After adding more than 8 elements:" + list.Capacity);
            // list.TrimToSize();
            Console.WriteLine("Removed 40 element from list");
            list.Remove(40);
            Console.WriteLine();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Number of elements present in list:" + list.Count);
            list.Sort();
            Console.WriteLine("After sorting");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


        }
        public static void TestList()
        {
            //primitive type or valuetype collection
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(40);
            list.Add(76);
            list.Add(39);
            Console.WriteLine("Iterating over list elements");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            // non - primitive type or reference type collection
            List<student> studentlist = new List<student>();
            student s = new student();
            s.Id = 23;
            s.Name = "xyz";
            // student S = new student() { Id = 34, Name = "fgff" };
            studentlist.Add(new student() { Id = 34, Name = "shabana" });
            studentlist.Add(new student() { Id = 4, Name = "shakil" });
            studentlist.Add(new student() { Id = 3, Name = "shafi" });
            foreach (student student in studentlist)
            {
                Console.WriteLine(student);
                // Console.WriteLine("Id:"+student.Id+" Name:"+student.Name);
            }



        }
        public static void TestDictionary()
        {
            try
            {
                IDictionary<int, string> numberNames = new Dictionary<int, string>();
                numberNames.Add(4, "Four"); //adding a key/value using the Add() method
                numberNames.Add(2, "Two");
                numberNames.Add(89, "EightyNine");
                numberNames.Add(3, null);

                //The following throws run-time exception: key already added.
                //numberNames.Add(3, "Three"); 
                if (numberNames.ContainsKey(9))
                    Console.WriteLine("Fetching 89 value:" + numberNames[9]);
                else
                    Console.WriteLine("Key not exist");

                foreach (KeyValuePair<int, string> kvp in numberNames)
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

                //creating a dictionary using collection-initializer syntax
                var cities = new Dictionary<string, string>(){
             {"UK", "London, Manchester, Birmingham"},
             {"USA", "Chicago, New York, Washington"},
             {"India", "Mumbai, New Delhi, Pune"}
              };

                foreach (var kvp in cities)
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}
   
       
            
        
    
    

