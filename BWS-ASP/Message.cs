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

        List<Message> messageList = new List<Message>();

        public Message()
        {
            this.MessageText = MessageText;
            this.SendDate = SendDate;
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

                    Message A = new Message();
                    A.MessageText = rdr["Message"].ToString();
                    A.SendDate = DateTime.Parse(rdr["sendDate"].ToString());
                    A.User.Name = rdr["Name"].ToString();
                    messageList.Add(A);
                }
            }
            catch (Exception e)
            {
                trans.RollBack();
                throw e;

            }


            trans.getcon().Close();
            return messageList;

        }



    }
}