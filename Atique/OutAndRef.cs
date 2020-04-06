using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.OutAndRef
{
    class EntryPoint
    {
        public static void Main()
        {
            int x = 10;
            int y = 34;

            int subResult = 10;

            //We have 2 mechanisms to return multiple values from the function:-
            //1-out:-
            //  Its a one way assignment of value from the function to the calling function. Means we cannot pass the value of out parameter inside the function, it will only be used for outing the value.
            //2-ref:-
            //  Its a two way assignment, means we can pass the value inside and get the value out of the function. It will pass even the value types by reference.

            int addResult = AddAndSubOut(x, y, out subResult); //Copy by reference

            Console.WriteLine("add: {0}, sub: {1}", addResult, subResult);

            A o = new A();
            o.AddResult = 10 + 20;
            SomeFunc(o); //Copy by reference

            int a = 10 + 20;
            subResult = 0;
            addResult = AddAndSubRef(x, y, ref subResult); //In case of "ref" Copy by reference

            int num = 0;
            bool isNum = int.TryParse("434353", out num);

            string addr = "";
            string phoneNum = "";
            string em = "";

            int userId = GetUserId("aamir", out addr, out phoneNum, out em); // Multiple outs
        }

        public static int GetUserId(string name, out string addres, out string phoneNumber, out string email)
        {
            addres = "karachi";
            phoneNumber = "03212534148";
            email = "aamiradvantage@gmail.com";

            return 45;
        }

        public static void SomeFunc(A obj)
        {
            obj.AddResult = 70 + 60;
        }

        public static int AddAndSubRef(int a, int b, ref int sub)
        {
            Console.WriteLine(sub);

            sub = a - b;

            int add = a + b;

            return add;
        }

        public static int AddAndSubOut(int a, int b, out int sub)
        {
            sub = a - b;
            int add = a + b;

            return add;
        }

        public class A
        {
            public int AddResult { get; set; }
        }
    }
}
