using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to check");
            string str = Console.ReadLine();

            //Using LINQ
            Linq linq = new Linq();
            linq.GetCountUsingLinq(str);

            ////Using DICTIONARY
            Dictionary dict = new Dictionary();
            dict.GetCountUsingDict(str);
            Console.ReadLine();

        }
    }
}
