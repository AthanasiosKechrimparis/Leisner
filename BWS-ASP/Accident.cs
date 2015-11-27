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
         public DateTime StartDate
         {
             get;
             set;
         }
    

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
         public int Version { get; set; }
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
        public Accident(DateTime TimeOfAccident, int Amount, int Drinks, DateTime TimeSleep, DateTime TimeToilet, int ToiletVisit, int Version)
        {
            this.TimeOfAccident = TimeOfAccident;
            this.Amount = Amount;
            this.Drinks = Drinks;
            this.TimeSleep = TimeSleep;
            this.TimeToilet = TimeToilet;
            this.ToiletVisit = ToiletVisit;
            this.Version = Version;
        }
         public Accident(DateTime StartDate, DateTime TimeOfAccident, DateTime TimeSleep, int sizeOfAccident, int ToiletVisit, int Drinks, int AccidentID)
        {
            this.StartDate = StartDate;
            this.TimeOfAccident = TimeOfAccident;
            this.TimeSleep = TimeSleep;
            this.Amount = Amount;
            this.ToiletVisit = ToiletVisit;
            this.Drinks = Drinks;
            this.AccidentID = AccidentID;
        }
         public Accident(DateTime TimeOfAccident, int Amount, int Drinks, DateTime TimeSleep, int ToiletVisit)
         {
             this.TimeOfAccident = TimeOfAccident;
             this.Amount = Amount;
             this.Drinks = Drinks;
             this.TimeSleep = TimeSleep;
             
             this.ToiletVisit = ToiletVisit;
             
         }
         public int GetAverage(List<Accident> accidentlist)
         {
             
             int i = 0;
             foreach (Accident a in accidentlist)
             {
                 i = i + a.Amount;
             }
             i = i / accidentlist.Count();
             return i;
         }
    }
}