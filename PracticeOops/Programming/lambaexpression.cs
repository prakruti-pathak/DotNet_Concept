using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class lambaexpression
    {
        public void lambaExample()
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            var square = list.Select(x => x * x);
            foreach (var x in square)
            {
                Console.WriteLine(x);
            }
        }

 
    }
}
