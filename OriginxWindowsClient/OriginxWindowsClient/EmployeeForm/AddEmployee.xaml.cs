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

namespace OriginxWindowsClient.EmployeeForm
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                       EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeClass emp = new EmployeeService.EmployeeClass();

            emp.Username = txtUsername.Text ;
            emp.Password= txtPassword.Text ;
           emp.User_level = Convert.ToInt32( cmbUserLevel.Text);
            
            client.addEmployee(emp);
            MessageBox.Show("Successfull");
        }
    }
}
