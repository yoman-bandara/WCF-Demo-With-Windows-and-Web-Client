﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrginxDataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OriginxDataService" in both code and config file together.
    public class OriginxDataService : IOriginxDataService,IEmployeeService,ICustomerService
    {

       
        // This getMessage is just for testing if any bug comeup with WCF
        public string getMessage(string name)
        {
            return "Hello " + name;
        }

        // Add New Employee With Stored Proceedure and Linq (OriginxLinq.dbml) 
        public void addEmployee(EmployeeClass emp)
        {
            
            try
            {
                var AddEmployee = new OriginXLinqDataContext();
                AddEmployee.addemployees(emp.Username, emp.Password, emp.User_level);
            }
            catch (Exception ex)
            {
              
            }

            
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlCommand cmd = new SqlCommand("addemployees", con);
            //    cmd.CommandType = CommandType.StoredProcedure;


            //    SqlParameter parameterUserName = new SqlParameter()
            //    {
            //        ParameterName = "@username",
            //        Value = emp.Username
            //    };
            //    cmd.Parameters.Add(parameterUserName);



            //    SqlParameter parameterPassword = new SqlParameter()
            //    {
            //        ParameterName = "@password",
            //        Value = emp.Password
            //    };
            //    cmd.Parameters.Add(parameterPassword);


            //    SqlParameter parameterUserLevel = new SqlParameter()
            //    {
            //        ParameterName = "@user_level",
            //        Value = emp.User_level
            //    };
            //    cmd.Parameters.Add(parameterUserLevel);

            //    con.Open();
            //    cmd.ExecuteNonQuery();

            //}
        }

        // Add new Customer with stored proceedure and linq 
        public void AddCustomer(CustomerClass Customer)
        {
            try
            {
                var AddCustomer = new OriginXLinqDataContext();
                AddCustomer.addCustomer(
                    Customer.Name,
                    Customer.Address,
                    Customer.Type,
                    Customer.Phoneno1,
                    Customer.Phoneno2,
                    Customer.Clientlogo,
                    Customer.Additionalinfo
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Read();
            }

        }


        public void DeleteCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }

        public void SearchCustomer(CustomerClass Customer)
        {
            throw new NotImplementedException();
        }


    }
}
