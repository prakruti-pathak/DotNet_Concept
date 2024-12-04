using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    //child initializer
    //parent initializer
    //parent constructor
    //child constructor
    public class Initializer_Constructor
    {
        int i = 0; //initializer
        public Initializer_Constructor() //parent constructor
        {
            Console.WriteLine("This is a constructor");
        }
    }
    public class Class_Implementing_Constructor: Initializer_Constructor
    {
        public int i = 0; //initializer
        public Class_Implementing_Constructor() //child constructor
        {
            Console.WriteLine("This is a constructor");
        }
    }   
}
