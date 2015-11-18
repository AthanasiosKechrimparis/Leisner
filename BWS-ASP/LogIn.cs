﻿using System;
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


        public void SignUp(string UserName, string PassWord, int Permision, string Name, int Age)
        {
            Transaction trans;
            SqlCommand cmd;

            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("NewSignUp", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
                cmd.Parameters.Add(new SqlParameter("@PassWord", PassWord));
                cmd.Parameters.Add(new SqlParameter("@Permision", Permision));
                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@Age", Age));

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