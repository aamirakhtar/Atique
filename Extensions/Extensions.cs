using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static string GetMessageAndStacktrace(this Exception ex)
        {
            return ex.Message + " " + ex.StackTrace;
        }

        public static int GetWithoutDecimalPlaces(this double d)
        {
            return Convert.ToInt32(d);
        }

        public static string ToCurrencyFormat(this double amount)
        {
            return string.Format("{0:C}", amount);
        }

        public static bool IsNumber(this string str)
        {
            double isNumber = 0;
            return double.TryParse(str, out isNumber);
        }

        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
