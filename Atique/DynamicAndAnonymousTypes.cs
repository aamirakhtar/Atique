using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.DynamicAndAnonymousTypes
{
    class EntryPoint
    {
        public static void Main()
        {
            //Anonymous Types, a type without name
            //Performance overhead in case of anonymous type bcz at runtime CLR will evaluate its type and property types
            //We cannot type cast whole object into other type
            //We must use var keyword in case of anonymous types

            var person1 = new { name = "aamir", age = 36, nationality = "pakistani" }; //loosely typed object
            
            Console.WriteLine("Anonymous Type:- name: {0}, age: {1}, nationality: {2} ", person1.name, person1.age, person1.nationality);

            //Named Type
            //No performance overhead
            //We can type cast Names Types
            //We can or acnnot use var keyword in case of Named Types
            var person2 = new Person(); //strongly typed object
            Console.WriteLine("Named Type:- name: {0}, age: {1}, nationality: {2} ", person2.name, person2.age, person2.nationality);


            //In case of dynamic types we can make any property on the flow.
            //Its easy to use but again its a Loosely Typed and losely coupled object as well as it can contain any property so there is chance of spelling mistake in using property
            //Its like a dynamic dictionary means a key value pair
            dynamic person3 = new ExpandoObject();
            person3.name = "aamir";
            person3.age = 36;
            person3.nationality = "pakistani";
            person3.language = "english";

            person3.dkjsahdkashdkjashk = 3131231312;

            Console.WriteLine("Dynamic Type:- name: {0}, age: {1}, nationality: {2} ", person3.name, person3.age, person3.natinalit);

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
    }
}
