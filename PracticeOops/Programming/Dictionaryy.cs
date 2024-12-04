using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    internal class Dictionaryy
    {
        public void DictionaryImplementation() 
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "abc");
            dictionary.Add(2, "xyz");
            foreach (KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                
            }
        }
    }
}
