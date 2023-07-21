using Online_hardware_store.DataApp;
using Online_hardware_store.Windows;
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

namespace Online_hardware_store.Pages.GeneralPages
{
    /// <summary>
    /// Логика взаимодействия для PageLeftPanel.xaml
    /// </summary>
    public partial class PageLeftPanel : Page
    {
        public PageLeftPanel()
        {
            InitializeComponent();
            ListBoxCompanyTabs.ItemsSource = DBInteractClass.DbPullTable("select * from main_categories").CreateDataReader();
            ListBoxCompanyTabs.DisplayMemberPath = "main_cat_name";
            ListBoxCompanyTabs.SelectedValuePath = "id";
            
        }

        private void ListBoxCompanyTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newWindow = new SubcategoriesWindow((int)ListBoxCompanyTabs.SelectedValue);
            newWindow.Show();
            WindowsClass.mainWindow.Owner = newWindow;
            WindowsClass.mainWindow.Hide();
        }
    }
}
