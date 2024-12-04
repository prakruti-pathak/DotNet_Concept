using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    internal class Listt
    {
        public void ListImplementation()
        {
            var list = new List<int>();
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
