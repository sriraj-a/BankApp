using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDFCBankApplication.Business.RegistrationBusiness;
using IDFCBankApplication.Models;

namespace IDFCBankApplication.Controllers
{
    public class RegistrationController : Controller
    {

        public JsonResult UserRegistration(Registration registration)
        {
            if (Session["UserName"] != null && Session["Password"] != null)
            {
                Registration registrationObj = new Registration();
                if (registration != null)
                {
                    RegistrationBusiness registrationBusiness = new RegistrationBusiness();
                    var newRegistration = registrationBusiness.CreateUser(registration);
                    return Json(newRegistration, JsonRequestBehavior.AllowGet);
                }
                return Json(registrationObj, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Login", JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult UpdateUserDetails(Registration registration)
        {
            if (Session["UserName"] != null && Session["Password"] != null)
            {
                Registration updateRegistration = new Registration();
                if (registration != null)
                {
                    RegistrationBusiness registrationBusiness = new RegistrationBusiness();
                    var registrationUpdate = registrationBusiness.UpdateUser(registration);
                    return Json(registrationUpdate, JsonRequestBehavior.AllowGet);
                }
                return Json(updateRegistration, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Login", JsonRequestBehavior.AllowGet);
            }
        }
    }
}