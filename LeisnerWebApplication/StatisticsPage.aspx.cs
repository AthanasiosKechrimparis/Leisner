using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    public partial class StatisticsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Accident> listofAccidents = new List<Accident>();

            Accident a1 = new Accident(123, new DateTime(2015, 10, 10), 5);
            Accident a2 = new Accident(456, new DateTime(2015, 4, 8), 10);
            Accident a3 = new Accident(678, new DateTime(2015, 10, 1), 15);

            listofAccidents.Add(a1);
            listofAccidents.Add(a2);
            listofAccidents.Add(a3);

            ListView1.DataSource = listofAccidents;
            ListView1.DataBind();

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

        }
    }
}