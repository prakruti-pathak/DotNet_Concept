using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    internal class ArrayListt
    {
        public void Implemetation()
        {
            ArrayList array1 = new ArrayList();
            array1.Add(1);
            array1.Add(2);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            string a = "hello";
            a.Reverse();
        }
        
    }
}
