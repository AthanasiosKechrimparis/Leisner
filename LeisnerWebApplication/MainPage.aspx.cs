using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            if(txtb_Username.Text == "Admin" && txtb_Password.Text == "1234")
            {
                Session.Add("Admin", "YES");
                Response.Redirect("AdminPage.aspx");
            }
            else if(txtb_Username.Text == "User" && txtb_Password.Text == "1234")
            {
                Session.Add("Admin", "NO");
                Response.Redirect("UserPage.aspx");
            }
        }
    }
}