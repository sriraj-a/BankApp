using IDFCBankApplication.Business.LoginBusiness;
using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDFCBankApplication.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("Login/UserLogin/{login}")]
        public JsonResult UserLogin(Login login)
        {
            LoginBusiness loginBusiness = new LoginBusiness();
            var loginCheck=loginBusiness.CheckUser(login);
            if (loginCheck != null && loginCheck.IsValidUser == true)
            {
                Session["UserName"] = loginCheck.UserName;
                Session["Password"] = loginCheck.Password;                
            }
            return Json(loginCheck,JsonRequestBehavior.AllowGet);
        }
    }
}