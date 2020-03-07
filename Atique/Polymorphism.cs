using System;

namespace Atique
{
    #region Overriding/Dynamic Polymorphism/Specialization
    #region Example of Ateeq
    class NayyarAzam : Human
    {
        virtual public string favouriteDish => "paay"; //property

        virtual public void Speak()
        {
            Console.WriteLine("Speaks Punjabi");
        }
    }

    class Ateeque : NayyarAzam
    {
        override public string favouriteDish => "Biryani";

        public override void Speak()
        {
            Console.WriteLine("He can speak in Urdu as well.");
        }
    }
    #endregion

    #region Example of CAR
    class Vitz1999
    {
        public virtual string engine => "VVTi";

        public string steering => "Power Steering";
        public string brakes => "ABS";

        virtual public void Drive()
        {
            Console.WriteLine("Manual Drive");
        }

        public void Airconditioning()
        {
            Console.WriteLine("Manual Climate Control AC");
        }
    }

    class Vitz2005 : Vitz1999
    {
        public override string engine => "iVTec";

        public override void Drive()
        {
            Console.WriteLine("Automatic Drive");
        }
    }
    #endregion

    #region IPhone
    class IPhone5s
    {
        public virtual string rearCamera => "5mp";
        public virtual string frontCamera => "2mp";
        public virtual string ram => "2gb";
        public virtual string screenSize => "4inches";

        public string operatingSystem => "IOS";
        public string syncing => "ICloud";

        public virtual void VideoRecording()
        {
            Console.WriteLine("Full HD Video Recording");
        }

        public virtual void Calling()
        {
            Console.WriteLine("3G calling");
        }
    }

    class IPhone6s : IPhone5s
    {
        public override string rearCamera => "8mp";
        public override string frontCamera => "5mp";

        public override string screenSize => "5inches";
    }

    class IPhone8 : IPhone6s
    {
        public override string rearCamera => "12mp";
        public override string frontCamera => "8mp";
        public override string ram => "3gb";

        public override void VideoRecording()
        {
            Console.WriteLine("4k Video recording");
        }

        public override void Calling()
        {
            Console.WriteLine("4G calling");
        }
    }

    #endregion
    #endregion

    #region Static Polymorphism/Method(Function) Overloading/Overloading

    class Calculator
    {
        #region rule "a" Number of the parameters
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        #endregion

        #region rule "b" Type of the parameters
        public void Add(int x, double y)
        {
            Console.WriteLine(x + y);
        }
        #endregion

        #region rule "c" order of the type of the parameters
        public void Add(double x, int y)
        {
            Console.WriteLine(x + y);
        }
        #endregion
    }

    #endregion

    class EntryPoint1
    {
        public static void PolymorphismMain()
        {
            Console.WriteLine("*************************Iphone 5s**************************");
            IPhone5s iphone5s = new IPhone5s();
            Console.WriteLine("5s Front Camera:" + iphone5s.frontCamera);
            Console.WriteLine("5s Rear Camera:" + iphone5s.rearCamera);
            Console.WriteLine("5s RAM:" + iphone5s.ram);
            Console.WriteLine("5s Screen Size:" + iphone5s.screenSize);

            iphone5s.Calling();
            iphone5s.VideoRecording();

            Console.WriteLine("*************************Iphone 6s**************************");

            IPhone6s iphone6s = new IPhone6s();
            Console.WriteLine("6s Front Camera:" + iphone6s.frontCamera);
            Console.WriteLine("6s Rear Camera:" + iphone6s.rearCamera);
            Console.WriteLine("6s RAM:" + iphone6s.ram);
            Console.WriteLine("6s Screen Size:" + iphone6s.screenSize);

            iphone6s.Calling();
            iphone6s.VideoRecording();

            Console.WriteLine("*************************Iphone 8**************************");

            IPhone8 iphone8 = new IPhone8();
            Console.WriteLine("8 Front Camera:" + iphone8.frontCamera);
            Console.WriteLine("8 Rear Camera:" + iphone8.rearCamera);
            Console.WriteLine("8 RAM:" + iphone8.ram);
            Console.WriteLine("8 Screen Size:" + iphone8.screenSize);

            iphone8.Calling();
            iphone8.VideoRecording();

            Console.WriteLine("*************************Nayyar Azam**************************");
            NayyarAzam obj = new NayyarAzam();
            Console.WriteLine("Favourite Dish:" + obj.favouriteDish);
            obj.Speak();

            Console.WriteLine("*************************Ateeque Azam**************************");
            Ateeque ateeq = new Ateeque();
            Console.WriteLine("Favourite Dish:" + ateeq.favouriteDish);
            ateeq.Speak();

            Console.WriteLine("*************************Vitz1999**************************");

            Vitz1999 vitz99 = new Vitz1999();
            Console.WriteLine("Vitz 1999 Engine:" + vitz99.engine);
            Console.WriteLine("Vitz 1999 Steering:" + vitz99.steering);
            Console.WriteLine("Vitz 1999 Brakes:" + vitz99.brakes);

            vitz99.Drive();
            vitz99.Airconditioning();

            Console.WriteLine("*************************Vitz2005**************************");

            Vitz2005 vitz05 = new Vitz2005();
            Console.WriteLine("Vitz 2005 Engine:" + vitz05.engine);
            Console.WriteLine("Vitz 2005 Steering:" + vitz05.steering);
            Console.WriteLine("Vitz 2005 Brakes:" + vitz05.brakes);

            vitz05.Drive();
            vitz05.Airconditioning();

            Console.WriteLine("*************************Calculator**************************");
            Calculator calc = new Calculator();
            calc.Add(1, 2);
            calc.Add(1, 2, 3);
            calc.Add(1.5, 5);
            calc.Add(2, 6.5);

            Console.ReadLine();
        }
    }
}