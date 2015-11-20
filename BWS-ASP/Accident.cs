using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BWS_ASP
{
     [Serializable]
    public class Accident
    {
         [DataMember]
        public int AccidentID { get; set; }
        [DataMember]
        public DateTime TimeOfAccident { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int Drinks { get; set; }
         [DataMember]
        public DateTime TimeSleep { get; set; }
         [DataMember]
         public DateTime TimeToilet { get; set; }
         [DataMember]
         public int ToiletVisit { get; set; }
        [DataMember]
        public Device dev { get; set; }
        [DataMember]
        public int ST { get; set; }

        public Accident(int AccID, int amount, DateTime timeof, Device device)
        {
            this.AccidentID = AccID;
            this.TimeOfAccident = timeof;
            this.Amount = amount;
            this.dev = device;
        }

        public Accident(int AccID, int amount, DateTime timeof)
        {
            this.AccidentID = AccID;
            this.TimeOfAccident = timeof;
            this.Amount = amount;
            
        }


        public Accident(DateTime timeof, int amount, Device device)
        {           
            this.TimeOfAccident = timeof;
            this.Amount = amount;
            this.dev = device;
        }

    }
}