using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public abstract class Abstraction1
    {
        public Abstraction1() {
            Console.WriteLine("This is constructor of abstract class");}
        public abstract void Speak();
    }
    public class Dog1 : Abstraction1
    {
        public Dog1()
        {
            Console.WriteLine("This is constructor of Dog class");
        }
        public override void Speak()
        {
            Console.WriteLine("Dog barks....");
        }
        

    }
    public class Cat1 : Abstraction1
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows....");
        }

    }
}
