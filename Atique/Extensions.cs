using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Atique.Extensions
{
    class EntryPoint
    {
        //The key usage of extensions when you cant change the class and add methods to it.
        public static void Main()
        {
            try
            {
                //Double Extension Methods calling
                double d = 43533123.67423423;

                Console.WriteLine(d.GetWithoutDecimalPlaces());
                Console.WriteLine(d.ToCurrencyFormat());

                //String Extension Method calling

                string str = "4324324";
                if (str.IsNumber())
                    Console.WriteLine($"{str} is number");
                else
                    Console.WriteLine($"{str} is not a number");

                string name = "Ateeque";
                if (name.IsEmpty())
                    Console.WriteLine("Empty");
                else
                    Console.WriteLine("Not Empty");

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetMessageAndStacktrace());
            }

            Console.ReadLine();
        }
    }
}
