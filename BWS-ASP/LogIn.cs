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
    public class LogIn
    {
        private Transaction trans;
        private SqlCommand cmd;

        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string PassWord { get; set; }
        [DataMember]
        public int Permision { get; set; }
        [DataMember]
        public int userID { get; set; }

        public LogIn()
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permision = Permision;
        }


        public int login(string Username, string Password)
        {
            int Perm = 3;
            Transaction trans;
            SqlCommand cmd;

            trans = new Transaction();
            trans.BegindTransactions();
            String query = "Select UserName ,PassWord ,TypeOfUser from LogIn1 where UserName = '" + Username + "'and PassWord = '" + Password + "'";
            cmd = new SqlCommand(query, trans.getcon(), trans.GetTransaction());
            SqlDataReader dbr;

            dbr = cmd.ExecuteReader();
            while (dbr.Read() == true) 
            {
                if (dbr.HasRows)
                {
                    Perm = (int)dbr["TypeOfUser"];
                }
            }
            trans.GetConnection().Close();
            return Perm;
        }


        public void SignUp(string type, string birthday, string UserName, string PassWord, string Name, int deviceID)
        {
            Transaction trans;
            SqlCommand cmd;

            

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("NewSignUp", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@type", type));
                cmd.Parameters.Add(new SqlParameter("@birthday", birthday));
                cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
                cmd.Parameters.Add(new SqlParameter("@PassWord", PassWord));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@deviceID", deviceID));


                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;
            }
            trans.Commit();

        }

        public int getUserIDFromUsername(string username)
        {   
            

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("getIDfromUsername", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Username", username));
                

                SqlDataReader rdr = cmd.ExecuteReader();

                userID = (int)rdr["UserID"];
                    
                
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;
                // trans.getcon().Close();
            }
            
            //trans.Commit();
            trans.getcon().Close();
            return userID;
        }
    }

}