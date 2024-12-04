// a delegate lets you assign the responsibility of calling a method (function) to another part of your code.
//It’s like creating a list of instructions (methods), and then giving that list to someone (a delegate) who will know when to execute the instructions.
//public delegate returnType DelegateName(parameterType1 param1, parameterType2 param2, ...);

//a delegate is a variable that holds the reference to a methods or pointer to a method
// a delegate can refer to more than one method of same type and paramter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{ 
//delgate is pointer to function
    public class DelegateImplementation
    {
        public delegate void TestDelegate(string message);
        public static void MyTestDelegateFunction(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
        public static void MyTestDelegate(string message)
        {
            Console.WriteLine("Another Email: " + message);
        }
        //Func Delegate:
        //Func can be used when you want to pass around methods that return a value.
        //It can take up to 16 input parameters,and one output parameter but always returns a value.
        public void funcDelgate()
        {
            Func<int,int,int> addNumber =(x,y)=>x+y;
            int result=addNumber(1,2);
            Console.WriteLine(result);
        }
        //it consist only input parameter only it not contain return parameter
        //it call action because it not return any parameter
        //16 parameter
        public void actionDelegate()
        {
            Action<string> printString=message=>Console.WriteLine(message);
            printString("Hello");
        }
        //predicate delegate
        //it return only true or false
        public void predicateDelegate()
        {
            Predicate<int> isEven = x => x % 2 == 0;
            bool result = isEven(4); // Returns true
            Console.WriteLine(result);
        }

    }
}
