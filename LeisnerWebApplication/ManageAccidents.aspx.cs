using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    public partial class ManageAccidents : System.Web.UI.Page
    {
        List<Accident> listofAccidents;
        BWSServiceClient cli = new BWSServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            listofAccidents = new List<Accident>();

            Accident a1 = new Accident(1, 123, new DateTime(2015, 10, 10), 5);
            Accident a2 = new Accident(2, 456, new DateTime(2015, 4, 8), 10);
            Accident a3 = new Accident(3, 678, new DateTime(2015, 10, 1), 15);

            listofAccidents.Add(a1);
            listofAccidents.Add(a2);
            listofAccidents.Add(a3);

            ListView1.DataSource = listofAccidents;
            ListView1.DataBind();
            if (!IsPostBack)
            {
                txtb_Amount.Enabled = false;
                txtb_DeviceID.Enabled = false;
                txtb_Date.Enabled = false;
                txtb_Hour.Enabled = false;
                txtb_Minute.Enabled = false;
                txtb_AccidentID.Enabled = false;
            }
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        

        protected void ListView1_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

        }

        protected void btn_GetAccidents_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(txtb_UserID.Text);

            Accident acc;
            List<Accident> accList = new List<Accident>();

            LeisnerRef.AccidentDTO[] L1 = cli.ReadAccidents(userID);

            List<LeisnerRef.AccidentDTO> listOfAccidents = L1.ToList();

            foreach (AccidentDTO aDTO in listOfAccidents)
            {
                acc = new Accident(aDTO.AccidentIDk__BackingField, aDTO.DeviceIDk__BackingField, aDTO.Datek__BackingField, aDTO.Amountk__BackingField);

                accList.Add(acc);
            }

            

            ListView1.DataSource = accList;
            ListView1.DataBind();
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(txtb_Date.Text);

            cli.UpdateAccident(int.Parse(txtb_AccidentID.Text), int.Parse(txtb_Amount.Text), date, int.Parse(txtb_DeviceID.Text));

            
        }

        protected void rBtn_DeviceID_CheckedChanged(object sender, EventArgs e)
        {
            txtb_Amount.Enabled = false;
            txtb_DeviceID.Enabled = true;
            txtb_Date.Enabled = false;
            txtb_Hour.Enabled = false;
            txtb_Minute.Enabled = false;

            
        }

        protected void rBtn_Amount_CheckedChanged(object sender, EventArgs e)
        {
            txtb_Amount.Enabled = true;
            txtb_DeviceID.Enabled = false;
            txtb_Date.Enabled = false;
            txtb_Hour.Enabled = false;
            txtb_Minute.Enabled = false;
        }

        protected void rBtn_Date_CheckedChanged(object sender, EventArgs e)
        {
            txtb_Amount.Enabled = false;
            txtb_DeviceID.Enabled = false;
            txtb_Date.Enabled = true;
            txtb_Hour.Enabled = true;
            txtb_Minute.Enabled = true;
        }

        protected void SelectAccident(object sender, EventArgs e)
        {
            txtb_AccidentID.Text = (sender as LinkButton).CommandArgument.ToString();

            foreach (Accident a in listofAccidents)
            {
                if (a.AccidentID == int.Parse((sender as LinkButton).CommandArgument))
                {
                    txtb_Amount.Text = a.Amount.ToString();
                    txtb_DeviceID.Text = a.DeviceID.ToString();
                    txtb_Date.Text = a.Date.ToString();
                }
            }
        }
    }
}