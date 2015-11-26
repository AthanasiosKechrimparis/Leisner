using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWS_ASP
{
    [Serializable]
    public class Day
    {
        public DateTime Date { get; set; }
        public int AccidentsNumber { get; set; }

        public int Average { get; set; }
        //TEST
        public Day(DateTime Date, int AccidentsNumber)
        {
            this.Date = Date;
            this.AccidentsNumber = AccidentsNumber;
            //this.Average = Average;
        }
    }
}