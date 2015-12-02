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
        public List<Day> getAccidentDaysFromDB(DateTime selectStart, DateTime selectEnd, int DeviceNr)
        {
            List<Day> dayAccidents = new List<Day>();

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("nrOfAccident", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DeviceID", DeviceNr));
                cmd.Parameters.Add(new SqlParameter("@StartDate", selectStart));
                cmd.Parameters.Add(new SqlParameter("@EndDate", selectEnd));
                

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Device D = new Device(int.Parse(rdr["DeviceNR"].ToString()), User);
                    Day A = new Day(DateTime.Parse((rdr["TimeOfAccident"]).ToString()), int.Parse(rdr["NrOfAccident"].ToString()),int.Parse(rdr["Average"].ToString()));
                    dayAccidents.Add(A);

                }
                rdr.Close();
            }
            catch (Exception e)
            {
                
                //trans.RollBack();
                throw e;
                //trans.getcon().Close();
            }
            //trans.Commit();
            
            trans.getcon().Close();
            return dayAccidents;
        }
        public List<Accident> getAverageFromDB(DateTime selectStart, DateTime selectEnd, int DeviceNr)
        {
            List<Accident> averageAccidents = new List<Accident>();

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("getAverage", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DeviceID", DeviceNr));
                cmd.Parameters.Add(new SqlParameter("@StartDate", selectStart));
                cmd.Parameters.Add(new SqlParameter("@EndDate", selectEnd));


                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Device D = new Device(int.Parse(rdr["DeviceNR"].ToString()), User);
                    Accident A = new Accident(int.Parse((rdr["Amount"]).ToString()));
                    averageAccidents.Add(A);

                }
                rdr.Close();
            }
            catch (Exception e)
            {

                //trans.RollBack();
                throw e;
                //trans.getcon().Close();
            }
            //trans.Commit();

            trans.getcon().Close();
            return averageAccidents;
        }
        public List<Accident> getListByDateFromDB(DateTime Date, int DeviceNr)
        {
            List<Accident> dayAccidents = new List<Accident>();
            DateTime newDate = DateTime.Parse(Date.ToShortDateString());
            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("getInfoFromDate" , trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Date", newDate));
                
                cmd.Parameters.Add(new SqlParameter("@DeviceNr", DeviceNr));

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    // Device D = new Device(int.Parse(rdr["DeviceNR"].ToString()), User);
                    Accident acc = new Accident(int.Parse((rdr["AccidentID"]).ToString()), int.Parse((rdr["Amount"]).ToString()), DateTime.Parse((rdr["TimeOfAccident"]).ToString()),int.Parse((rdr["DeviceID"]).ToString()), int.Parse((rdr["Drinks"]).ToString()), DateTime.Parse((rdr["TimeSleep"]).ToString()), DateTime.Parse((rdr["TimeToilet"]).ToString()), int.Parse((rdr["Toilet"]).ToString()), int.Parse((rdr["Version"]).ToString()));
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