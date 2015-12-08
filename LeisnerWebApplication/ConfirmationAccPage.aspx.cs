using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    public partial class ConfirmationAccPage : System.Web.UI.Page
    {
        BWSServiceClient service = new BWSServiceClient();
        int Device;
        int Amount;
        DateTime TimeAcc;
        int Drinks;
        DateTime TimeSleep;
        DateTime TimeToilet;
        int ToiletVisit;
        protected void Page_Load(object sender, EventArgs e)
        {
            Device = ((int)Session["Device"]);
            Amount = ((int)Session["Amount"]);
            TimeAcc = ((DateTime)Session["DateAccident"]);
            Drinks = ((int)Session["Drink"]);
            TimeSleep = ((DateTime)Session["DateSleep"]);
            TimeToilet = ((DateTime)Session["ToiletSleep"]);
            ToiletVisit = ((int)Session["ToiletVisit"]);

            lbDevice.Text = Device.ToString();
            lbAmount.Text = Amount.ToString();
            lbTimeAcc.Text = TimeAcc.ToString();
            lbDrinks.Text = Drinks.ToString();
            lbTimeSleep.Text = TimeSleep.ToString();
            lbTimeToilet.Text = TimeToilet.ToString();
            lbToiletVisit.Text = ToiletVisit.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            service.RegisterAccident(Device, Amount, TimeAcc, Drinks, TimeSleep, TimeToilet, ToiletVisit);
            Response.Redirect("InsertAccidentPage.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertAccidentPage.aspx");
        }
    }
}