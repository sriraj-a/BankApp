using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Models
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PAN { get; set; }
        public string ContactNumber { get; set; }
        public string DOB { get; set; }
        public string AccountType { get; set; }
        public bool UserNameExists { get; set; }
        public bool IsUserUpdated { get; set; }
    }
}