using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class varVSdynamic
    {
        public void KeywordDemo()
        {
            //var datatype is used to declare a variable without specifying its type
            //var datatype is staticly type 
            //use right->left while declartion is check right side value and mark datatype as that datatype

            var a = 10;
            var i = "hello";
            dynamic j = "hello";
            //Console.WriteLine(j.Count()); //error because Count is in integer not in string but in dynamic we can declare it but cause error in runtime
            Console.WriteLine(j.Length);//execute because Length() used in string
        }
    }
}
