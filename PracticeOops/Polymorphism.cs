using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class Polymorphism
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes sound....");
        }
    }
    public class Dog : Polymorphism
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks....");
        }

    }
    public class Cat : Polymorphism
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows....");
        }

    }
}
