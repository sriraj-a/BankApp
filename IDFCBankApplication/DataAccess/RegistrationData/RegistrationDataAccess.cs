using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using IDFCBankApplication.Entities;

namespace IDFCBankApplication.DataAccess.RegistrationData
{
	public class RegistrationDataAccess:IRegistrationDataAccess
	{
        SqlConnection connection;
        SqlCommand cmd;
        //      public RegistrationEntities CreateUser(RegistrationEntities registrationEntities)
        //      {

        //	var checkUserName = from user in db.USERREGISTRATION
        //						where user.UserName == registrationEntities.UserName select user;
        //          registrationEntities.UserNameExists = false;
        //	if(checkUserName==null)
        //          {
        //              string connections = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
        //              using (SqlConnection connect = new SqlConnection(connections))
        //              {                    
        //                  string query = "INSERT INTO USERREGISTRATION(FIRSTNAME,LASTNAME,USERNAME,PASSWORD,ADDRESS,STATE,COUNTRY,EMAIL,PAN,CONTACT,DOB,ACCOUNTTYPE)VALUES(@FIRSTNAME,@LASTNAME,@USERNAME,@PASSWORD,@ADDRESS,@STATE,@COUNTRY,@EMAIL,@PAN,@CONTACT,@DOB,@ACCOUNTTYPE) ";
        //                  SqlCommand command = new SqlCommand(query, connect);
        //                  command.Parameters.AddWithValue("FIRSTNAME", registrationEntities.FirstName);
        //                  command.Parameters.AddWithValue("LASTNAME", registrationEntities.LastName);
        //                  command.Parameters.AddWithValue("USERNAME", registrationEntities.UserName);
        //                  command.Parameters.AddWithValue("PASSWORD", registrationEntities.Password);
        //                  command.Parameters.AddWithValue("ADDRESS", registrationEntities.Address);
        //                  command.Parameters.AddWithValue("STATE", registrationEntities.State);
        //                  command.Parameters.AddWithValue("COUNTRY", registrationEntities.Country);
        //                  command.Parameters.AddWithValue("EMAIL", registrationEntities.Email);
        //                  command.Parameters.AddWithValue("PAN", registrationEntities.PAN);
        //                  command.Parameters.AddWithValue("CONTACT", registrationEntities.ContactNumber);
        //                  command.Parameters.AddWithValue("DOB", registrationEntities.DOB);
        //                  command.Parameters.AddWithValue("ACCOUNTTYPE", registrationEntities.AccountType);
        //                  connect.Open();
        //                  command.ExecuteNonQuery();
        //                  registrationEntities.UserNameExists = true;
        //              }
        //          }
        //          return registrationEntities;
        //}

        public RegistrationEntities CreateUser(RegistrationEntities registrationEntities)
        {
            if(registrationEntities!=null && !string.IsNullOrEmpty(registrationEntities.UserName))
            {
                connection = new SqlConnection(@"Data Source=LT091983\NEWSQL2019;Initial Catalog=IDFC;Integrated Security=true;");
                cmd = new SqlCommand("SELECT * FROM USERREGISTRATION  WHERE USERNAME = @Username ", connection);
                cmd.Parameters.AddWithValue("Username", registrationEntities.UserName);
                connection.Open();
                cmd.ExecuteNonQuery();
                if (cmd == null)
                {
                    string query = "INSERT INTO USERREGISTRATION(FIRSTNAME,LASTNAME,USERNAME,PASSWORD,ADDRESS,STATE,COUNTRY,EMAIL,PAN,CONTACT,DOB,ACCOUNTTYPE)VALUES(@FIRSTNAME,@LASTNAME,@USERNAME,@PASSWORD,@ADDRESS,@STATE,@COUNTRY,@EMAIL,@PAN,@CONTACT,@DOB,@ACCOUNTTYPE) ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("FIRSTNAME", registrationEntities.FirstName);
                    command.Parameters.AddWithValue("LASTNAME", registrationEntities.LastName);
                    command.Parameters.AddWithValue("USERNAME", registrationEntities.UserName);
                    command.Parameters.AddWithValue("PASSWORD", registrationEntities.Password);
                    command.Parameters.AddWithValue("ADDRESS", registrationEntities.Address);
                    command.Parameters.AddWithValue("STATE", registrationEntities.State);
                    command.Parameters.AddWithValue("COUNTRY", registrationEntities.Country);
                    command.Parameters.AddWithValue("EMAIL", registrationEntities.Email);
                    command.Parameters.AddWithValue("PAN", registrationEntities.PAN);
                    command.Parameters.AddWithValue("CONTACT", registrationEntities.ContactNumber);
                    command.Parameters.AddWithValue("DOB", registrationEntities.DOB);
                    command.Parameters.AddWithValue("ACCOUNTTYPE", registrationEntities.AccountType);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    registrationEntities.UserNameExists = true;
                }
                connection.Close();
            }            
            return registrationEntities;
        }

        public RegistrationEntities UpdateUser(RegistrationEntities registrationEntities)
        {
            connection = new SqlConnection(@"Data Source=LT091983\NEWSQL2019;Initial Catalog=IDFC;Integrated Security=true;");
            cmd = new SqlCommand("SELECT * FROM USERREGISTRATION  WHERE USERNAME = @Username ", connection);
            cmd.Parameters.AddWithValue("Username", registrationEntities.UserName);
            connection.Open();
            cmd.ExecuteNonQuery();
            if (cmd != null)
            {
                string query = "UPDATE Student(FIRSTNAME, LASTNAME, ADDRESS, STATE,COUNTRY,EMAIL,PAN) VALUES(@FN, @LN, @ADD, @ST, @CTY, @Email, @PAN)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("FN", registrationEntities.FirstName);
                command.Parameters.AddWithValue("LN", registrationEntities.LastName);
                command.Parameters.AddWithValue("ADD", registrationEntities.Address);
                command.Parameters.AddWithValue("ST", registrationEntities.State);
                command.Parameters.AddWithValue("CTY", registrationEntities.Country);
                command.Parameters.AddWithValue("Email", registrationEntities.Email);
                command.Parameters.AddWithValue("PAN", registrationEntities.PAN);
                connection.Open();
                command.ExecuteNonQuery();
                registrationEntities.UserNameExists = true;
                connection.Close();
            }
            connection.Close();                
            return registrationEntities;
        }
    }
}