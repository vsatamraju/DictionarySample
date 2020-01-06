using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
    class Dictionary
    {
        public void GetCountUsingDict(string str)
        {
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

            foreach (KeyValuePair<char, int> pair in dict.OrderBy(e => e.Key))
            {
                if (pair.Value > 1)
                {
                    Console.Write(pair.Key + "" + pair.Value);
                }
                else
                    Console.Write(pair.Key);
            }

        }
    }
}
