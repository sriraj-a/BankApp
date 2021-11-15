using IDFCBankApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.DataAccess.LoginData
{
    public class LoginDataAccess:ILoginDataAccess
    {
        SqlConnection connection;
        SqlCommand cmd;
        public LoginEntities CheckUser(LoginEntities login)
        {            
            if(!string.IsNullOrEmpty(login.UserName)&& !string.IsNullOrEmpty(login.UserName))
            {
                connection = new SqlConnection(@"Data Source=LT091983\NEWSQL2019;Initial Catalog=IDFC;Integrated Security=true;");
                cmd = new SqlCommand("SELECT * FROM USERREGISTRATION  WHERE USERNAME = @Username ", connection);
                cmd.Parameters.AddWithValue("Username", login.UserName);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (cmd != null)
                {
                    login.IsValidUser = true;
                }
                connection.Close();
            }
            return login;
        }
    }
}