using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Reflection
{
    //Reflection is the ability of inspecting an assemblies metadata at runtime
    //if there are multiple methods and properties and don't know what to called than reflection is useed
    public class ReflectionClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ReflectionClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public ReflectionClass()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("Id = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
