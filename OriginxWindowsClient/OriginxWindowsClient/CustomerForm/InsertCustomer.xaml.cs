using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OriginxWindowsClient.CustomerForm
{
    /// <summary>
    /// Interaction logic for InsertCustomer.xaml
    /// </summary>
    public partial class InsertCustomer : Window
    {
        public InsertCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomerService.CustomerServiceClient client = new CustomerService.CustomerServiceClient();
            CustomerService.CustomerClass customer = new CustomerService.CustomerClass();

            customer.Name = txtCusName.Text;
            customer.Address = txtCusAddress.Text;
            customer.Type = txtCusType.Text;

            client.AddCustomer(customer);
        }
    }
}
