using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.CSharp.Basics
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*
             * A-Coding conventions:-
             * 1-Camel casing: first letter is small and rest start from capital letters, its used for variable names, function parameters
             *      eg: journalPayment
             *      
             *2-Pascal Casing:- is title case. its used form method names, property names, class names, structures, interfaces etc.
             *      eg: Main(), Engine {get;set;}, class SmartPhone, struct Student, interface ICar
             *      
             *Arithmatic Operators:-
             * +,-,*,/,%--remainder op
             * postfix op: i++; i--; i = i + 1
             * prefix op: ++i; --1; i = i + 1
             * increment operators: i+=1 => i = i + 1
             * i-=1, i = i - 1
             */

            //B-Prefix and postfix
            /*
            Console.WriteLine("aamir" + "akhtar");

            int a = 5;
            Console.WriteLine(a++);

            Console.WriteLine(a);

            int x = ++a + 5;

            Console.WriteLine("Please enter any number to find out even or odd: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            */

            //Console.WriteLine();

            //C-Primitive Type Casting
            /*
            int i = Convert.ToInt32(1 + 3.4); //explicit type conversion
            int a1 = 1 + (int)3.4; //explicit type conversion

            float n = (float)5.4 + 6;

            double d = 1 + 7; //it will without error bcz it will take both values with and without points

            string s = "1.345";
            float ds = float.Parse(s);

            //When we suppose to convert string into some primitive type then we ue like type.Parse()
            //WHen we suppose to convert any type into another type then we use bracket notation () or can use Convert class
            */

            //D-User Defined Type Casting
            /*
            //You can only convert child objects into parent objects, and type conversion for user defined types can only be possible withing the heirarchy.

            Car car = new Car();

            Vitz vitz = new Vitz();
            
            Car car1 = (Car)vitz; //Child converts into parent

            Vitz vitz1 = (Vitz)car; //This will not work, because parent cannot be converted into child, but vice versa is true.

            //Object is parent type of all types in c#
            object obj = new Calculator();
            Calculator calc = (Calculator)obj;
            */

            //E-String formatting
            /*
            Console.Write("Enter Subject Name: ");
            string subject = Console.ReadLine();

            Console.Write("Enter your examination score: "); //WriteLine--> write on the screen and change the line
            int number = int.Parse(Console.ReadLine());

            //Curly Bracket with position notation for string formatting
            //Console.WriteLine(@"You got ""{0}"" numbers in the subject ""{1}"".", number, subject); //for double qotes to display we need to give double qoutes 2 times
            Console.WriteLine("You got '{1}' numbers in the subject '{0}'.", subject, number);// here {0} and {1} means positions of the variables to display

            //Curly Bracket with variable name notation.
            Console.WriteLine($"You got '{number}' numbers in the subject '{subject}'");//when you dont suppose to re-use the format then this notation is very useful.

            //When you have to save the format to re-use in other functionalities, then this notation is useful.
            string format = "You got '{1}' numbers in the subject '{0}'.";
            Console.WriteLine(format, subject, number);// here {0} and {1} means positions of the variables to display
            */

            //F-Control Structures
            /*
            Console.Write("Please Enter week day number: ");

            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.WriteLine("Sunday");
            else if (n == 2)
                Console.WriteLine("Monday");
            else if (n == 3)
                Console.WriteLine("Tuesday");
            else if (n == 4)
                Console.WriteLine("Wednesday");
            else if (n == 5)
                Console.WriteLine("Thursday");
            else if (n == 6)
                Console.WriteLine("Friday");
            else if (n == 7)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Wrong week number");

            //You can alternatively use switch instead of "if else else if" provided the variable is only one.
            switch(n)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Wrong week number");
                    break;
            }
            */

            //G-Turnary operator
            /*
            Console.Write("Please enter number to find even or odd: ");
            int n = int.Parse(Console.ReadLine());

            string msg = (n % 2 == 0 ? "even" : "odd"); // if ? then : else

            //Above trunary operator is equivalent to the following code

            //if (n % 2 == 0)
            //    msg = "even";
            //else
            //    msg = "odd";

            Console.WriteLine(msg);
            */

            //H-Iterative Structures:- To do one task repetetively.
            //1-for
            //2-while
            //3-do while
            //4-foreach
            /*
            string key = "";
            do
            {
                Console.Write("Please Enter any number to print table: ");
                int number = int.Parse(Console.ReadLine());

                //1-For Loop:-
                //1-Counter initialization; 2-condition ; 4-increment/decrement
                //{
                //    3-body
                //}
                //Throughout the loop initilization executes only once.
                //Foor Loop is best designed for Arrays.
                for (int i = 1; i <= 10; i++)
                {
                    int value = number * i;
                    Console.WriteLine($"{number} x {i} = {value}");
                    //Console.WriteLine("{0} x {1} = {2}", number, i, value);
                }
                
                //int i = 1;
                //while (i <= 10)
                //{
                //    int value = number * i;
                //    Console.WriteLine($"{number} x {i} = {value}");
                //    i++;
                //}

                Console.Write("If you want to try another number, please press enter: ");
                key = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine();
            }
            while (key == "y");
            */
        }

        public class Car
        {
            public string Engine { get; set; }
        }

        public class Vitz : Car
        {

        }

        public class Vitz2005 : Vitz
        {

        }

        public class Calculator
        {

        }
    }
}