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

namespace OriginxWindowsClient.worldwidebranch
{
    /// <summary>
    /// Interaction logic for WorldWidOfficeManager.xaml
    /// </summary>
    public partial class WorldWidOfficeManager : Window
    {
        public WorldWidOfficeManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorldWideBranchService.WorlWideBranchServiceClient client = new WorldWideBranchService.WorlWideBranchServiceClient();
            WorldWideBranchService.WorldWideBranchClass wwb = new WorldWideBranchService.WorldWideBranchClass();
            wwb.Officename = officename.Text;
            wwb.Officecountry = officecountry.Text;
            wwb.Officeadmin = officeadmin.Text;
            wwb.Officedesc = officedesc.Text;
            client.AddWorldWideBranch(wwb);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }
    }
}
