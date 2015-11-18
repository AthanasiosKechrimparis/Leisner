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
        
        List<User> listofUser = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Create_Click(object sender, EventArgs e)
        {
            User newUser = new User(txtb_Name.Text, txtb_Username.Text, txtb_Password.Text, int.Parse(txtb_Device.Text));
            listofUser.Add(newUser);
        }
    }
}