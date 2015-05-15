using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrginxDataService
{
    public class CustomerClass
    {
        private string name;
        private string address;
        private string type;

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
        

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
