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
       private string name;
       private string address;
       private string Mobile;
       private int Birthday;
       private int position;
       private int BasicSalary;
       private int bonus;
       private int hiredate;
       private string department;
       private string sex;
       private int phoneno1;
       private int phoneno2;



       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       

       public string Address
       {
           get { return address; }
           set { address = value; }
       }
       

       public string Mobile1
       {
           get { return Mobile; }
           set { Mobile = value; }
       }
      

       public int Birthday1
       {
           get { return Birthday; }
           set { Birthday = value; }
       }
      

       public int Position
       {
           get { return position; }
           set { position = value; }
       }
       

       public int BasicSalary1
       {
           get { return BasicSalary; }
           set { BasicSalary = value; }
       }
      

       public int Bonus
       {
           get { return bonus; }
           set { bonus = value; }
       }
      

       public int Hiredate
       {
           get { return hiredate; }
           set { hiredate = value; }
       }
      

       public string Department
       {
           get { return department; }
           set { department = value; }
       }
       private string userimage;

       public string Userimage
       {
           get { return userimage; }
           set { userimage = value; }
       }
       

       public string Sex
       {
           get { return sex; }
           set { sex = value; }
       }
       

       public int Phoneno1
       {
           get { return phoneno1; }
           set { phoneno1 = value; }
       }
      

       public int Phoneno2
       {
           get { return phoneno2; }
           set { phoneno2 = value; }
       }
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
