using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Software_New
{
    class class_Timer
    {

       public static Stopwatch stp = new Stopwatch();



        public void start_Timer()
        {
            stp.Start();
        }

        public static string get_Time()
        {
            stp.Stop();
            var seconds = stp.Elapsed.Seconds;
            var hours = stp.Elapsed.Hours;
            var minutes = stp.Elapsed.Minutes;

            //if(hours >1)
            //{
            //    string abc = hours + "hour and " + minutes + " minutes";
            //    return abc;
            //}
            //else
            //{

           if(seconds == 1)
            {
                return seconds + " second";
            }
           
            if(minutes == 0)
            {
                return seconds + " seconds";
            }

            else if(minutes == 1)
            {
                return minutes + " minute and " + seconds + " seconds";
            }
            else
            {
                return  minutes + " minutes and " + seconds + " seconds";
            }


           
        //}
        }
    }
}
