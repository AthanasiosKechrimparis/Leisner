using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
   
    public partial class InsertAccidentPage : System.Web.UI.Page
    {
        LeisnerRef.BWSServiceClient service = new BWSServiceClient();

        int AmountStr;
        int AmountR;
        DateTime DateSleepStr;
        DateTime SleepDateStr;
        DateTime toiletDateStr;
        int toiletVisit;
        int ToiletVisitStr;

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
                AmountStr = int.Parse(AmountR.ToString());
            }
            else if (rdlAmount.SelectedIndex == 1)
            {
                AmountR = 2;
                AmountStr = int.Parse(AmountR.ToString());
            }
            else if (rdlAmount.SelectedIndex == 2)
            {
                AmountR = 3;
                AmountStr = int.Parse(AmountR.ToString());
            }
            else if (rdlAmount.SelectedIndex == 3)
            {
                AmountR = 0;
                AmountStr = int.Parse(AmountR.ToString());
            }


            DateTime date = new DateTime();
            string CustomDate = Calendar1.SelectedDate.ToString("dd-MM-yyyy") + " " + txtHour.Text + ":" + txtMinute.Text;

            string SleepDate = Calendar1.SelectedDate.ToString("dd-MM-yyyy") + " " + txttimeSleep.Text + ":" + txtminutesleep.Text;
            string ToiletDate = Calendar1.SelectedDate.ToString("dd-MM-yyyy") + " " + txthoursToilet.Text + ":" + txtminutesToilet.Text;
            DateTime sleepDate = new DateTime();
            DateTime toiletDate = new DateTime();



            if (rdbListDate.SelectedIndex == 0)
            {
                date = DateTime.Now;
                DateSleepStr = DateTime.Parse(date.ToString());

                string NowDateSleep = date.ToString("dd-MM-yyyy") + " " + txttimeSleep.Text + ":" + txtminutesleep.Text;
                sleepDate = DateTime.ParseExact(NowDateSleep, "dd-MM-yyyy H:m", CultureInfo.InvariantCulture);
                SleepDateStr = DateTime.Parse(sleepDate.ToString());

                string HourToilet = date.ToString("dd-MM-yyyy") + " " + txthoursToilet.Text + ":" + txtminutesToilet.Text;
                toiletDate = DateTime.ParseExact(HourToilet, "dd-MM-yyyy H:m", CultureInfo.InvariantCulture);
                toiletDateStr = DateTime.Parse(toiletDate.ToString());
            }
            if (rdbListDate.SelectedIndex == 1)
            {
                date = DateTime.ParseExact(CustomDate, "dd-MM-yyyy H:m", CultureInfo.InvariantCulture);
                DateSleepStr = DateTime.Parse(date.ToString());

                sleepDate = DateTime.ParseExact(SleepDate, "dd-MM-yyyy H:m", CultureInfo.InvariantCulture);
                SleepDateStr = DateTime.Parse(sleepDate.ToString());

                toiletDate = DateTime.ParseExact(ToiletDate, "dd-MM-yyyy H:m", CultureInfo.InvariantCulture);
                toiletDateStr = DateTime.Parse(toiletDate.ToString());
            }


            int Drink = int.Parse(txtdrink.Text);
            int DrinkStr = int.Parse(Drink.ToString());

            if (rdToiletVisit.SelectedIndex == 0)
            {
                toiletVisit = 0;
                ToiletVisitStr = int.Parse(toiletVisit.ToString());
            }
            else if (rdToiletVisit.SelectedIndex == 1)
            {
                toiletVisit = 1;
                ToiletVisitStr = int.Parse(toiletVisit.ToString());
            }
            else if (rdToiletVisit.SelectedIndex == 2)
            {
                toiletVisit = 2;
                ToiletVisitStr = int.Parse(toiletVisit.ToString());
            }
            else if (rdToiletVisit.SelectedIndex == 3)
            {
                toiletVisit = 3;
                ToiletVisitStr = int.Parse(toiletVisit.ToString());
            }

            //service.RegisterAccident(DeviceID, AmountR, date, Drink, sleepDate, toiletDate, toiletVisit);

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