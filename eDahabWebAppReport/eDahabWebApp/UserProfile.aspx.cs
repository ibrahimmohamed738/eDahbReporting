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
        BL.CLS_UpdateUser UserDetail = new BL.CLS_UpdateUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            var username = Session["Username"].ToString();
            DataTable dt = UserDetail.GetUserDatail(username);
            txtUsername.Text = dt.Rows[0][0].ToString();
            //txtPassword.Text = dt.Rows[0][1].ToString();
            txtPassword.Attributes.Add("Value", dt.Rows[0][1].ToString());

            ErrorMsg.Visible = false;
            SuccessMsg.Visible = false;


        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var checkPassword = BL.CLS_ValidPassword.ValidatePassword(password);

            if (string.IsNullOrEmpty(password))
            {
                ErrorMsg.Visible = true;
                lblErrorMessage.Text = "Password is required";
            }
            else if (checkPassword == false)
            {
                ErrorMsg.Visible = true;
                lblErrorMessage.Text = "1- Password Length should be between 8 & 15. <br />" +
                    "2- Should have one upper case & one Lower case letter. <br />" +
                    "3- Should have one Digit.";
            }
            else { 
                UserDetail.UpdateUser(username, BL.CLS_ValidPassword.hashPassword(password));
                SuccessMsg.Visible = true;
                lblSuccessMessage.Text = "User Info Updated Successfully.";
                lblErrorMessage.Text = "";
            }
        }
    }
}