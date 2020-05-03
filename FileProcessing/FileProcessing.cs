using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace File.Processing
{
    //It resides in different DLL named FileProcessing
    public class FileProcessing
    {
        public delegate void SendNotification();//Delegate declaration

        public SendNotification notification; //Delegate variable

        public event SendNotification notificationEvent; //Event Variable

        public event EventHandler<FileEventArgs> onNotificationSent;

        //Event always be of some delegate type

        public void Process(string file)
        {
            Console.WriteLine("File: {0} Processing Starts.", file);
            Thread.Sleep(3000);//Assuming its file processing functionality which takes 3 seconds
            Console.WriteLine("File: {0} Processing Ends.", file);

            if (notification != null)
                notification();

            if (notificationEvent != null)
                notificationEvent();

            onNotificationSent?.Invoke(this, new FileEventArgs() { file_name = file });
        }
    }

    public class FileEventArgs: EventArgs
    {
        public string file_name { get; set; }
    }
}