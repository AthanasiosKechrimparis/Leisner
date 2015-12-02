using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApplication
{
    [Serializable]
    public class Accident
    {
       
        public DateTime StartDate { get; set; }

        
        
        
        public DateTime TimeOfAccident { get; set; }
      
        
        
        public int Drinks { get; set; }
       
        public DateTime TimeSleep { get; set; }
       
        public DateTime TimeToilet { get; set; }
       
        public int ToiletVisit { get; set; }
       
        public int Version { get; set; }
        
        
        
        public int ST { get; set; }
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

        public Accident(DateTime TimeOfAccident, int Amount, int Drinks, DateTime TimeSleep, int ToiletVisit)
        {
            this.TimeOfAccident = TimeOfAccident;
            this.Amount = Amount;
            this.Drinks = Drinks;
            this.TimeSleep = TimeSleep;

            this.ToiletVisit = ToiletVisit;

        }

        public Accident(int AccidentID, int Amount, DateTime TimeOfAccident, int Device, int Drinks, DateTime TimeSleep, DateTime TimeToilet, int ToiletVisit, int Version)
        {
            this.AccidentID = AccidentID;
            this.TimeOfAccident = TimeOfAccident;
            this.Amount = Amount;
            this.Drinks = Drinks;
            this.TimeSleep = TimeSleep;
            this.TimeToilet = TimeToilet;
            this.ToiletVisit = ToiletVisit;
            this.Version = Version;
        }

        public Accident(int Amount)
        {
            this.Amount = Amount;
        }
    }
}