using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment;

namespace Atique.DLLReference
{
    class Website
    {
        public static void Main()
        {
            double amount = 500;
            string ccNo = "4111111111111112";

            PaymentProcess.Charge(ccNo, amount);

            Console.ReadLine();
        }
    }
}
