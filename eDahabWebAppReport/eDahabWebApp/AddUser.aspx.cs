﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                lblErrorMessage.Text = "Username and Password is required";
            else
            { 
                Register.RegisterUser(username, password, createdBy);
                lblErrorMessage.Text = "";
                lblSuccessMessage.Text = "User created successfully.";
            }



        }
    }
}