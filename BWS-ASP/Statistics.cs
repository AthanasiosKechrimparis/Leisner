using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace BWS_ASP
{
    [Serializable]
    public class Statistics
    {

        private Transaction trans;
        private SqlCommand cmd;

        [DataMember]
        public DateTime Starttime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        int ID{ get; set; }
        [DataMember]
        public Costumer User { get; set; }
        [DataMember]
        public List<Accident> ListOfAccident { get; set; }
        [DataMember]
        public List<Day> dayAccidents { get; set; }
        [DataMember]
        public List<Accident> tempList { get; set; }
       
        public Statistics()
        {
            //Transaction trans = new Transaction();
           // this.cmd = new SqlCommand();
        }


        public List<Accident> getFromDB(int id, DateTime startdate, DateTime enddate)
        {
            tempList = new List<Accident>();
            Starttime = startdate;
            EndTime = enddate;
            ID = id;
            //getFromDB();

            int compare = tempList[0].Amount;

            foreach (Accident I in tempList)
            {
                I.ST = (compare - I.Amount);
                if (I.ST < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }

            return tempList;
        }
        public void GraphStat(List<Day> Days)
        {
            List<DateTime> xDates = new List<DateTime>();
            List<int> ySizes = new List<int>();
            foreach (Day a in Days)
            {
                xDates.Add(a.Date);
                xDates.OrderByDescending(d => d.Date);
                ySizes.Add(a.Average);
            }
            
        }
        public List<Day> getAccidentDaysFromDB(DateTime selectStart, DateTime selectEnd, string DeviceID)
        {
            List<Day> dayAccidents = new List<Day>();

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("nrOfAccident", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@StartDate", selectStart));
                cmd.Parameters.Add(new SqlParameter("@EndDate", selectEnd));
                cmd.Parameters.Add(new SqlParameter("@UserID", DeviceID));

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    // Device D = new Device(int.Parse(rdr["DeviceNR"].ToString()), User);
                    Day A = new Day(DateTime.Parse((rdr["TimeOfAccident"]).ToString()), int.Parse(rdr["NrOfAccident"].ToString()));
                    dayAccidents.Add(A);

                }
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;
                // trans.getcon().Close();
            }
            //trans.Commit();
            trans.getcon().Close();
            return dayAccidents;
        }
        public List<Accident> getListByDateFromDB(DateTime Date, string DeviceID)
        {
            List<Accident> dayAccidents = new List<Accident>();

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("SELECT * FROM BedWA WHERE Date = @TimeOfAccident AND DeviceID = @UserID", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@TimeOfAccident", Date));
                
                cmd.Parameters.Add(new SqlParameter("@UserID", DeviceID));

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    // Device D = new Device(int.Parse(rdr["DeviceNR"].ToString()), User);
                    Accident acc = new Accident(DateTime.Parse((rdr["TimeOfAccident"]).ToString()), int.Parse((rdr["Amount"]).ToString()), int.Parse((rdr["Drinks"]).ToString()), DateTime.Parse((rdr["TimeSleep"]).ToString()), int.Parse((rdr["ToiletVisit"]).ToString()));
                    dayAccidents.Add(acc);

                }
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;
                // trans.getcon().Close();
            }
            //trans.Commit();
            trans.getcon().Close();
            return dayAccidents;
        }
    }
}