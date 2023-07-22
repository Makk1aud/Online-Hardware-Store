using MySql.Data.MySqlClient;
using Online_hardware_store.DataApp;
using Online_hardware_store.Windows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            FillingWrapPanel(mainCategoryId);
            //ListBoxSubcategories.ItemsSource = DBInteractClass.DbPullTable($"select * from subcategories where maincat_id = {mainCategoryId}").CreateDataReader();
            //DBInteractClass.FillingElement(ListBoxSubcategories, "subcat_name", "id");
        }

        public void FillingWrapPanel(int mainCategoryId)
        {
            var reader = DBInteractClass.DbPullReader($"Select subcat_name from subcategories where maincat_id = {mainCategoryId}");
            while(reader.Read())
            {
                var button = new Button
                {
                    Content = reader["subcat_name"],
                    Margin = new Thickness(10.0)
                };
                button.Click += Button_Click;
                WrapPanelSubcategories.Children.Add(button);
            }
            DBInteractClass.CloseConnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Work");
        }

        private void ListBoxSubcategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newWindow = new ListOfGoodsWindow();
            newWindow.Show();
            WindowsClass.subcategoriesWindow.Owner = newWindow;
            WindowsClass.subcategoriesWindow.Hide();
        }  
    }
}
