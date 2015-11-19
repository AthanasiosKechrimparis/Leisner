using LeisnerWebApplication.LeisnerRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class ViewAccidents : System.Web.UI.Page
    {
        BWSServiceClient bedW = new BWSServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == "NO")
            {
                IDBox.Enabled = false;
                IDBox.Text = Session["UserID"].ToString();
                int ID = Convert.ToInt32(Session["UserID"]);
                bedW.ReadAccidents(ID);
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            bedW.ReadAccidents(int.Parse(IDBox.Text));
            //ListView1.DataSource = listofAccidents;
            //ListView1.DataBind();
        }

        protected void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

        }

    }
}