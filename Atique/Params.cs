using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Params
{
    class EntryPoint
    {
        public static void Main()
        {
            //Without params calling
            int[] arr1 = new int[3] { 10, 20, 30 };
            int[] arr2 = new int[4] { 40, 60, 70, 57 };
            int[] arr3 = new int[5] { 40, 60, 70, 57, 50 };

            int r1 = Calculator.Add(arr1);
            int r2 = Calculator.Add(arr2);
            int r3 = Calculator.Add(arr3);

            //Calling with params for same function
            //This is calling code. Calling code is suppose to bother about the int array parameter in case of params, it will call the function normally like we dont use array
            //In case of params you dont need to explicitly declare array and pass it to the function, rather you just suppose to call function like it doesnt accept array.
            Calculator.Sum(10, 22);
            Calculator.Sum(14, 27, 99);
            Calculator.Sum(56, 78, 54, 89);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            Console.ReadLine();
        }
    }

    class Calculator
    {
        public static int Add(int[] arr) //without params
        {
            return arr.Sum();
        }

        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static int Sum(int a, int b, int c, int d)
        //{
        //    return a + b + c;
        //}

        public static int Sum(params int[] arr)
        {
            return arr.Sum();
        }
    }
}
