// See https://aka.ms/new-console-template for more information
using PracticeOops;
using PracticeOops.Programming;
using PracticeOops.Reflection;
using PracticeOops.Threads;
using System;
using System.Reflection;
using System.Timers;
using static PracticeOops.Programming.DelegateImplementation;


//Console.WriteLine("Example for encapsulation");
//Encapsulation1 e1 = new Encapsulation1();
//e1.SetColour("red");
//Console.WriteLine(e1.GetColour());


//Console.WriteLine("Example for inheritance");
//Car c1 = new Car();
//c1.Model = "Verna";
//c1.Drive();
//c1.Colour();
//Console.WriteLine(c1.Model);

////Runtime override
//Console.WriteLine("Example for Polymorphism");
//Polymorphism p1 = new Polymorphism();
//Polymorphism d1 = new Dog();
//Polymorphism c2= new Cat();
//p1.Speak();
//d1.Speak();
//c2.Speak();

////Complile time, Overloading
//Console.WriteLine("Example for Polymorphism(Method Overloading)");
//MethodOverloading m1 = new MethodOverloading();
//Console.WriteLine(m1.Add(1, 2));
//Console.WriteLine(m1.Add(1.6, 2.4));
//Console.WriteLine(m1.Add("hello", "hii"));

//Abstraction
//Console.WriteLine("Example of Abstraction");
//Dog1 ab1 = new Dog1();
//ab1.Speak();
//Cat1 ab2 = new Cat1();
//ab2.Speak();



//Bank Account
//Example of Encapsulation
//BankAccount b1 =new BankAccount(100);
//Console.WriteLine("Show balance: "+(b1.ShowBalance()));

//b1.DepositBalance(10);
//Console.WriteLine("Show balance after deposit: " + (b1.ShowBalance()));

//b1.WithdrawBalance(10);
//Console.WriteLine("Show balance after withdraw: " + (b1.ShowBalance()));

////Email Service
////Example of Abstraction
//EmailService emailService = new EmailService();
//emailService.SendEmail();

//Array list
//ArrayImplementation array = new ArrayImplementation();
//array.ArrayList1();

//Delegate
//TestDelegate td = new TestDelegate(MyTestDelegateFunction);
//td("hello how you doing");
//// You can change the delegate to another method at runtime
//td = MyTestDelegate;
//td("Hey! Don't forget the meeting at 3 PM.");

////Lamba Function Example
//lambaexpression le = new lambaexpression();
//le.lambaExample();

//Generic Implementation
//GenericImplementation<int> g = new GenericImplementation<int>();
//g.SetValue(100);
//Console.WriteLine(g.GetValue());

//GenericImplementation<string> gstring = new GenericImplementation<string>();
//gstring.SetValue("Hello, How are you??");
//Console.WriteLine(gstring.GetValue());

//GenericMethod gm = new GenericMethod();
//Console.WriteLine(gm.GenericMethodI("hello","hii"));
//Console.WriteLine(gm.Add(10, 20));

//Enumerations e = new Enumerations();
//// Using the enum to store a value
//DaysOfWeek today = DaysOfWeek.Monday;

//// Printing the value
//Console.WriteLine($"Today is: {today}");

//// If you need the numeric value
//int numericDay = (int)today;
//Console.WriteLine($"Numeric value of today: {numericDay}");

////Async Await
//AsyncAwait asyncAwait = new AsyncAwait();   
//asyncAwait.GenerateNumbersAsync();


//Yield Key use
//yieldClass.ProcessPeople();

/********************************************************************REFLECTION*************************************************************************************************************/

Type T = Type.GetType("PracticeOops.Reflection.ReflectionClass");

//2nd Method
//Type T = typeof(ReflectionClass);

//3rd Method
//ReflectionClass rc=new ReflectionClass();
//Type T = rc.GetType();

PropertyInfo[] properties = T.GetProperties();
Console.WriteLine("Class Name: " + T.Name);
Console.WriteLine("Full Name: " + T.FullName);
Console.WriteLine("Namespace: " + T.Namespace);
Console.WriteLine();
//properties
Console.WriteLine("Properties: ");
foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.PropertyType.Name + " " + property.Name);
    
}
Console.WriteLine();
//method
Console.WriteLine("Methods:");
MethodInfo[] methods = T.GetMethods();
foreach (MethodInfo method in methods)
{
        Console.WriteLine(method.ReturnType.Name + " " + method.Name);
}

Console.WriteLine();
//constructor
Console.WriteLine("Constructors:"); 
ConstructorInfo[] constructors = T.GetConstructors();
foreach (ConstructorInfo constructor in constructors)
    {
    Console.WriteLine(constructor.Name);
    Console.WriteLine(constructor.ToString());
}
/********************************************************************REFLECTION*************************************************************************************************************/

varVSdynamic vd= new varVSdynamic();
vd.KeywordDemo();

Console.ReadLine();
