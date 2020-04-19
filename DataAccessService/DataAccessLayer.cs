using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessService
{
    public class DataAccessLayer
    {
        //protected outside the dll and internal inside the dll
        protected internal string connectionString { get; set; }

        internal void GetNameFromDbTable()
        {
            connectionString = "connection string";
            //Lets assume the name is coming from DB
            Console.WriteLine("M Ateeque Azam");
        }
    }

    public class GeneralLedger
    {
        public void RecordDebitEntry()
        {
            DataAccessLayer dl = new DataAccessLayer();
            dl.GetNameFromDbTable(); //It can be accessed here bcz its inside the project.
            dl.connectionString = "connection string of db";
        }
    }
}
