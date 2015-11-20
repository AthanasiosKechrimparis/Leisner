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
        List<Accident> accList;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                if((int)Session["Perm"] == 1)
                {
                    txtb_UserID.Enabled = true;
                }
                else if ((int)Session["Perm"] == 0)
                {
                    txtb_UserID.Enabled = false;
                    txtb_UserID.Text = Session["Perm"].ToString();
                }

                if(ViewState["AccidentList"] != null)
                {
                    ListView1.DataSource = (List<Accident>)ViewState["AccidentList"];
                    ListView1.DataBind();
                }

                txtb_Amount.Enabled = false;
                txtb_DeviceID.Enabled = false;
                txtb_Date.Enabled = false;
                txtb_Hour.Enabled = false;
                txtb_Minute.Enabled = false;
                txtb_AccidentID.Enabled = false;
            }

            //GetAccidents();
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        

        protected void ListView1_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {

        }

        protected void btn_GetAccidents_Click(object sender, EventArgs e)
        {
            GetAccidents();
        }

        private void GetAccidents()
        {
            int userID = int.Parse(txtb_UserID.Text);

            Accident acc;
            accList = new List<Accident>();

            LeisnerRef.AccidentDTO[] L1 = cli.ReadAccidents(userID);

            List<LeisnerRef.AccidentDTO> listOfAccidents = L1.ToList();

            foreach (AccidentDTO aDTO in listOfAccidents)
            {
                acc = new Accident(aDTO.AccidentIDk__BackingField, aDTO.DeviceIDk__BackingField, aDTO.Datek__BackingField, aDTO.Amountk__BackingField);

                accList.Add(acc);
            }

            ViewState["AccidentList"] = accList;

            ListView1.DataSource = accList;
            ListView1.DataBind();
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(txtb_Date.Text);

            //foreach(Accident a in listofAccidents)
            //{
            //    if (a.AccidentID == int.Parse(txtb_AccidentID.Text))
            //    {
            //        a.Amount = int.Parse(txtb_Amount.Text);
            //        a.Date = date;
            //        a.DeviceID = int.Parse(txtb_DeviceID.Text);
            //    }
            //}

            cli.UpdateAccident(int.Parse(txtb_AccidentID.Text), int.Parse(txtb_Amount.Text), date, int.Parse(txtb_DeviceID.Text));

            lbl_Status.Text = "Status: Update Successful";
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

            foreach (Accident a in (List<Accident>)ViewState["AccidentList"])
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