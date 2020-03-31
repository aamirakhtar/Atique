using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Atique.Arraylist
{
    class EntryPoint
    {
        public static void Main()
        {
            #region Array List
            //So dot net created one datastructure named ArrayList which has all pros of arrays and lists both.
            /*
             * We can access/get any element at any position in single clock cycle via index eg int a = lst[10];
             * We can add/delete data from the arraylist in single clock cycle just like linklist
             * we can have any type of data on any node just like linklist
             */

            ArrayList arrayList = new ArrayList(5);

            //you can grow arrayList just like link list
            arrayList.Add(34);
            arrayList.Add("aamir");
            arrayList.Add(new Vitz1999());
            arrayList.Add(56);
            arrayList.Add(61);

            arrayList.Add(70);

            //arrayList.Remove(70);

            //arrayList.RemoveAt(3);

            //array list traversal is just like array means you can run loop on index
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); //you can get elements just like array
            }

            //Array list has cost/overhead/drawback of typecasting
            int a = (int)arrayList[0];
            string s = (string)arrayList[1];
            Vitz1999 vitz = (Vitz1999)arrayList[2];

            #endregion

            #region Templated Lists/Generic Lists

            //Now you can make list of a particular type, and again it has powers of both the datastructures which are arrays and link lists.
            //So that said, its a wrapper of Array List, or its a typed wrapper of arraylist

            Console.WriteLine("************************** Generic List *************************");

            List<object> lstArray = new List<object>(5);// its same as Array List

            List<int> lst = new List<int>(5);// its same as arraylist
            
            lst.Add(45);
            lst.Add(60);

            lst.Add(56);
            lst.Add(40);
            lst.Add(80);

            lst.Remove(45);
            lst.RemoveAt(2);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]); //you can get elements just like array
            }

            Console.WriteLine("************************* foreach loop ***************************");

            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

            //So it has single clock cycle reading capbility of arrays
            //It has addition/deletion of single clock cycle like link list
            //Plus we can specify the type of whole list to get rid of type casting.
            //And we can use LINQ in templated lists which is not the part of array or arraylist

            #endregion

            #region Dictionary

            // Its a key value pair collection. Means its used to lookup something with unique key
            // A key must be unique
            // It behaves like a List of Key Value Pairs

            Dictionary<string, string> students = new Dictionary<string, string>();

            students.Add("1001", "ateeque");
            students.Add("24567", "aamir");
            students.Add("33213123231", "noman");
            students.Add("43231", "imran");

            students.Remove("5");

            string studentName = students["1001"];

            foreach(KeyValuePair<string, string> student in students)
            {
                Console.WriteLine("{0}: {1}", student.Key, student.Value);
            }

            #endregion

            Console.ReadLine();
        }
    }
}