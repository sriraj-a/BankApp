using IDFCBankApplication.DataAccess.LoanData;
using IDFCBankApplication.Entities;
using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Business.LoanBusiness
{
    public class LoanBusiness:ILoanBusiness
    {
        public List<Loan> ApplyLoan(Loan loan)
        {
            List<Loan> loanList = new List<Loan>();
            if (!string.IsNullOrEmpty(loan.LoanType))
            {
                LoanEntities loanEntities = new LoanEntities();
                loanEntities.LoanType = loan.LoanType;
                loanEntities.RateOfInterest = loan.RateOfInterest;
                loanEntities.Amount = loan.Amount;
                loanEntities.AppliedDate = loan.AppliedDate;
                loanEntities.DurationInDays = loan.DurationInDays;
                LoanDataAccess loanDataAccess = new LoanDataAccess();
                var loanEnitiesList = loanDataAccess.ApplyLoan(loanEntities);                
                if(loanEnitiesList != null && loanEnitiesList.Count > 0)
                {
                    Loan loanObj = new Loan();
                    foreach (var result in loanEnitiesList)
                    {
                        loanObj.Amount = result.Amount;
                        loanObj.AppliedDate = result.AppliedDate;
                        loanObj.DurationInDays = result.DurationInDays;
                        loanObj.LoanType = result.LoanType;
                        loanObj.RateOfInterest = result.RateOfInterest;
                        loanObj.UserName = result.UserName;
                        loanList.Add(loanObj);
                    }
                }                
            }
            return loanList;
        }
    }
}