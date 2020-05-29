using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eDahabWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        BL.CLS_Login login = new BL.CLS_Login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                lblErrorMessage.Text = "Username and Password is required";
            else 
            {
                DataTable dt = login.LOGIN(username, BL.CLS_ValidPassword.hashPassword(password));
           
                int checkLogin = Convert.ToInt32(dt.Rows[0][0]);

           
                if (checkLogin == -1)
            
                {
                
                    lblErrorMessage.Text = "Invalid username or password";
            
                }
            
                else
            
                {
                
                    var User = dt.Rows[0][1].ToString();
                
                    Session["Username"] = User;
                
                    Response.Redirect("Default.aspx");
            
                }
            }
        }
    }
}