using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atique.Multithreading
{
    class EntryPoint
    {
        public static object tempLock { get; set; }

        public static int counter { get; set; }

        public static int counter1 { get; set; }
        public static int counter2 { get; set; }
        public static int counter3 { get; set; }

        public static void Main()
        {
            Console.WriteLine("Main thread starts.");
            tempLock = new object();

            //Sequential Execution
            //ShowNumbers1(); //email
            //ShowNumbers2(); //db
            //ShowNumbers3(); //sms

            //Multithreading

            #region Time Sharing and context switching
            /*
            //For maximum utilization of the CPU resources
            //We acheive performance through multithreading, means a task can be completed in minimum time as compared to sequential execution
            //All threads will be started and there will be context switching b/w them, means processor doesnt wait for the completion of one thread to start the execution of antoher.

            Thread thread1 = new Thread(ShowNumbers1);
            Thread thread2 = new Thread(ShowNumbers2);
            Thread thread3 = new Thread(ShowNumbers3);

            thread1.Start(); // email
            thread2.Start(); // database
            thread3.Start(); // sms
            */
            #endregion

            #region Joining
            //Joining- Means Main will be waiting for the completeion of thread 1, means main and thread1 are joined together just like a sequential execution of the two
            //thread1.Join();
            //thread1.Join(1000); //Means the Main will be waiting for 1 second or 1000ms for the comepletion of thread1, if thread1 completes in 1 second then its fine else main will exit.

            //thread2.Join();
            //thread3.Join();
            #endregion

            #region Locking
            /* Locking:
             *  We want following output of the 3 threads which access on file:-
             *  t1: Atique is a good man
                t2: C# is a good language
                t3: Aamir is a good teacher

            if locking is not used then the output would be like as follows, which is corrupted:-
                t1:Atique is a t2:C# is a t3:Aamir is t1:good t2:good language t3:a good t1:man


             */

            //ShowName1();
            //ShowName2();
            //ShowName3();

            //Thread t1 = new Thread(ShowName1);
            //Thread t2 = new Thread(ShowName1);
            //Thread t3 = new Thread(ShowName1);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //AddCounter();
            //AddCounter();
            //AddCounter();

            //counter = 0;

            //Thread t1 = new Thread(AddCounter);
            //Thread t2 = new Thread(AddCounter);
            //Thread t3 = new Thread(AddCounter);

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.WriteLine(counter);
            #endregion

            #region Thread Priority

            //The more the priority the more the CPU resources will be used for thread execution
            /*
            Thread t1 = new Thread(AddCounter1ForPriorityCheck);
            Thread t2 = new Thread(AddCounter2ForPriorityCheck);
            Thread t3 = new Thread(AddCounter3ForPriorityCheck);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(3000);

            t1.Abort();
            t2.Abort();
            t3.Abort();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(counter1);
            Console.WriteLine(counter2);
            Console.WriteLine(counter3);
            */
            #endregion

            #region Performace counters

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            ForPerformanceEvaluation();
            ForPerformanceEvaluation();
            ForPerformanceEvaluation();

            sw1.Stop();

            Console.WriteLine("Time Taken by sequential execution: {0}", sw1.ElapsedMilliseconds);

            Thread t1 = new Thread(ForPerformanceEvaluation);
            Thread t2 = new Thread(ForPerformanceEvaluation);
            Thread t3 = new Thread(ForPerformanceEvaluation);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            t1.Start();
            t2.Start();
            t3.Start();

            sw2.Stop();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Time Taken by multithreaded execution: {0}", sw2.ElapsedMilliseconds);

            #endregion

            Console.WriteLine("Main thread Ends.");
            Console.ReadLine();
        }

        public static void ForPerformanceEvaluation()
        {
            for (int i = 0; i < 10000000; i++)
                counter++;
        }

        public static void AddCounter1ForPriorityCheck()
        {
            while (true)
            {
                counter1++;
            }
        }

        public static void AddCounter2ForPriorityCheck()
        {
            while (true)
            {
                counter2++;
            }
        }

        public static void AddCounter3ForPriorityCheck()
        {
            while (true)
            {
                counter3++;
            }
        }

        public static void AddCounter()
        {
            Console.Write("I am a good");

            lock (tempLock)
            {
                for (int i = 0; i < 10000; i++)
                    counter = counter + 1;
            }

            Console.WriteLine("man and i live in karachi");
        }

        public static void ShowName1()
        {
            lock (tempLock)
            {
                Console.Write("t1: Atique is ");
                Thread.Sleep(1000);
                Console.WriteLine("a good man");
            }
        }

        //public static void ShowName2()
        //{
        //    lock (tempLock)
        //    {
        //        Console.Write("t2: C# is a ");
        //        Thread.Sleep(1000);
        //        Console.WriteLine("good language");
        //    }
        //}

        //public static void ShowName3()
        //{
        //    lock (tempLock)
        //    {
        //        Console.Write("t3: Aamir is a ");
        //        Thread.Sleep(1000);
        //        Console.WriteLine("good teacher");
        //    }
        //}


        public static void ShowNumbers1()
        {
            Console.WriteLine("ShowNumbers1 starts");
            for (int i = 0; i < 50; i++)
            {
                if (i == 25)
                {
                    Console.WriteLine("Thread1 going to sleep.");
                    Thread.Sleep(3000); // 3 second
                    Console.WriteLine("Thread1 woke up.");
                }

                Console.WriteLine("Thread 1: {0}", i + 1);
            }
            Console.WriteLine("ShowNumbers1 ends");
        }

        public static void ShowNumbers2()
        {
            Console.WriteLine("ShowNumbers2 starts");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread 2: {0}", i + 1);
            }
            Console.WriteLine("ShowNumbers2 ends");
        }

        public static void ShowNumbers3()
        {
            Console.WriteLine("ShowNumbers3 starts");
            for (int i = 0; i < 50; i++)
                Console.WriteLine("Thread 3: {0}", i + 1);
            Console.WriteLine("ShowNumbers3 ends");
        }
    }
}
