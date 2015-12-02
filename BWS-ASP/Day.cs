using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BWS_ASP
{
    [Serializable]
    public class Day
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int AccidentsNumber { get; set; }
        [DataMember]

        public int Average { get; set; }
        //TEST
        public Day(DateTime Date, int AccidentsNumber, int Average)
        {
            this.Date = Date;
            this.AccidentsNumber = AccidentsNumber;
            this.Average = Average;
        }
    }
}