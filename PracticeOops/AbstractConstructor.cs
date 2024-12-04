using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    //in parameter contructor you explicity write base() and need to implement contructor in every inherited class
    // in non-parameterized class not need to implement base() keyword and not need constrcutor in every inherited class
    public abstract class AbstractConstructor
    {
        public AbstractConstructor(string message)
        {
            Console.WriteLine("This is constructor of abstract class");
        }
        public abstract void Speak();
    }
    public class Dog2 : AbstractConstructor
    {
        public Dog2() : base("hello")
        {
            Console.WriteLine("This is constructor of Dog class");
        }
        public override void Speak()
        {
            Console.WriteLine("Dog barks....");
        }


    }
    public class Cat2 : AbstractConstructor
    {
        public Cat2() : base("hello")
        {
            Console.WriteLine("This is constructor of Cat class");
        }
        public override void Speak()
        {
            Console.WriteLine("Cat meows....");
        }

    }
}
