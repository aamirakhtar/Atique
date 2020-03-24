using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.CSharp.Basics
{
    public class EntryPoint
    {
        public static void Main()
        {
            #region A-Coding conventions
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
            #endregion

            #region B-Prefix and postfix
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
            #endregion

            #region C-Primitive Type Casting
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
            #endregion

            #region D-User Defined Type Casting
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
            #endregion

            #region E-String formatting
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
            #endregion

            #region F-Control Structures
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
            #endregion

            #region G-Turnary operator
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
            #endregion

            #region H-Iterative Structures
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
            #endregion

            #region I-Unconditional Structures
            //i-Unconditional Structures:-
            //1-break:
            //its used in switch and loops, it breaks the further execution of switch or loop
            //2-continue
            //it continues the execution of loop skipping particular iteration
            //its used in loops
            //3-goto
            //4-return

            //1-break
            /*int counter = 0;
            while(true)
            {
                if (counter == 10)
                    break;

                Console.WriteLine("{0}-Ateeque", counter);
                counter++;
            }*/

            //2-continue
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;

                Console.WriteLine("Email send to user id: {0}", i);
            }*/

            //3-goto:
            //its goto label statement, it will transfer control to particular label of the program
            /*ConsoleKey key;
            print_table_again:

            Console.Write("Please Enter any number to print table: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int value = number * i;
                Console.WriteLine($"{number} x {i} = {value}");
            }

            Console.Write("If you want to try another number, please press ENTER: ");
            key = Console.ReadKey().Key;
            Console.WriteLine();

            if (key == ConsoleKey.Enter)
                goto print_table_again;

            print_name:
            Console.WriteLine("Ateeque");

            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
                goto print_name;
                */
            //4-return:
            //Its used in functions/properties to return particular value;
            //It only only returns single object/value

            //Calculator cal = new Calculator();

            //int sum = cal.Add(4, 2, 3);//Function calling, function execution

            //Console.WriteLine(sum);

            #endregion

            #region J-Getter Setter

            //Ateeque a = new Ateeque();
            //Console.WriteLine(a.Name);//read only property means it only has getter
            //a.JobDescription = "IT Manager";//it calls a setter
            //Console.WriteLine(a.JobDescription);//it calls a getter
            #endregion

            #region K-Functions

            //Circle c = new Circle();

            ////function calling, function call, function invokation
            //double area = c.Area(2); // A function which returns some value, should be saved in some variable for further usage
            //Console.WriteLine(area);

            #endregion

            #region L-Exception Handeling
            //Exception (Crash situation)

            /*Keywords:-
             * try
             * catch
             * throw
             * finally 
             */

            //DBAccess dbAccess = new DBAccess();

            //try
            //{
            //    string userName = dbAccess.GetUserName(1);

            //    string userNameLower = userName.ToLower();

            //    Console.WriteLine(userNameLower);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            ShoppingCart cart = new ShoppingCart();
            try
            {
                cart.Authenticate("aamir", "12345678");
                cart.Checkout(1004);
                cart.AcceptPaymentViaPayPal("41111111111111113");
            }
            catch(Exception ex) //It will run in case of failure only
            {
                Console.WriteLine(ex.Message);
            }
            finally//it will run in all cases (failuer or not)
            {
                cart.RemoveProductFromCart(1004);
            }

            ShoppingCart cart1 = new ShoppingCart();

            cart1.Authenticate("aamir", "12345678");//Here we are handeling the exception inside Authenticate function, so when the authentication failed
            // the exception is handelled inside the function so the remaining ones will be invoked. Which should not be the case.

            try
            {
                cart1.Checkout(1004);
                cart1.AcceptPaymentViaPayPal("41111111111111113");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            #endregion
        }

        public class ShoppingCart
        {
            public void Authenticate(string userId, string password)
            {
                try
                {
                    throw new Exception("Authentication failed.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public void Checkout(int productId)
            {
                //throw new Exception("Product not available.");
            }

            public void AcceptPaymentViaPayPal(string ccNo)
            {
                //throw new Exception("Credit Card number not valid.");
            }

            public void RemoveProductFromCart(int productId)
            {

            }
        }

        public class DBAccess
        {
            public string GetUserName(int id)
            {
                string userName = "aamir";//lets assume its coming from db

                //lets assume db connection is crashed, and assume we cant get user Name value and defualt null is assigned
                userName = null;
                return userName;
            }
        }

        public class Circle
        {
            //function definition, callee
            public double Area(double radius)// A function having return type, must have return statement
            {
                return 2 * 3.214 * radius;
            }
        }

        public class Calculator
        {
            //signature of the function
            //access_modifier return_type name_of_the_function(type_of_parameter1 parameter1, type_of_parameter2 parameter2,....)
            //Function Definition
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public float Add(float a, float b) //a and b are the parameters of the function
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Sub(double a, double b)
            {
                return a - b;
            }

            public void print_ans(double ans)
            {
                Console.WriteLine(ans);
            }
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

        /// <summary>
        /// Getter Setter
        /// </summary>
        public class Ateeque
        {
            //public string Name { get; set; }

            //Read only property
            public string Name
            {
                //Getter
                get
                {
                    return "Ateeque";
                }
            }

            public string JobDescription
            {
                //Getter
                get
                {
                    return JobDescription;
                }
                //Setter
                set
                {
                    JobDescription = value;
                }
            }
        }
    }
}