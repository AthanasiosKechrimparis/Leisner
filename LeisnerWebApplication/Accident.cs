using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApplication
{
    public class Accident
    {
        public int DeviceID { get; set; }
        public DateTime Date { get; set; }
        public int  Amount { get; set; }

        public int AccidentID { get; set; }

        public Accident (int acc, int d, DateTime t, int a)
        {
            DeviceID = d;
            Date = t;
            Amount = a;
            AccidentID = acc;
        }
    }
}