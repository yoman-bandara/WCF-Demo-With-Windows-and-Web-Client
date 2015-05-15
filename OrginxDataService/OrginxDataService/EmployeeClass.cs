using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
    public class EmployeeClass
    {
       private int emp_ID;
       private string username;
       private string password;
       private int user_level;
        public int Emp_ID
        {
            get { return emp_ID; }
            set { emp_ID = value; }
        }
        

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public int User_level
        {
            get { return user_level; }
            set { user_level = value; }
        }


    }
}
