using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class ConfirmationAccPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbDevice.Text = (string)Session["Device"];
            lbAmount.Text = (string)Session["Amount"];
            lbTimeAcc.Text = (string)Session["DateAccident"];
            lbDrinks.Text = (string)Session["Drink"];
            lbTimeSleep.Text = (string)Session["DateSleep"];
            lbTimeToilet.Text = (string)Session["ToiletSleep"];
            lbToiletVisit.Text = (string)Session["ToiletVisit"];
        }
    }
}