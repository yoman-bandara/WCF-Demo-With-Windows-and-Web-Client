using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
   public class WorldWideBranchClass
    {
        private string officename;
        private string officecountry;
        private string officeadmin;
        private string officedesc;
        public string Officename
        {
            get { return officename; }
            set { officename = value; }
        }
      
       public string Officecountry
       {
           get { return officecountry; }
           set { officecountry = value; }
       }
      

       public string Officeadmin
       {
           get { return officeadmin; }
           set { officeadmin = value; }
       }
      

       public string Officedesc
       {
           get { return officedesc; }
           set { officedesc = value; }
       }
    }
}
