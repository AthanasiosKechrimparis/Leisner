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
        private Transaction trans;
        private SqlCommand cmd;

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

        public void RegisterAccident(int amount, DateTime time)
        {
            Transaction trans;
            SqlCommand cmd;

             trans = new Transaction();
             
             trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("RegisterBWAcc", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Amount", amount));
                cmd.Parameters.Add(new SqlParameter("@TimeOfAccident", time));
                cmd.Parameters.Add(new SqlParameter("@DeviceID", DeviceNumber));


                

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }
            trans.Commit();

        }

    }
}