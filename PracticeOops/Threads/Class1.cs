using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void RunThreads()
        {
            Thread thread1 = new Thread(() => PrintThread());
            Thread thread2 = new Thread(() => PrintThread());
            Thread thread3 = new Thread(() => PrintThread());
            thread1.Start();
            thread2.Start();
            thread3.Start();


        }
        public static void PrintThread()
        {

            Console.WriteLine($"Hello from thread with ID: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
