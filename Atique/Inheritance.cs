using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique
{
    class Inheritance
    {
        #region Single Level Inheritance
        class Human
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Nationality { get; set; }
            public string Language { get; set; }
            public string Legs { get; set; }
            public string Hands { get; set; }
            public string Brain { get; set; }

            public void Sleep() { }
            public void Walk() { }
            public void Talk() { }
            public void Eat() { }
            public void Run() { }
            public void Think() { }
        }

        class Teacher : Human
        {
            public string Subject { get; set; }
            public string Qualification { get; set; }

            public void Teach() { }
        }

        #endregion

        #region Multilevel Inheritance

        class MathsTeacher : Teacher
        {
            public void TeachingMaths()
            {
            }
        }

        class AlgebraTeacher : MathsTeacher
        {
            public void TeachingAlgebra()
            {
            }
        }
        #endregion

        #region Heirarchical Inheritance
        class Doctor : Human
        {
            public string Degree { get; set; }

            public void Treat() { }
        }

        class Surgeon : Doctor
        {
            public void Surgery() { }
        }

        class Physician : Doctor
        {
            public void PrescribeMedicine() { }
        }

        class NueroSurgeon : Surgeon
        {
            public void NeuroSurgery()
            {
            }
        }

        class OrthopediacSurgeon : Surgeon
        {
            public void OrthopediacSurgery()
            {
            }
        }

        class Gestroentrologist : Physician
        {
            public void PrescribeGestroMedicine()
            {
            }
        }

        class Dermatologist : Physician
        {
            public void PrescribeSkinMedicine()
            {
            }
        }
        #endregion

        #region Multiple Inheritance

        class Bed : WoodenFurniture //WodenFurniture show the case of Multipath Inheritance/Diamond Problem
        {
            public string Foam { get; set; }
            public string Size { get; set; }

            public void Sleep() { }
            public void Sit() { }
        }

        class Sofa : WoodenFurniture //WodenFurniture show the case of Multipath Inheritance/Diamond Problem
        {
            public string Foam { get; set; }
            public string Size { get; set; }
            public string Armrest { get; set; }

            public void Sit() { }
        }

        //Cannot be implimented
        //class SofaCumBed : Sofa, Bed
        //{
        //}
        #endregion

        #region Multipath Inheritance
        //Please see Multiple Inheritance section, it is implimented by inclusion of WoodenFurniture class
        class WoodenFurniture
        { }

        #endregion

        //Entry Point
        static void Main(string[] args)
        {
            Teacher t = new Teacher();//single level
            MathsTeacher mt = new MathsTeacher();//multi level
            AlgebraTeacher at = new AlgebraTeacher();

            Doctor d = new Doctor();
            Surgeon s = new Surgeon();
            NueroSurgeon n = new NueroSurgeon(); //Children of surgeon and sibling of orthopediac surgeon
            OrthopediacSurgeon o = new OrthopediacSurgeon();

            Physician p = new Physician();
            Gestroentrologist g = new Gestroentrologist();
            Dermatologist dm = new Dermatologist();
        }
    }
}