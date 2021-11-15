using IDFCBankApplication.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IDFCBankApplication.DataAccess.LoanData
{
    public class LoanDataAccess : ILoanDataAccess
    {
        SqlConnection connection;
        SqlCommand cmd;
        public List<LoanEntities> ApplyLoan(LoanEntities loanEntities)
        {
           // bool isApplied = false;
            List<LoanEntities> listLoanEntities = new List<LoanEntities>();
            if (!string.IsNullOrEmpty(loanEntities.LoanType))
            {
                connection = new SqlConnection(@"Data Source=LT091983\NEWSQL2019;Initial Catalog=IDFC;Integrated Security=true;");
                string query = "INSERT INTO LOANDETAILS(LOANTYPE,AMOUNT,APPLYINGDATE,RATEOFINTEREST,DURATION_IN_DAYS,USERNAME)" +
                    "VALUES(@LOANTYPE,@AMOUNT,@APPLYINGDATE,@RATEOFINTEREST,@DURATION_IN_DAYS,@USERNAME) ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("LOANTYPE", loanEntities.LoanType);
                command.Parameters.AddWithValue("AMOUNT", loanEntities.Amount);
                command.Parameters.AddWithValue("APPLYINGDATE", loanEntities.AppliedDate);
                command.Parameters.AddWithValue("RATEOFINTEREST", loanEntities.RateOfInterest);
                command.Parameters.AddWithValue("DURATION_IN_DAYS", loanEntities.DurationInDays);
                command.Parameters.AddWithValue("USERNAME", loanEntities.UserName);
                connection.Open();
                command.ExecuteNonQuery();
                //isApplied = true;                
            }
            return listLoanEntities;
        }
    }
}