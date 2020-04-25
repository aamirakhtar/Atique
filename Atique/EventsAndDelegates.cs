using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using File.Processing;

namespace Atique.EventsAndDelegates
{
    class EntryPoint
    {
        public static void Main()
        {
            //Pointers: it can indirectly change the value of a variable without accessing that variable
            //Delegate is a function pointer: Same as pointers it can indirectly call the function without accessing that function
            //Delegate is used for loose coupling

            PrintName();

            PrintDelegate del = PrintName;
            del();

            var lst1 = Search.SearchNumbers(new List<int>() { 1, 2, 3, 4, 45, 60, 78, 9, 14, 13, 12 }, Filter1);

            var lst2 = Search.SearchNumbers(new List<int>() { 1, 2, 3, 4, 45, 60, 78, 9, 14, 13, 12 }, Filter2);

            var lst3 = Search.SearchNumbers(new List<int>() { 1, 2, 3, 4, 45, 60, 78, 9, 14, 13, 12 }, Filter3);

            //Func f = Add;
            //f(1, 2);

            //Func f2 = Sub;
            //f2(2, 4);

            //File Processing with Delegate
            FileProcessing fileProcessing = new FileProcessing();
            fileProcessing.notification = SendEmail;
            fileProcessing.notification += SendSms; //Multicast Delegate
            fileProcessing.notification = null; //Its an alteration of subscription list
            fileProcessing.notification += SendWatsappMsg; //Subscribe
            fileProcessing.notification -= SendWatsappMsg; //UnSubscribe

            //Here fileProcessing.notification is a publisher, and SendEmail, SendSms, SendWatsapp are subscribers.
            //But problem is the delegate is not a true publisher subscriber model bcz we can anytime alter the list of subscribers

            //So to implement the publisher subscriber model in true sense we have Events in c#
            //So Events are nothing but wrapper of delegates in which only owner of the subscription list can alter the list, and no outside alteration is possible

            //File Processing with Event
            //Same file processing with publisher subscriber model that is event
            FileProcessing fileProcessing1 = new FileProcessing();
            fileProcessing1.notificationEvent += SendEmail;
            fileProcessing1.notificationEvent += SendSms; //Multicast Delegate
            //fileProcessing1.notificationEvent = null; //In events you cannot alter the subscription list
            fileProcessing1.notificationEvent += SendWatsappMsg; //Subscribe
            fileProcessing1.notificationEvent -= SendWatsappMsg; //UnSubscribe

            fileProcessing.Process();

            Console.ReadLine();
        }

        private static void SendEmail()
        {
            Console.WriteLine("Email Sent.");
        }

        private static void SendSms()
        {
            Console.WriteLine("Sms Sent.");
        }

        private static void SendWatsappMsg()
        {
            Console.WriteLine("Watsapp msg Sent.");
        }

        delegate int Func(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static void PrintName()
        {
            Console.WriteLine("aamir");
        }

        //public static void ShowNumbersTilln(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //        Console.WriteLine(i + 1);
        //}

        //public static List<int> GetNumbersLessThanTen(List<int> numbers)
        //{
        //    List<int> lst = new List<int>();
        //    foreach (int n in numbers)
        //    {
        //        if (n < 10)
        //            lst.Add(n);
        //    }

        //    return lst;
        //}

        //public static List<int> GetNumbersLessThanFive(List<int> numbers)
        //{
        //    List<int> lst = new List<int>();
        //    foreach (int n in numbers)
        //    {
        //        if (n < 5)
        //            lst.Add(n);
        //    }

        //    return lst;
        //}        

        public static bool Filter1(int n)
        {
            return n > 2 && n < 10;
        }

        public static bool Filter2(int n)
        {
            return n > 10;
        }

        public static bool Filter3(int n)
        {
            return n < 9;
        }

        public delegate void PrintDelegate();
    }

    //It resides in different dll
    public class Search
    {
        public delegate bool NumberFilter(int n);

        public static List<int> SearchNumbers(List<int> numbers, NumberFilter filter)
        {
            List<int> lst = new List<int>();
            foreach (int val in numbers)
            {
                if (filter(val))
                    lst.Add(val);
            }

            return lst;
        }
    }
}
