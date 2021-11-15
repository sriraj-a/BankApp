using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IDFCBankApplication.DataAccess.LoginData;
using IDFCBankApplication.Entities;
using IDFCBankApplication.Models;

namespace IDFCBankApplication.Business.LoginBusiness
{
    public class LoginBusiness:ILoginBusiness
    {
        public Login CheckUser(Login login)
        {            
            LoginEntities loginDataAccess = new LoginEntities();
            loginDataAccess.UserName = login.UserName;
            loginDataAccess.Password = login.Password;
            loginDataAccess.IsValidUser = login.IsValidUser;
            LoginDataAccess loginData = new LoginDataAccess();
            var loginCheck=loginData.CheckUser(loginDataAccess);
            if (loginCheck.IsValidUser == true)
            {
                login.UserName = loginCheck.UserName;
                login.Password = loginCheck.Password;
                login.IsValidUser = loginCheck.IsValidUser;
            }
            else
            {
                login = null;
            }
            return login;
        }
    }
}