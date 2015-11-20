using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    public partial class MainPage : System.Web.UI.Page
    {
        BWSServiceClient cli = new BWSServiceClient();  
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["Perm"] == null)
                {
                    lbl_Status.Text = "Login Failed";
                }
            }
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            //if(txtb_Username.Text == "Admin" && txtb_Password.Text == "1234")
            //{
            //    Session.Add("Admin", "YES");
            //    Response.Redirect("AdminPage.aspx");
            //}
            //else if(txtb_Username.Text == "User" && txtb_Password.Text == "1234")
            //{
            //    Session.Add("Admin", "NO");
            //    Response.Redirect("UserPage.aspx");
            //}
            try
            {
                int perm = cli.logIn(txtb_Username.Text, txtb_Password.Text);

                if (perm == 1)
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else if (perm == 0)
                {
                    Response.Redirect("UserPage.aspx");
                }

                Session.Add("Perm", perm);
            }
            catch (Exception)
            {
                
                throw;
                lbl_Status.Text = "Login failed";
            }
          
            
        }
    }
}