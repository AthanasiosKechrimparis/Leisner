using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;

namespace Statistics
{

    public partial class Default : System.Web.UI.Page
    {
        DateTime selectStart;
        DateTime selectEnd;
        Accident2 demo1 = new Accident2(DateTime.Today, DateTime.ParseExact("21:00:00", "H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 3, false, 1, 1);
        Accident2 demo2 = new Accident2(DateTime.Today, DateTime.ParseExact("22:30:00", "H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 1, false, 1, 2);
        Accident2 demo3 = new Accident2(DateTime.Today, DateTime.ParseExact("21:00:00", "H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 3, false, 1, 3);
        Accident2 demo4 = new Accident2(DateTime.ParseExact("15-11-2015", "dd-MM-yyyy", null), DateTime.ParseExact("15-11-2015 22:30:00", "dd-MM-yyyy H:m:s", null), DateTime.ParseExact("21:00:00", "H:m:s", null), 1, false, 1, 4);
        Accident2 demo5 = new Accident2(DateTime.ParseExact("11-11-2015", "dd-MM-yyyy", null), DateTime.ParseExact("11-11-2015 20:30:00", "dd-MM-yyyy H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 2, false, 1, 5);
        Accident2 demo6 = new Accident2(DateTime.ParseExact("12-11-2015", "dd-MM-yyyy", null), DateTime.ParseExact("12-11-2015 20:30:00", "dd-MM-yyyy H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 3, false, 1, 6);
        Accident2 demo7 = new Accident2(DateTime.ParseExact("13-11-2015", "dd-MM-yyyy", null), DateTime.ParseExact("13-11-2015 20:30:00", "dd-MM-yyyy H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 1, false, 1, 7);
        Accident2 demo8 = new Accident2(DateTime.ParseExact("14-11-2015", "dd-MM-yyyy", null), DateTime.ParseExact("14-11-2015 20:30:00", "dd-MM-yyyy H:m:s", null), DateTime.ParseExact("20:00:00", "H:m:s", null), 2, false, 1, 8);
        List<Accident2> accidentsDay = new List<Accident2>();
        List<Accident2> accidentsMulti = new List<Accident2>();
        List<Accident2> accidents = new List<Accident2>();
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
        public int GetAverage(List<Accident2> accidentlist)
        {
            int i = 0;
            foreach (Accident2 a in accidentlist)
            {
                i = i + a.sizeOfAccident;
            }
            i = i / accidentlist.Count();
            return i;
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GetDataBtn_Click(object sender, EventArgs e)
        {

            ButtonStuff();
        }

        public void ShowResultsDay()
        {
            accidents.Clear();
            
            accidents.Add(demo1);
            accidents.Add(demo2);
            numberOfAccidents = accidents.Count();

            Day day = new Day(demo1.startDate, numberOfAccidents, GetAverage(accidents));
            days.Add(day);
            days.OrderByDescending(d => d.Date);
            
            
            
        }
        public void ShowStatisticsDay()
        {
            accidentsDay.Clear();
            
            decimal averageSize = ((demo1.sizeOfAccident + demo2.sizeOfAccident) / 2);
            accidentsDay.Add(demo1);
            accidentsDay.Add(demo2);
            days.OrderByDescending(d => d.Date);
            
           
            
        }

        public void ShowResultsMulti()
        {
            accidents.Clear();
            
            decimal averageSize = ((demo3.sizeOfAccident + demo4.sizeOfAccident + demo5.sizeOfAccident) / 2);
            accidents.Add(demo3);
            accidents.Add(demo4);
            accidents.Add(demo5);
            accidents.Add(demo6);
            accidents.Add(demo7);
            accidents.Add(demo8);
            Day day1 = new Day(demo3.startDate, 1, demo3.sizeOfAccident);
            Day day2 = new Day(demo4.startDate, 1, demo4.sizeOfAccident);
            Day day3 = new Day(demo5.startDate, 1, demo5.sizeOfAccident);
            Day day4 = new Day(demo6.startDate, 1, demo6.sizeOfAccident);
            Day day5 = new Day(demo7.startDate, 1, demo7.sizeOfAccident);
            Day day6 = new Day(demo8.startDate, 1, demo8.sizeOfAccident);
            days.Add(day1);
            days.Add(day2);
            days.Add(day3);
            days.Add(day4);
            days.Add(day5);
            days.Add(day6);
            days = days.OrderByDescending(d => d.Date).ToList();
            accidents.OrderByDescending(d => d.startDate);
            foreach (Day a in days)
            {
                xDates.Add(a.Date);
                xDates.OrderByDescending(d => d.Date);
                ySizes.Add(a.Average);
            }
            Chart1.Series[0].Points.DataBindXY(xDates, ySizes);
            Chart1.Series[0].Enabled = true;
            Chart1.Enabled = true;
            
            
        }
        public void ShowStatisticsMulti()
        {
            accidentsMulti.Clear();
            days.Clear();
            
            
            accidentsMulti.Add(demo3);
            accidentsMulti.Add(demo4);
            accidentsMulti.Add(demo5);
            decimal averageSize = ((demo3.sizeOfAccident + demo4.sizeOfAccident + demo5.sizeOfAccident) / accidentsMulti.Count());
            accidentsMulti.OrderByDescending(d => d.startDate);
           
            
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
            ButtonStuff();
            List<Accident2> dayaccidents = new List<Accident2>();
            foreach (Accident2 a in accidents)
            
            {
                if (a.startDate == DateTime.Parse((sender as LinkButton).CommandArgument))
                {
                    dayaccidents.Add(a);
                }
            }
            ListView2.DataSource = dayaccidents;
            ListView2.DataBind();
            ListView3.DataSource = dayaccidents;
            ListView3.DataBind();
        }

        public void ButtonStuff()
        {
            ClearViews();
            
            selectStart = Calendar1.SelectedDate;
            selectEnd = Calendar2.SelectedDate;
            
                if (RadioButtonList2.SelectedIndex == 0)
                {
                    ShowResultsDay();
                    //ShowStatisticsDay();
                    Chart1.Visible = true;
                }

                if (RadioButtonList2.SelectedIndex == 1)
                {
                    ShowResultsMulti();
                    //ShowStatisticsMulti();
                    Chart1.Visible = true;
                }
          
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