using DataAccessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique
{
    class Human
    {
        private string legs { get; set; }
        private string hands { get; set; }
        private string brain { get; set; }

        public string mobilePhone { get; set; }
        public string car { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }

        private string Address { get; set; }
        private string mobileNumber { get; set; }

        public void Talk()
        {
            this.Address = "Gulshan";
        }

        private void Bath()
        {
        }
    }

    #region protected
    class Yaris2010
    {
        string price { get; set; }
        protected string engine { get; set; }
        protected string dashboard { get; set; }

        public string tyres { get; set; }
        public string headLightBulbs { get; set; }
    }

    class Yaris2017 : Yaris2010
    {
        public string color { get; set; }

        public void Braking()
        {
            this.engine = "1SZFE14";
            Console.WriteLine("Stop the car via ABS Brakes.");
        }
    }
    #endregion

    class EntryPoint
    {
        public static void Main()
        {
            Yaris2010 y = new Yaris2010();
            //y.engine = "1kr";// due to protected access modifier it cannot be accessed outside the its own class or its heirarchy.

            Yaris2017 y17 = new Yaris2017();

            DataAccessLayer DL = new DataAccessLayer();
            //DL.GetNameFromDbTable();//It cannot be accessed here bcz its inside the project.

            Console.ReadLine();
        }
    }
}