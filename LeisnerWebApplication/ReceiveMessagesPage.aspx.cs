using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    public partial class ReceiveMessagesPage : System.Web.UI.Page
    {
        BWSServiceClient bedW = new BWSServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in ddList.Items)
            {
                ListView2.DataSource = bedW.GetMessage(int.Parse(ddList.SelectedValue.ToString()));
                ListView2.DataBind();
            }
        }
    }
}