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

        int perm = 4;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (perm == 3)
                {
                    //lbl_Status.Text = "Login Failed";
                    txtb_Password.Text = "";
                    txtb_Username.Text = "";
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
                int userID = cli.getIDFromUsername(txtb_Username.Text);
              //  Session.Add("UserID", userID);
                Session["UserID"] = userID;
                //Session.Add("Perm", perm);

                if (perm == 1)
                {
                    Response.Redirect("AdminPage.aspx");
                    
                }
                else if (perm == 0)
                {
                    Response.Redirect("UserPage.aspx");
                   
                }

            }
            catch (Exception)
            {
                
                throw;
                
            }
          
            
        }
    }
}