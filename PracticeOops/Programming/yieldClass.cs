using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class yieldClass
    {
        public static void ProcessPeople()
        {
            //When you declare var people = GetPeople(10000);, it does not immediately call GetPeople and populate the people collection with all 10,000 Person objects. Instead, it creates an enumerator (an object that can iterate over the sequence)
            ////that will execute GetPeople when iterated over.
            ///state machine generator
            var people = GetPeople(10000);
            foreach (var item in people)
            {
                if(item.Id<1000)
                    Console.WriteLine(item.Name);
                else
                    break;
            }
        }
        //public static IEnumerable<Person> GetPeople(int count)
        //{
        //    List<Person> people = new List<Person>();
        //    for (int i = 0; i < count; i++)
        //    {
        //        people.Add(new Person()
        //        {
        //            Id = i,
        //            Name = "Person " + i
        //        });
               
        //    }
        //    return people;
        //}
        public static IEnumerable<Person> GetPeople(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Person()
                {
                    Id = i,
                    Name = "Person " + i
                };
            }      
        }

    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
