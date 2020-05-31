using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace eDahabWebApp.BL
{
    public class CLS_UpdateUser
    {
        public DataTable GetUserDatail(string Username)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 100);
            param[0].Value = Username;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_GetUserDetail", param);
            DAL.Close();

            return dt;
        }

        public void UpdateUser(string username, string password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 100);
            param[0].Value = username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 200);
            param[1].Value = password;

            DAL.ExcuteCommand("SP_EditUser", param);
            DAL.Close();
        }
    }
}