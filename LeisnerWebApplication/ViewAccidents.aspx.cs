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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == "NO")
            {
                IDBox.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

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