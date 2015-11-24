using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Statistics
{
    public class Day
    {
        public DateTime Date { get; set; }
        public int AccidentsNumber { get; set; }

        public int Average { get; set; }

        public Day(DateTime Date, int AccidentsNumber, int Average)
        {
            this.Date = Date;
            this.AccidentsNumber = AccidentsNumber;
            this.Average = Average;
        }
    }
}