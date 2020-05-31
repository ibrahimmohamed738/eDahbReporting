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

            ErrorMsg.Visible = false;
            SuccessMsg.Visible = false;
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var createdBy = Session["Username"].ToString();
            //Validate Password meet the requirement or not
            var checkPassword = BL.CLS_ValidPassword.ValidatePassword(password);
            DataTable dt = Register.CheckUsername(username);
            int checkUsername = Convert.ToInt32(dt.Rows[0][0]);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ErrorMsg.Visible = true;
                lblErrorMessage.Text = "Username and Password is required";
            }
            else if (checkUsername != -1)
            {
                ErrorMsg.Visible = true;
                lblErrorMessage.Text = "Username already taken.";
            }
            else if (checkPassword == false)
            {
                ErrorMsg.Visible = true;
                lblErrorMessage.Text = "1- Password Length should be between 8 & 15. <br />" +
                    "2- Should have one upper case & one Lower case letter. <br />" +
                    "3- Should have one Digit.";
            }

            else
            {
               
                    Register.RegisterUser(username, BL.CLS_ValidPassword.hashPassword(password), createdBy);
                    lblErrorMessage.Text = "";
                    SuccessMsg.Visible = true;
                    lblSuccessMessage.Text = "User created successfully.";
              
            }



        }
    }
}