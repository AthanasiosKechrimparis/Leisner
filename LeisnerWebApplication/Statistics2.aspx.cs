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
        public int DeviceNr;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            txtStartDate.Text = Calendar1.SelectedDate.ToShortDateString();
            txtEndDate.Text = Calendar2.SelectedDate.ToShortDateString();
            Chart1.Visible = false;
            if (!IsPostBack)
            {
                
                txtStartDate.Text = Calendar1.SelectedDate.ToShortDateString();
                txtEndDate.Text = Calendar2.SelectedDate.ToShortDateString();
                Chart1.Visible = false;

                
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
            
            DeviceNr = int.Parse(IDBox.Text);
            ButtonStuff();
            List<LeisnerRef.Accident> accidentlist = BWS.GetListByDay(DateTime.Parse((sender as LinkButton).CommandArgument), DeviceNr).ToList();
            List<Accident> newaccidentlist = new List<Accident>();
            foreach (LeisnerRef.Accident a in accidentlist)
            {
                Accident acc = new Accident(a.AccidentIDk__BackingField, a.Amountk__BackingField,a.TimeOfAccidentk__BackingField,a.Devicek__BackingField, a.Drinksk__BackingField, a.TimeSleepk__BackingField,a.TimeToiletk__BackingField, a.ToiletVisitk__BackingField, a.Versionk__BackingField);
                newaccidentlist.Add(acc);
            }

            ListView2.DataSource = newaccidentlist;
            ListView2.DataBind();
            ListView3.DataSource = newaccidentlist;
            ListView3.DataBind();
        }

        public void ButtonStuff()
        {

            
            ClearViews();
            DeviceNr = int.Parse(IDBox.Text);
            selectStart = Calendar1.SelectedDate;
            selectEnd = Calendar2.SelectedDate;
            
            List<LeisnerRef.Day> dayslist = BWS.GetDayAccidents(selectStart, selectEnd, DeviceNr).ToList();
            List<Day> newdaylist = new List<Day>();
            foreach (LeisnerRef.Day d in dayslist)
            {
                Day day = new Day(d.Datek__BackingField, d.AccidentsNumberk__BackingField, d.Averagek__BackingField);
                newdaylist.Add(day);
            }
            BWS.ShowGraph(dayslist);
            

            

            Chart1.Visible = true;


            ListView1.DataSource = newdaylist;
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