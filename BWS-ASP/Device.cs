using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Serialization;

namespace BWS_ASP
{
    [Serializable]
    public class Device
    {
        //private Transaction trans;
        //private SqlCommand cmd;

        [DataMember]
        public int DeviceNumber { get; set; }
        [DataMember]
        public Costumer Owner { get; set; }

        //constructor #1
        public Device(int deviceNumber, Costumer owner)
        {
            this.DeviceNumber = deviceNumber;
            this.Owner = owner;
        }
        public Device(int deviceNumber)
        {
            this.DeviceNumber = deviceNumber;          
        }

        public void RegisterAccident( int amount, DateTime time, int Drinks, DateTime TimeSleep, DateTime TimeToilet, int ToiletVisit )
        {
            Transaction trans;
            SqlCommand cmd;            

             trans = new Transaction();
             
             trans.BegindTransactions();
             int i = 101;
            try
            {
                cmd = new SqlCommand("RegisterBWAcc", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Amount", amount));
                cmd.Parameters.Add(new SqlParameter("@TimeOfAccident", time));
                cmd.Parameters.Add(new SqlParameter("@DeviceID", DeviceNumber));
                cmd.Parameters.Add(new SqlParameter("@Drinks", Drinks));
                cmd.Parameters.Add(new SqlParameter("@TimeSleep", TimeSleep));
                cmd.Parameters.Add(new SqlParameter("@TimeToilet", TimeToilet));
                cmd.Parameters.Add(new SqlParameter("@Toilet", ToiletVisit));
                //cmd.Parameters.Add(new SqlParameter("@Version", (Version + 1)));

                i = cmd.ExecuteNonQuery();
                trans.Commit();

            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }
            //trans.Commit();

        }

    }
}