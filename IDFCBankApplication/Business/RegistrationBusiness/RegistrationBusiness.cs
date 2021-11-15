using IDFCBankApplication.DataAccess.RegistrationData;
using IDFCBankApplication.Entities;
using IDFCBankApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.Business.RegistrationBusiness
{
    public class RegistrationBusiness : IRegistrationBusiness
    {
        public Registration CreateUser(Registration registration)
        {
            Registration registrationReturn = new Registration();
            RegistrationEntities registrationEntities = new RegistrationEntities();
            if (!string.IsNullOrEmpty(registration.UserName) &&
                registration.Password.Equals(registration.ConfirmPassword))
            {
                registrationEntities.AccountType = registration.AccountType;
                registrationEntities.Address = registration.Address;
                registrationEntities.Password = registration.Password;
                registrationEntities.ContactNumber = registration.ContactNumber;
                registrationEntities.Country = registration.Country;
                registrationEntities.DOB = registration.DOB;
                registrationEntities.Email = registration.Email;
                registrationEntities.FirstName = registration.FirstName;
                registrationEntities.LastName = registration.LastName;
                registrationEntities.PAN = registration.PAN;
                registrationEntities.State = registration.State;
                registrationEntities.UserName = registration.UserName;
                registrationEntities.UserNameExists = registration.UserNameExists;
                RegistrationDataAccess registrationDataAccess = new RegistrationDataAccess();
                var registrationCheck = registrationDataAccess.CreateUser(registrationEntities);
                if(registrationCheck!=null && !string.IsNullOrEmpty(registrationCheck.UserName))
                {
                    registrationReturn.AccountType = registrationCheck.AccountType;
                    registrationReturn.Address = registrationCheck.Address;
                    registrationReturn.Password = registrationCheck.Password;
                    registrationReturn.ContactNumber = registrationCheck.ContactNumber;
                    registrationReturn.Country = registrationCheck.Country;
                    registrationReturn.DOB = registrationCheck.DOB;
                    registrationReturn.Email = registrationCheck.Email;
                    registrationReturn.FirstName = registrationCheck.FirstName;
                    registrationReturn.LastName = registrationCheck.LastName;
                    registrationReturn.PAN = registrationCheck.PAN;
                    registrationReturn.State = registrationCheck.State;
                    registrationReturn.UserName = registrationCheck.UserName;
                    registrationReturn.UserNameExists = registrationCheck.UserNameExists;
                    return registrationReturn;
                }
            }
            return registrationReturn;
        }

        public Registration UpdateUser(Registration registration)
        {
            Registration registrationReturn = new Registration();
            RegistrationEntities registrationEntities = new RegistrationEntities();
            if (!string.IsNullOrEmpty(registration.UserName) &&
                registration.Password.Equals(registration.ConfirmPassword))
            {
                registrationEntities.AccountType = registration.AccountType;
                registrationEntities.Address = registration.Address;
                registrationEntities.Password = registration.Password;
                registrationEntities.ContactNumber = registration.ContactNumber;
                registrationEntities.Country = registration.Country;
                registrationEntities.DOB = registration.DOB;
                registrationEntities.Email = registration.Email;
                registrationEntities.FirstName = registration.FirstName;
                registrationEntities.LastName = registration.LastName;
                registrationEntities.PAN = registration.PAN;
                registrationEntities.State = registration.State;
                registrationEntities.UserName = registration.UserName;
                registrationEntities.UserNameExists = registration.UserNameExists;
                registrationEntities.IsUserUpdated = registration.IsUserUpdated;
                RegistrationDataAccess registrationDataAccess = new RegistrationDataAccess();
                var UpdateCheck = registrationDataAccess.CreateUser(registrationEntities);
                if (UpdateCheck != null && !string.IsNullOrEmpty(UpdateCheck.UserName))
                {
                    registrationReturn.AccountType = UpdateCheck.AccountType;
                    registrationReturn.Address = UpdateCheck.Address;
                    registrationReturn.Password = UpdateCheck.Password;
                    registrationReturn.ContactNumber = UpdateCheck.ContactNumber;
                    registrationReturn.Country = UpdateCheck.Country;
                    registrationReturn.DOB = UpdateCheck.DOB;
                    registrationReturn.Email = UpdateCheck.Email;
                    registrationReturn.FirstName = UpdateCheck.FirstName;
                    registrationReturn.LastName = UpdateCheck.LastName;
                    registrationReturn.PAN = UpdateCheck.PAN;
                    registrationReturn.State = UpdateCheck.State;
                    registrationReturn.UserName = UpdateCheck.UserName;
                    registrationReturn.UserNameExists = UpdateCheck.UserNameExists;
                    registrationReturn.IsUserUpdated = UpdateCheck.IsUserUpdated;
                    return registrationReturn;
                }
            }
            return registrationReturn;
        }
    }
}