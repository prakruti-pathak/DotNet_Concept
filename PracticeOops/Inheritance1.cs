using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class Inheritance1
    {
        public string Model;
        public void Drive()
        {
            Console.WriteLine("Person is driving a car");
        }
    }
    public class Car : Inheritance1
    {
        public void Colour()
        {
            Console.WriteLine("Colour of car is red");
        }
    }

}
