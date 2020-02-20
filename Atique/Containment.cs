using Atique.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Containment
{
    class Containment
    {
        #region Composition/Aggregation

        class House
        {
            public Washroom wRoom { get; set; } // Composition
            public DrawingRoom dRoom { get; set; } // Composition
            public LivingRoom lRoom { get; set; } // Composition

            public WallClock clock { get; set; } //Aggregation
            public Sofa sofa { get; set; } //Aggregation
        }

        class Washroom
        {
            public string comode { get; set; }
            public string basin { get; set; }
            public string shower { get; set; }
        }

        class DrawingRoom
        {
        }

        class LivingRoom
        {
        }

        class WallClock
        {
        }

        class Flat : House
        {

        }

        //class ToyotaHatchback
        //{
        //    public Steering steering {get;set;}
        //    public Engine engine { get; set; }
        //    public Tyre tyre { get; set; }
        //    public Gear gear { get; set; }
        //}

        //class Vitz : ToyotaHatchback
        //{

        //}

        #endregion

        #region Multiple Inheritance Solution
        /// <summary>
        /// So we implimented multiple inheritance through containment
        /// </summary>
        
        class SofaCumBed
        {
            public Sofa sofa { get; set; }
            public Bed bed { get; set; }
        }

        #endregion

        //Entry Point
        static void Main(string[] args)
        {
            House h = new House();
            h.wRoom.basin = "Porta Basin"; //Value Setting
            h.wRoom.shower = "Grohay Shower"; //Value Setting
            h.wRoom.comode = "Porta Shower"; //Value Setting

            Console.WriteLine(h.wRoom.basin); //Value Getting

            Flat f = new Flat();

            SofaCumBed sofaCumBed = new SofaCumBed();
            sofaCumBed.sofa.Sit();
            sofaCumBed.bed.Sit();
        }
    }
}