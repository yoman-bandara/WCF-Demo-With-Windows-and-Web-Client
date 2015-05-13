using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;

namespace OriginxWebClient
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OriginxWebService.OriginxDataServiceClient client = new OriginxWebService.OriginxDataServiceClient("BasicHttpBinding_IOriginxDataService");
                Label1.Text = client.getMessage(TextBox1.Text);
          
        }
    }
}