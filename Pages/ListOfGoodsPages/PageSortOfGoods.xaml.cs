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

namespace Online_hardware_store.Pages.ListOfGoodsPages
{
    /// <summary>
    /// Логика взаимодействия для PageSortOfGoods.xaml
    /// </summary>
    public partial class PageSortOfGoods : Page
    {
        public PageSortOfGoods()
        {
            InitializeComponent();
            //запрос с подкатегорией
            DataGridCompanies.ItemsSource = DBInteractClass.DbPullStringData("select * from ")
        }
    }
}
