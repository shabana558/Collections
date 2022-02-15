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
            Console.WriteLine("Welcome to Collections Demo Problem!!!");
            Console.WriteLine("Enter the option ");
            switch (Console.ReadLine())
            {
                case "1":
                    Collections.AddressBook.GetCustomer();
                    Collections.AddressBook.Modify();
                    Collections.AddressBook.ListingPeople();
                    Collections.AddressBook.RemovePeople();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;


            }
        }
    }
}





     
    




    

   
       
            
        
    
    

