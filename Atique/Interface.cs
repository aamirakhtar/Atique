using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Resources
{
    interface ICar
    {
        //Property Declaration/without body
        string Tires { get; }
        string Engine { get; }
        string Brakes { get; }
        string Price { get; }

        //Function declaration/without body
        void Accelerate();
        void Transmission();
    }

    interface IHatchback
    {
        //Property Declaration/without body
        string Tires { get; }
        string Engine { get; }
        string Brakes { get; }
        string Price { get; }

        //Function declaration/without body
        void Accelerate();
        void Transmission();
    }

    class Vitz2004 : ICar, IHatchback
    {
        //public string Tires => "13 inches";
        //Property Declaration/Definition
        public string Tires
        {
            get
            {
                return "13 inches";
            }
        }

        public string Engine
        {
            get
            {
                return "1SZFE14";
            }
        }

        public string Brakes
        {
            get
            {
                return "ABS";
            }
        }

        public string Price
        {
            get
            {
                return "500,000";
            }
        }

        //Function Definition/ with Body
        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }

        public void Transmission()
        {
            Console.WriteLine("Transmission");
        }

        //Concrete Method
        public void Airconditioning()//heat and cool
        {
            Console.WriteLine("Heat and Cool");
        }
    }
}
