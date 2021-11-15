using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Entities
{
    public class LoanEntities
    {
        public string LoanType { get; set; }
        public int Amount { get; set; }
        public DateTime AppliedDate { get; set; }
        public int RateOfInterest { get; set; }
        public int DurationInDays { get; set; }
        public string UserName { get; set; }
    }
}