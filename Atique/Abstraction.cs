using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Abstraction
{
    #region Abstraction
    //Conceptual Level
    //a-When you dont suppose to bother about the functionality when using something
    abstract class CoffeeMaker
    {
        //Function declaration
        public abstract void CoffeeMaking();
    }

    abstract class FacebookCommenting
    {
        public abstract void Commenting();
    }

    //Conceptual Level
    //b-When you are at the top level and you dont suppose to bother about the details and real functionality
    abstract class HatchBack
    {
        public abstract string Tires { get; }
        public abstract string Engine { get; }
        public abstract string Brakes { get; }
        public abstract string Price { get; }

        public abstract void Accelerate();
        
        public abstract void Transmission();

        //Concrete Method
        public void Airconditioning()//heat and cool
        {
            Console.WriteLine("Heat and Cool");
        }
    }

    abstract class IPhone
    {
        public abstract string Camera { get; }
        public abstract string ScreenSize { get; }
        public abstract string MultiTouch { get; }
        public abstract string color { get; }
        public virtual string OS => "IOS";//Its a normal polymorphism. Concrete property or functionality is possible in abstract class, bcz we can spcify something still in a concept.

        public abstract void VideoRecording();
        public abstract void Calling();
        public abstract void Messaging();       
    }

    class Iphone6S : IPhone
    {
        public override string OS => "IOS v:12";

        public override string Camera => "12mp";

        public override string ScreenSize => "6inch";

        public override string MultiTouch => "10 Tocuh";

        public override string color => "white";

        public override void Calling()
        {
            Console.WriteLine("Watsapp calling, Facetime Calling, 3g calling");
        }

        public override void Messaging()
        {
            Console.WriteLine("Imessaging");
        }

        public override void VideoRecording()
        {
            Console.WriteLine("Full HD Video Recording");
        }

        //public abstract void ThreeDGaming();//We cannot have conceptual property or functionality in a concrete class, we must define or specify property or functionality for a concrete class
    }
    #endregion

    class EntryPoint
    {
        public static void AbstractMain()
        {
            //IPhone obj = new IPhone();//object cannot be made bcz its a concept or abstract class

            Iphone6S iphone6s = new Iphone6S();
            Console.WriteLine(iphone6s.Camera);
            Console.WriteLine(iphone6s.MultiTouch);
            Console.WriteLine(iphone6s.color);
        }
    }
}