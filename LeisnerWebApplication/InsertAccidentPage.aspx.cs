using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class InsertAccidentPage : System.Web.UI.Page
    {
        string AmountStr;
        int AmountR;
        string DateSleepStr;
        string SleepDateStr;
        string toiletDateStr;
        int toiletVisit;
        string ToiletVisitStr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtHour.Enabled = false;
                txtMinute.Enabled = false;
                Calendar1.Enabled = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int DeviceID = int.Parse(txtDevice.Text);
            string Device = DeviceID.ToString();

            if (rdlAmount.SelectedIndex == 0)
            {
                AmountR = 1;
                AmountStr = AmountR.ToString();
            }
            else if (rdlAmount.SelectedIndex == 1)
            {
                AmountR = 2;
                AmountStr = AmountR.ToString();
            }
            else if (rdlAmount.SelectedIndex == 2)
            {
                AmountR = 3;
                AmountStr = AmountR.ToString();
            }
            else if (rdlAmount.SelectedIndex == 3)
            {
                AmountR = 0;
                AmountStr = AmountR.ToString();
            }


            DateTime date = new DateTime();
            string CustomDate = Calendar1.SelectedDate.ToString("dd/MM/yyyy") + " " + txtHour.Text + ":" + txtMinute.Text;

            string SleepDate = Calendar1.SelectedDate.ToString("dd/MM/yyyy") + " " + txttimeSleep.Text + ":" + txtminutesleep.Text;
            string ToiletDate = Calendar1.SelectedDate.ToString("dd/MM/yyyy") + " " + txthoursToilet.Text + ":" + txtminutesToilet.Text;
            DateTime sleepDate = new DateTime();
            DateTime toiletDate = new DateTime();



            if (rdbListDate.SelectedIndex == 0)
            {
                date = DateTime.Now;
                DateSleepStr = date.ToString();

                string NowDateSleep = date.ToString("dd/MM/yyyy") + " " + txttimeSleep.Text + ":" + txtminutesleep.Text;
                sleepDate = DateTime.ParseExact(NowDateSleep, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture);
                SleepDateStr = sleepDate.ToString();

                string HourToilet = date.ToString("dd/MM/yyyy") + " " + txthoursToilet.Text + ":" + txtminutesToilet.Text;
                toiletDate = DateTime.ParseExact(HourToilet, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture);
                toiletDateStr = toiletDate.ToString();
            }
            if (rdbListDate.SelectedIndex == 1)
            {
                date = DateTime.ParseExact(CustomDate, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture);
                DateSleepStr = date.ToString();

                sleepDate = DateTime.ParseExact(SleepDate, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture);
                SleepDateStr = sleepDate.ToString();

                toiletDate = DateTime.ParseExact(ToiletDate, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture);
                toiletDateStr = toiletDate.ToString();
            }


            int Drink = int.Parse(txtdrink.Text);
            string DrinkStr = Drink.ToString();

            if (rdToiletVisit.SelectedIndex == 0)
            {
                toiletVisit = 1;
                ToiletVisitStr = toiletVisit.ToString();
            }
            else if (rdToiletVisit.SelectedIndex == 1)
            {
                toiletVisit = 2;
                ToiletVisitStr = toiletVisit.ToString();
            }
            else if (rdToiletVisit.SelectedIndex == 2)
            {
                toiletVisit = 3;
                ToiletVisitStr = toiletVisit.ToString();
            }


            bedAccident.DeviceID = DeviceID;
            bedAccident.Amount = AmountR;
            bedAccident.AccidentTime = date;
            bedAccident.Drinks = Drink;
            bedAccident.SleepTime = sleepDate;
            bedAccident.ToiletSleep = toiletDate;
            bedAccident.ToiletVisit = toiletVisit;

            Session["Device"] = Device;
            Session["Amount"] = AmountStr;
            Session["DateAccident"] = DateSleepStr;
            Session["Drink"] = DrinkStr;
            Session["DateSleep"] = SleepDateStr;
            Session["ToiletSleep"] = toiletDateStr;
            Session["ToiletVisit"] = ToiletVisitStr;

            Response.Redirect("ConfirmationAccPage.aspx");
            
        }

        protected void rdbListDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbListDate.SelectedIndex == 1)
            {
                 txtHour.Enabled = true;
                 txtMinute.Enabled = true;
                 Calendar1.Enabled = true;
            }
        }
    }
}