using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    internal class Hashtablee
    {
        public void HashtableImplementation() 
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "string");
            foreach(var i in hashtable)
            {
                Console.WriteLine(i);
            }
        }
    }
}
