using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{

    public partial class Default : System.Web.UI.Page
    {

        BWSServiceClient BWS = new BWSServiceClient();

        DateTime selectStart;
        DateTime selectEnd;

        List<Accident> accidentsDay = new List<Accident>();
        List<Accident> accidentsMulti = new List<Accident>();
        List<Accident> accidents = new List<Accident>();
        List<Day> days = new List<Day>();
        List<DateTime> xDates = new List<DateTime>();
        List<int> ySizes = new List<int>();
        public int numberOfAccidents { get; set; }



        protected void Page_Load(object sender, EventArgs e)
        {

            txtStartDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            Chart1.Visible = false;
            if (!IsPostBack)
            {
                txtStartDate.Text = Calendar1.SelectedDate.ToShortDateString();
                txtEndDate.Text = Calendar2.SelectedDate.ToShortDateString();
                Chart1.Visible = false;

                ButtonStuff();
            }

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GetDataBtn_Click(object sender, EventArgs e)
        {

            ButtonStuff();
        }

        


        




        public void ClearViews()
        {
            ListView1.DataSource = null;
            ListView1.DataBind();
            ListView2.DataSource = null;
            ListView2.DataBind();
            ListView3.DataSource = null;
            ListView3.DataBind();
        }


        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtStartDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Method(object sender, EventArgs e)
        {
            string DeviceID = IDBox.Text;
            ButtonStuff();
            

            ListView2.DataSource = BWS.GetListByDay(DateTime.Parse((sender as LinkButton).CommandArgument), DeviceID);
            ListView2.DataBind();
            ListView3.DataSource = BWS.GetListByDay(DateTime.Parse((sender as LinkButton).CommandArgument), DeviceID);
            ListView3.DataBind();
        }

        public void ButtonStuff()
        {
            ClearViews();

            selectStart = Calendar1.SelectedDate;
            selectEnd = Calendar2.SelectedDate;


            string DeviceNr = IDBox.Text;
            BWS.GetDayAccidents(selectStart, selectEnd, DeviceNr);

            Chart1.Visible = true;


            ListView1.DataSource = days;
            ListView1.DataBind();

        }

        protected void Chart1_Load(object sender, EventArgs e)
        {


        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = Calendar2.SelectedDate.ToShortDateString();
        }
    }
}