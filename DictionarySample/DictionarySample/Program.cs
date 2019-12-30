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
            Console.WriteLine("Linq Code is Simple Than Dictionary");
            Console.WriteLine("Using LINQ");
            Console.WriteLine("---------------");
            var counted = str.GroupBy(g => g).Select(s => new { s.Key, Count = s.Count() }).OrderBy(o => o.Key);
                 

            foreach (var val in counted)
            {
                if (val.Count > 1)
                {
                    Console.Write(val.Key + "" + val.Count);
                }
                else
                {
                    Console.Write(val.Key);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("##############");
            //Using DICTIONARY
            Console.WriteLine("Using Dictionary");
            Console.WriteLine("-----------------");
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                    dict[str[i]]++;
                else
                    dict.Add(str[i], 1);
            }

            foreach(KeyValuePair<char,int> pair in dict.OrderBy(e => e.Key))
            {
                if (pair.Value > 1)
                {
                    Console.Write(pair.Key + "" + pair.Value);
                }
                else
                    Console.Write(pair.Key);
            }

            Console.ReadLine();
           
        }
    }
}
