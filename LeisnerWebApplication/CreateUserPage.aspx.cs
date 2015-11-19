using LeisnerWebApplication.LeisnerRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebApplication
{
    class User
    {
        public string  name { get; set; }
        public string Type { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int devicenr { get; set; }

        public User(string n, string u, string p, int d)
        {
            name = n;
            username = u;
            password = p;
            devicenr = d;
        }
    }

    public partial class CreateUserPage : System.Web.UI.Page
    {
        BWSServiceClient bedW = new BWSServiceClient();
        
        List<User> listofUser = new List<User>();
        List<string> type = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)    // First time the page is loaded
            {
                LoadDropDownList();
            }
           
        }
        public void LoadDropDownList()
        {
            type.Add("User");
            type.Add("Admin");
            DropDownList1.DataSource = type;
            DropDownList1.DataBind();
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Create_Click(object sender, EventArgs e)
        {
            string birthday = "";
            int deviceID = 0;
            if (txtb_Birthday.Text != "")
            {
                birthday = txtb_Birthday.Text;
            }
            if (txtb_Device.Text != "")
            {
                deviceID = int.Parse(txtb_Device.Text);
            }

           // bedW.SignUp(DropDownList1.SelectedIndex.ToString(), birthday, txtb_Username.Text, txtb_Password.Text, txtb_Name.Text, deviceID);
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex.Equals(1))
            {
                txtb_Device.Enabled = false;
            }
            if (DropDownList1.SelectedIndex.Equals(0))
            {
                txtb_Device.Enabled = true;
            }
        }
    }
}