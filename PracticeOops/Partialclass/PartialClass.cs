using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Partialclass
{
    // partial class must be in same namespace
    //using same access modifier
    //same name of class
    public partial class PartialClass
    {
        //partial constructor define in one class only we can define different constructor in other partial class
        //for example parameter constructor
    
        public PartialClass() { }
        //partial method is implement in partial class only
        // in one class it should be without implementation
        // in another class it should be with implementation
        partial void Display();
    }
}
