using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ManageAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageAccidents.aspx");
        }

        protected void btn_Statistics_Click(object sender, EventArgs e)
        {
            Response.Redirect("Statistics2.aspx");
        }

        protected void btn_CreateUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUserPage.aspx");
        }

        protected void btn_Messages_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReceiveMessages.aspx");
        }
    }
}