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
        private int phoneno1;
        private int phoneno2;
        private string clientlogo;
        private string additionalinfo;

      
        

        public string Additionalinfo
        {
            get { return additionalinfo; }
            set { additionalinfo = value; }
        }

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


        public string Clientlogo
        {
            get { return clientlogo; }
            set { clientlogo = value; }
        }


    }
}
