using System;
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
    public class OriginxDataService : IOriginxDataService{
        public string getMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
