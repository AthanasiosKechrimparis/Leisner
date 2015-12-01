using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    public partial class sendMessage : System.Web.UI.Page
    {
        BWSServiceClient bedW = new BWSServiceClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            string subject = TextBox1.Text;
            int UserID = int.Parse(Label1.Text);
            DateTime date = DateTime.Now;
            string nme = Session["usrnme"].ToString();
            string areaTxt = TextArea1.InnerText;

            bedW.SendMessage(  TextArea1.InnerText,date, TextBox1.Text, UserID);
            

        }
    }
}