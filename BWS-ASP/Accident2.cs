using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWS_ASP
{
    public class Accident2
    {
        public DateTime startDate
        {
            get;
            set;
        }
        public DateTime endDate
        {
            get;
            set;
        }
        public DateTime timeOfAccident
        {
            get;
            set;
        }
        public DateTime bedTime
        {
            get;
            set;
        }
        public int sizeOfAccident
        {
            get;
            set;
        }
        public bool toiletVisit
        {
            get;
            set;
        }
        public int drinksBeforeBed
        {
            get;
            set;
        }

        public int AccidentID
        {
            get;
            set;
        }

        public Accident2(DateTime startDate,DateTime timeOfAccident, DateTime bedTime, int sizeOfAccident, bool toiletVisit, int drinksBeforeBed)
        {
            this.startDate = startDate;
            this.timeOfAccident = timeOfAccident;
            this.bedTime = bedTime;
            this.sizeOfAccident = sizeOfAccident;
            this.toiletVisit = toiletVisit;
            this.drinksBeforeBed = drinksBeforeBed;
        }

        public Accident2(DateTime startDate, DateTime timeOfAccident, DateTime bedTime, int sizeOfAccident, bool toiletVisit, int drinksBeforeBed, int AccidentID)
        {
            this.startDate = startDate;
            this.timeOfAccident = timeOfAccident;
            this.bedTime = bedTime;
            this.sizeOfAccident = sizeOfAccident;
            this.toiletVisit = toiletVisit;
            this.drinksBeforeBed = drinksBeforeBed;
            this.AccidentID = AccidentID;
        }
    }

    
}