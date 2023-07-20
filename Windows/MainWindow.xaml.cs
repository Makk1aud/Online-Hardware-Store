using Online_hardware_store.Pages.GeneralPages;
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
using MySql.Data.MySqlClient;
using Online_hardware_store.DataApp;
using Online_hardware_store.Pages.MainScreenPages;


namespace Online_hardware_store
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowClass.mainWindow= this;
            frameTopPanel.Navigate(new PageTopPanel());
            frameLeftPanel.Navigate(new PageLeftPanel());
            frameCompaniesPanel.Navigate(new PageListManufacturies());
            frameNewsPanel.Navigate(new PageNewsPanel());
            
        }
    }
}
