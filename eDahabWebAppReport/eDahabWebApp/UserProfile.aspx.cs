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
        BL.CLS_Login UserDetail = new BL.CLS_Login();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            var username = Session["Username"].ToString();
            DataTable dt = UserDetail.GetUserDatail(username);
            txtUsername.Text = dt.Rows[0][0].ToString();
            txtPassword.Text = dt.Rows[0][1].ToString();

        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}