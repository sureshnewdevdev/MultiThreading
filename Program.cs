using MultiThreading;
using System;
using System.Threading;

 
 

class Program
{
    // Method to be executed by the thread
    static void PrintNumbers()
    {
        SalesAccount account = new SalesAccount();

        object o = new object();
        
        for (int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= 80; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine($"Number: {i} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
            // Pause the thread for a second
            Thread.Sleep(1000);
        }
    }

    static void PrintNumbers2()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 80; j++)
            {
                Console.Write("$");
            }
            Console.WriteLine($"Number: {i} (Thread ID: {Thread.CurrentThread.ManagedThreadId})");
            // Pause the thread for a second
            Thread.Sleep(3000);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Starting.");

        // Create a new thread that will run the PrintNumbers method
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers2);

        // Start the threads
        thread1.Start();
        thread2.Start();

        //// Join the threads, ensuring the main thread waits until the threads finish execution
        //thread1.Join();
        thread2.Join();

        Console.WriteLine("Main Thread Finished.");
    }
}
