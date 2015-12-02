using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BWS_ASP
{
    public class Message
    {
        private Transaction trans;
        private SqlCommand cmd;

        [DataMember]
        public string MessageText { get; set; }

        [DataMember]
        public DateTime SendDate { get; set; }

        [DataMember]
        public Costumer User { get; set; }
        [DataMember]
        public string Tittle { get; set; }

        List<Message> messageList;

        public Message()
        {
            this.MessageText = MessageText;
            this.SendDate = SendDate;
            this.Tittle = Tittle;
            this.User = User;
        }

        public Message(string MessageText, DateTime SendDate, string Tittle, Costumer User)
        {
            // TODO: Complete member initialization
            this.MessageText = MessageText;
            this.SendDate = SendDate;
            this.Tittle = Tittle;
            this.User = User;
            //this.User = User;
        }

        public List<Message> GetMessage(int UserID)
        {
            
            trans = new Transaction();
            trans.BegindTransactions();
            try
            {
                cmd = new SqlCommand("GetMessage", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    messageList = new List<Message>();
                    Message A = new Message(rdr["Message"].ToString(), DateTime.Parse(rdr["sendDate"].ToString()), rdr["Tittle"].ToString(), new Costumer(rdr["Name"].ToString()));
                    //A.MessageText = rdr["Message"].ToString();
                    //A.SendDate = DateTime.Parse(rdr["sendDate"].ToString());
                    //A.Tittle = rdr["Tittle"].ToString();
                    //A.User.Name = rdr["Name"].ToString();

                    messageList.Add(A);
                   
                }
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }

            //trans.Commit();
            trans.getcon().Close();
            return messageList;

        }

        public void SendMessage(string Messagtxt, DateTime senddate, string Tittle, int UserID)

        {
            Transaction trans;
            SqlCommand cmd;

            trans = new Transaction();

            trans.BegindTransactions();
            //int i = 101;
            try
            {
                cmd = new SqlCommand("SendMessage", trans.getcon(), trans.GetTransaction());

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Message", Messagtxt));
                cmd.Parameters.Add(new SqlParameter("@sendDate", senddate));
                cmd.Parameters.Add(new SqlParameter("@Tittle", Tittle));
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));

                //cmd.Parameters.Add(new SqlParameter("@Version", (Version + 1)));

                cmd.ExecuteNonQuery();
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