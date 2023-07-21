using Online_hardware_store.DataApp;
using Online_hardware_store.Pages.GeneralPages;
using Online_hardware_store.Pages.SubcategoriesWindowPages;
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

namespace Online_hardware_store.Windows
{
    /// <summary>
    /// Логика взаимодействия для SubcategoriesWindow.xaml
    /// </summary>
    public partial class SubcategoriesWindow : Window
    {
        public SubcategoriesWindow(int mainCategoryId)
        {
            InitializeComponent();
            WindowsClass.subcategoriesWindow = this;
            Application.Current.MainWindow = this;
            frameTopPanel.Navigate(new PageTopPanel());
            frameSubcategories.Navigate(new SubcategoriesPage(mainCategoryId));
        }
    }
}
