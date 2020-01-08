using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionarySample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = string.Empty;
            Console.WriteLine("Please select the below options");
            Console.WriteLine("1. Using LINQ");
            Console.WriteLine("2. Using Dictionary");
            int option = Convert.ToInt32( Console.ReadLine());
            
            switch(option)
            {
                case 1:
                    
                    Console.WriteLine("Enter the string to convert");
                     str = Console.ReadLine();
                    //Using LINQ
                    Linq linq = new Linq();
                    linq.GetCountUsingLinq(str);
                    break;
                case 2:
                    Console.WriteLine("Enter the string to convert");
                     str = Console.ReadLine();
                    ////Using DICTIONARY
                    Dictionary dict = new Dictionary();
                    dict.GetCountUsingDict(str);                   
                    break;
                default:
                    Console.WriteLine("Please Select the given options 1 or 2");
                    break;    
            }
            Console.ReadLine();
        }
    }
}
