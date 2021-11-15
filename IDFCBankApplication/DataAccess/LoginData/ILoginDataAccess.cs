using IDFCBankApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFCBankApplication.DataAccess.LoginData
{
    interface ILoginDataAccess
    {
        LoginEntities CheckUser(LoginEntities login);
    }
}
