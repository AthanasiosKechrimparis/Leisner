using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace BWS_ASP
{

    public class Transaction
    {

        private const string CONNECTION_STRING = @"Server=msdb3.surftown.dk;" + "Database=mitoden_dbgr15;" + "User Id=mitoden_dbgr15;" + "Password=dmgruppebjbu;" + "MultipleActiveResultSets=True;";
        
        private SqlConnection con;
       
        private SqlTransaction trans;

        public void BegindTransactions()
        {
            con = new SqlConnection(CONNECTION_STRING);

            con.Open();
            trans = con.BeginTransaction(IsolationLevel.Serializable);
        }

        public void Commit()
        {
            trans.Commit();
            con.Close();

        }

        public void RollBack()
        {
            trans.Rollback();
            con.Close();
        }

        public SqlConnection getcon()
        {
            return con;
        }
        public SqlTransaction GetTransaction() { return trans; }

        public SqlConnection GetConnection() { return con; }
    }
}