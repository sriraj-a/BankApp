using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsValidUser { get; set; }
    }
}