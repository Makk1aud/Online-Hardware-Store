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

namespace Online_hardware_store.Pages.SubcategoriesWindowPages
{
    /// <summary>
    /// Логика взаимодействия для SubcategoriesPage.xaml
    /// </summary>
    public partial class SubcategoriesPage : Page
    {
        public SubcategoriesPage(int mainCategoryId)
        {
            InitializeComponent();
            ListBoxSubcategories.ItemsSource = DBInteractClass.DbPullTable($"select * from subcategories where maincat_id = {mainCategoryId}").CreateDataReader();
            DBInteractClass.FillingElement(ListBoxSubcategories, "subcat_name", "id");
        }
    }
}
