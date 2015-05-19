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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.ServiceModel;

namespace OriginxWindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OriginxWindowsService.OriginxDataServiceClient client = new OriginxWindowsService.OriginxDataServiceClient("NetTcpBinding_IOriginxDataService");
                displayLabel.Content = client.getMessage(displayText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is Error" + ex);
            }
                      
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmailService.EmailServiceClient emailClient = new EmailService.EmailServiceClient();
            try
            {
                bool send = emailClient.SendMail("ruwanranganathz@gmail.com", "WCF Test", "Hi Ruwan </br> Adooh !", true);
                if(send){
                    MessageBox.Show("Email Sent ");
                }else{
                    MessageBox.Show("something wrong Please try again...");
                }
            }catch (FaultException ex){
                MessageBox.Show(ex.Message);
            }finally{
                emailClient.Close();
            }
        }
    }
}
