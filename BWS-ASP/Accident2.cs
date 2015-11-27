using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BWS_ASP
{
    [Serializable]
    public class Accident2
    {
        [DataMember]
        public DateTime startDate
        {
            get;
            set;
        }
        [DataMember]
        public DateTime endDate
        {
            get;
            set;
        }
        [DataMember]
        public DateTime timeOfAccident
        {
            get;
            set;
        }
        [DataMember]
        public DateTime bedTime
        {
            get;
            set;
        }
        [DataMember]
        public int sizeOfAccident
        {
            get;
            set;
        }
        [DataMember]
        public bool toiletVisit
        {
            get;
            set;
        }
        [DataMember]
        public int drinksBeforeBed
        {
            get;
            set;
        }
        [DataMember]
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