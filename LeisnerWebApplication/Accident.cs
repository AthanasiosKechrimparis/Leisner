using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApplication
{
    public class Accident
    {
        public int deviceID { get; set; }
        public DateTime timeofAccident { get; set; }
        public int  amount { get; set; }

        public Accident (int d, DateTime t, int a)
        {
            deviceID = d;
            timeofAccident = t;
            amount = a;
        }
    }
}