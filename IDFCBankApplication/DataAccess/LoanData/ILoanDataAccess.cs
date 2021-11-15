using IDFCBankApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFCBankApplication.DataAccess.LoanData
{
    interface ILoanDataAccess
    {
        List<LoanEntities> ApplyLoan(LoanEntities loanEntities);
    }
}
