using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class PaymentProcess
    {
        public static void Charge(string ccNo, double amount)
        {
            double transFee = 5;
            //Assume merchant is charging payment from the given credit card
            Console.WriteLine("Amount:{0} is payed from Credit Card:{1}", amount - transFee, ccNo);
        }
    }
}
