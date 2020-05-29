using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace eDahabWebApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        BL.CLS_AddUser Register = new BL.CLS_AddUser();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var createdBy = Session["Username"].ToString();
            //Validate Password meet the requirement or not
            var checkPassword = BL.CLS_ValidPassword.ValidatePassword(password);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                lblErrorMessage.Text = "Username and Password is required";
            else if (checkPassword == false)
                lblErrorMessage.Text = "Password should Contain Capital latter";

            else
            {
                DataTable dt = Register.CheckUsername(username);
                int checkUsername = Convert.ToInt32(dt.Rows[0][0]);
                if (checkUsername == -1)
                {
                    Register.RegisterUser(username, password, createdBy);
                    lblErrorMessage.Text = "";
                    lblSuccessMessage.Text = "User created successfully.";
                }
                else
                {
                    lblErrorMessage.Text = "Username already taken.";
                    lblSuccessMessage.Text = "";
                }
            }



        }
    }
}