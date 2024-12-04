using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Partialclass
{
    public partial class PartialClass
    {
        public PartialClass(int a) { }
        partial void Display()
        {
            Console.WriteLine("This is partial method");
        }
    }
}
