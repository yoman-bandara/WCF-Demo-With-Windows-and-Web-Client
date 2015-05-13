using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace OriginxDataHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(OrginxDataService.OriginxDataService)))
            {
                host.Open();
                Console.WriteLine("The Host Started running at" + DateTime.Now.ToString());
                Console.ReadLine();

            }
        }
    }
}
