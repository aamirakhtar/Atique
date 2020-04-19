using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Structures
{
    public class EntryPoint
    {
        public static void Main()
        {
            int a = 10;
            int b = a;

            b = 30;

            PersonC pc3;
            Person p3; //In case of structure C# always make object and assign to struct variable, as by default it will alwyas make object thats why we cannot define default constructor.

            //Copy by Refenrce
            PersonC pc1 = new PersonC();
            pc1.Name = "Aamir";

            PersonC pc2 = pc1; //Its a copy by reference, means pc1 and pc2 both refering to same object
            pc2.Name = "Atique";

            //Copy by Value
            Person p1 = new Person(); //Its a copy by value, means p1 and p2 both refering to their own objetcs and both have copies in RAM
            p1.Name = "Aamir";

            Person p2 = p1;
            p2.Name = "Atique";
        }
    }

    public struct Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public int CompareTo(Person obj)
        {
            return this.Name == obj.Name ? 0 : 1;
        }

        //public Person()
        //{
        //    this.Name = "";
        //    this.Gender = "";
        //    this.Address = "";
        //}
    }

    public class PersonC
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }

    public struct Color
    {
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }
    }
}
