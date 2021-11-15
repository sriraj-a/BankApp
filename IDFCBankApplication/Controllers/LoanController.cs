using IDFCBankApplication.Business.LoanBusiness;
using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDFCBankApplication.Controllers
{
    public class LoanController : Controller
    {
        
        public JsonResult ApplyLoan(Loan loan)
        {
            if (Session["UserName"] != null && Session["Password"] != null)
            {
                List<Loan> loanList = new List<Loan>();
                if (loan != null)
                {
                    LoanBusiness loanBusiness = new LoanBusiness();
                    loanList = loanBusiness.ApplyLoan(loan);
                }
                return Json(loanList, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Login", JsonRequestBehavior.AllowGet);
            }
        }
    }
}