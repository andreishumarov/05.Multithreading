using System;
using System.Threading;

namespace Dual_ThreadingUsingThread.Sleep
{
    class Program
    {
        static void Main()
        {
            Thread workerThread = new Thread(new ThreadStart(Print));
            workerThread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(200);
            }
            Console.ReadKey();
        }
        static void Print()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(1000);
    }
        }
    }
}
