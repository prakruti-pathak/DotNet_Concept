using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class ArrayImplementation
    {
        public void ArrayList1()
        {
            //array is fixed
            int[] arrayList = new int[10];
            int[] arrayList2 = new int[] { 1, 2, 3, 4 };
            //Listed is dyanamic element can be add
            List<int> list = new List<int>() { 1, 2, 3 };
            list.Add(5);
            list.Remove(5);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
