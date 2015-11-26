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
    public class Admin : IUser
    {
        private Transaction trans;
        private SqlCommand cmd;
        [DataMember]
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [DataMember]
        public string Type
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        [DataMember]
        public DateTime Birthday
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        [DataMember]
        public Costumer User { get; set; }

        List<Accident> tempList = new List<Accident>();

        public string Statistic(int ID, DateTime startTime, DateTime EndTime)
        {
            throw new NotImplementedException();
        }

        public Accident ViewAccident(Costumer costumer, DateTime theDate)
        {
            throw new NotImplementedException();
        }

        public void RegisterDevice(Costumer cos)
        {

          
        }
        public void RegisterDevice(int userID)
        {

            Transaction trans = new Transaction();
            SqlCommand cmd;

            trans = new Transaction();
            trans.BegindTransactions();

            try
            {
                cmd = new SqlCommand("RegisterDevice", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@UserID", userID));


                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }

            trans.Commit();
        }

        public void UpdateAccident(int accID, DateTime time, int amount, int DeviceID)
        {
            Transaction trans;
            SqlCommand cmd;

            int versionCheck = getVersion(accID);

            trans = new Transaction();
            
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("UpdateAccident", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@AccidentID", accID));
                cmd.Parameters.Add(new SqlParameter("@Amount", amount));
                cmd.Parameters.Add(new SqlParameter("@TimeOfAccident", time));
                cmd.Parameters.Add(new SqlParameter("@DeviceID", DeviceID));
                cmd.Parameters.Add(new SqlParameter("@versionCheck", versionCheck));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }
            trans.Commit();

        }

        public void DeleteAccidents(int AccidentID)
        {
            Transaction trans;
            SqlCommand cmd;

            trans = new Transaction();
            
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("DeleteAccident", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@AccidentID", AccidentID));


                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }
            trans.Commit();
        }

        public List<Accident> GetStatisticsFromDB(int UserID)
        {
            ReadAccidents(UserID);

            return tempList;
        }

        public List<Accident> ReadAccidents(int UserID)
        {

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("ReadAccidents", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

           
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                   
                    Accident A = new Accident(int.Parse(rdr["AccidentID"].ToString()), int.Parse(rdr["Amount"].ToString()), DateTime.Parse(rdr["TimeOfAccident"].ToString()), new Device(int.Parse(rdr["DeviceID"].ToString()), User));
                    tempList.Add(A);
                }
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;
                
            }
            
            
            trans.getcon().Close();
            return tempList;

        }

        public int getVersion(int accID)
        {
            trans = new Transaction();
            trans.BegindTransactions();
            SqlDataReader dbr;
            int version = 0;
            try
            {
                cmd = new SqlCommand("getVersion", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@AccidentID", accID));

                cmd.ExecuteNonQuery();

                dbr = cmd.ExecuteReader();
                while (dbr.Read() == true)
                {
                    if (dbr.HasRows)
                    {
                        version = (int)dbr["Version"];

                    }

                }
                dbr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            trans.getcon().Close();
            return version;

        }
    }
}