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

        List<Day> dayAccidents = new List<Day>();

        List<Accident> tempList = new List<Accident>();
        public Statistics()
        {
            //Transaction trans = new Transaction();
           // this.cmd = new SqlCommand();
        }


        public List<Day> GetStatisticsFromDB(int id, DateTime startdate, DateTime enddate)
        {
            Starttime = startdate;
            EndTime = enddate;
            ID = id;
            getFromDB();

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

        public List<Day> getAccidentDaysFromDB(DateTime selectStart, DateTime selectEnd, int DeviceID)
        {
            

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
                    Day A = new Accident(int.Parse(rdr["AccidentID"].ToString()), int.Parse(rdr["Amount"].ToString()),  DateTime.Parse(rdr["TimeOfAccident"].ToString()), new Device(int.Parse(rdr["DeviceID"].ToString()), User));
                    tempList.Add(A);
                    return dayAccidents;
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
        }
    }
}