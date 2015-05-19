using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
   public class LocalBranchClass
    {
        private string countrybranchcod;

        public string Countrybranchcod
        {
            get { return countrybranchcod; }
            set { countrybranchcod = value; }
        }
        private string branchcity;

        public string Branchcity
        {
            get { return branchcity; }
            set { branchcity = value; }
        }
        private string branchadmin;

        public string Branchadmin
        {
            get { return branchadmin; }
            set { branchadmin = value; }
        }
        private string branchdesc;

        public string Branchdesc
        {
            get { return branchdesc; }
            set { branchdesc = value; }
        }
    }
}
