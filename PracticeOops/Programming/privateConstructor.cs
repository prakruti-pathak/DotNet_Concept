using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    //every top level classes(means you should not define private class) of namespace should be public or internal
    //only nested private class in acceptable
    public class privateConstructor
    {
        private privateConstructor() { }

    }

    //when you use private constructor it not able to inherited other class from that class
    //public class privateConstructor1 : privateConstructor
    //{

    //}
    //nested private class
    //in nested class private constructor is accessible in nested class
    public class privateConstructor1
    {
        private privateConstructor1() { }
        public class privateConstructor2
        {
            private privateConstructor2() { }
        }

        public class privateConstructor3 : privateConstructor1
        {

        }
    }

}
