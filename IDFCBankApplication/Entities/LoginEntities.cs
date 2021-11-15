using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Entities
{
    public class LoginEntities
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsValidUser { get; set; }
    }
}