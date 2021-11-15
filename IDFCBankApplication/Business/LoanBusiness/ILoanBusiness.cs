using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFCBankApplication.Business.LoanBusiness
{
    interface ILoanBusiness
    {
        List<Loan> ApplyLoan(Loan loan);
    }
}
