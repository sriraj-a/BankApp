using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFCBankApplication.Business.RegistrationBusiness
{
    interface IRegistrationBusiness
    {
        Registration CreateUser(Registration registration);
        Registration UpdateUser(Registration registration);
    }
}
