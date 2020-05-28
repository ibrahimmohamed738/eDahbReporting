using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace eDahabWebApp.BL
{
    public class CLS_AddUser
    {
        public void RegisterUser(string username, string password, string createdBy)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 100);
            param[0].Value = username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 200);
            param[1].Value = password;

            param[2] = new SqlParameter("@createdBy", SqlDbType.NVarChar, 100);
            param[2].Value = createdBy;

         
            DAL.ExcuteCommand("SP_RegisterUser", param);
            DAL.Close();
        }

        public DataTable CheckUsername(string Username)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 100);
            param[0].Value = Username;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_GetByUsername", param);
            DAL.Close();

            return dt;
        }
    }
}