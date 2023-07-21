using Online_hardware_store.DataApp;
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
    /// Логика взаимодействия для PageTopPanel.xaml
    /// </summary>
    public partial class PageTopPanel : Page
    {
        public PageTopPanel()
        {
            InitializeComponent();
        }

        private void ComboBoxForCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonMainPage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowsClass.TransitionMainWindow();
        }
    }
}
