using IDFCBankApplication.Models;

namespace IDFCBankApplication.Business.LoginBusiness
{
    interface ILoginBusiness
    {
        Login CheckUser(Login login);
    }
}
