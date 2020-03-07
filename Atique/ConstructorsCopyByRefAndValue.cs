using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace is just like a folder.. just the storage mechanism is different. Folder provides physical grouping of files, while namespace provides logical grouping
namespace Atique.CSharp.ConstructorsCopyByRefAndValue
{
    /*
     * There are 3 types constructors
     * 1-Default Constructor (Parameterless Constructor)
     * 2-Overloaded Constructor (Parameterized Constructor)
     * 3-Copy Constructor (It takes object of same class as a parameter)
     * 
     * Default Constructor is in every class by default whether you define or not.
     * Default Static Constructor is in every class by default whether you define or not.
     */

    public class Vitz
    {
        //1-Default Constructor
        public Vitz()
        {
            this.steering = "Power Steering";
            this.Gear = "Manual";
            this.Tires = "13 inch";
            this.Engine = "1000cc";

            Console.WriteLine("Default Constructor Vitz");
        }

        public string steering { get; set; }
        public string Tires { get; set; }
        public string Engine { get; set; }
        public string Gear { get; set; }

        virtual public void Drive()
        {
            Console.WriteLine("Manula Drive");
        }
    }

    public class Vitz2005 : Vitz
    {
        //2-Default Constructor
        public Vitz2005()
        {
            Console.WriteLine("Default Constructor Vitz2005");
        }

        //2-Overloaded Constructor
        public Vitz2005(string tires)
        {
            this.Tires = tires;
        }

        //2-Overloaded Constructor
        public Vitz2005(string tires, string engine)
        {
            this.Tires = tires;
            this.Engine = engine;
        }

        //2-Overloaded Constructor
        //3-Copy Constructor
        public Vitz2005(Vitz2005 vitz05)
        {
            this.Engine = vitz05.Engine;
            this.Gear = vitz05.Gear;
            this.Tires = vitz05.Tires;
            this.Engine = vitz05.Engine;
        }

        struct Vitz2002
        {
            public string steering { get; set; }
            public string Tires { get; set; }
            public string Engine { get; set; }
            public string Gear { get; set; }
        }
    }

    /*
     * 1-Reference Types
     * 2-Value Types
     */

    public class EntryPoint
    {
        public static void Main()
        {
            Vitz v = new Vitz();

            Vitz2005 vitz2005 = new Vitz2005();

            Vitz2005 vitz05 = new Vitz2005("14 inch");
            Vitz2005 v2005 = new Vitz2005("15 inch", "1300cc");

            //Reference  =  Object
            Vitz2005 v05 = new Vitz2005();
            v05.Engine = "1500cc";
            v05.steering = "Power Multimedia Steering";
            v05.Gear = "Trintronic Gear";
            v05.Tires = "16 inch";

            
            Vitz2005 v05_copy = new Vitz2005(v05); //Here copy of the object is created by Copy Constructor
            v05_copy.Engine = "1000cc";

            //Copy by reference
            Vitz2005 v05_copy1 = v05; //Here copy of the reference is created
            v05_copy1.Engine = "1800cc";

            //Engine becomes 1800cc for both references
            Console.WriteLine(v05_copy1.Engine);
            Console.WriteLine(v05.Engine);

            //Primitive
            int i = 2;
            int b = i;//Copy by value

            b = 3;

            Console.WriteLine(b);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}