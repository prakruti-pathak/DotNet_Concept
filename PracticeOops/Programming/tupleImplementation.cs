using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class tupleImplementation
    {
        //they allow a maximum of 8 elements
        public void PersonDetails()
        {
            var person = (Id: 1, name: "abc", age: 10);//named tuples
            Tuple<int,string,int> person1 = Tuple.Create(1,"abc",10); //unnamed tuple
            Tuple<int, string, int> person2= new Tuple<int, string, int>(1, "abc", 10);
            var person3 = (1, "abc", 10);
            Console.WriteLine(person3.Item1);

        }
        public static (string, int) GetPerson()
        {
            return ("abc", 10);
        }

    }
}
