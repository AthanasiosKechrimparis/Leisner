using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace LeisnerWebApplication
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

        public List<DateTime> dateGraphStat2(List<Day> Days)
        {
            List<DateTime> xDates = new List<DateTime>();
            List<int> ySizes = new List<int>();
            foreach (Day a in Days)
            {
                xDates.Add(a.Date);
                xDates = xDates.OrderByDescending(d => d.Date).ToList();
                ySizes.Add(a.Average);

                
            }
            return xDates;
        }
        //TEST
        public Day(DateTime Date, int AccidentsNumber)
        {
            this.Date = Date;
            this.AccidentsNumber = AccidentsNumber;
            //this.Average = Average;
        }

        public Day(DateTime Date, int AccidentsNumber, int Average)
        {
            this.Date = Date;
            this.AccidentsNumber = AccidentsNumber;
            this.Average = Average;
        }
        public Day()
        {

        }
        
        public List<int> avgGraphStat2(List<Day> Days)
        {
            List<DateTime> xDates = new List<DateTime>();
            List<int> ySizes = new List<int>();
            foreach (Day a in Days)
            {
                xDates.Add(a.Date);
                xDates = xDates.OrderByDescending(d => d.Date).ToList();
                ySizes.Add(a.Average);

                

            }
            return ySizes;
        }
    }
}