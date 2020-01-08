using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
    class Linq
    {
        public void GetCountUsingLinq(string str )
        {            
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
        }       
           
    }
}
