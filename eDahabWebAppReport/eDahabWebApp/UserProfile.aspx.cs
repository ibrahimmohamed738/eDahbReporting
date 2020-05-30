using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eDahabWebApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        BL.CLS_AddUser Register = new BL.CLS_AddUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            var username = Session["Username"].ToString();

            DataTable dt = Register.CheckUsername(username);

            txtUsername.Text = dt.Rows[0][0].ToString();
        }
    }
}