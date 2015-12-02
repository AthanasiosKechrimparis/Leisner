using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAccidents.aspx");
        }

        protected void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertAccidentPage.aspx");
        }

        protected void btn_ManageAccident_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageAccidents.aspx");
        }

        protected void btn_Messages_Click(object sender, EventArgs e)
        {
            Response.Redirect("sendMessage.aspx");
        }
    }
}