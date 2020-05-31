using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;


namespace eDahabWebApp.BL
{
    public class CLS_Login
    {
        public DataTable LOGIN(string Username, string Password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 100);
            param[0].Value = Username;

            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 200);
            param[1].Value = Password;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_CheckLogin", param);
            DAL.Close();

            return dt;
        }

        
    }
}