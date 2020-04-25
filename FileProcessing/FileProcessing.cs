using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace File.Processing
{
    //It resides in different DLL named FileProcessing
    public class FileProcessing
    {
        public delegate void SendNotification();//Delegate declaration

        public SendNotification notification; //Delegate variable

        public event SendNotification notificationEvent; //Event Variable
        //Event always be of some delegate type

        public void Process()
        {
            Console.WriteLine("File Processing Starts.");
            Thread.Sleep(3000);//Assuming its file processing functionality which takes 3 seconds
            Console.WriteLine("File Processing Ends.");

            if (notification != null)
                notification();

            if (notificationEvent != null)
                notificationEvent();
        }
    }
}
