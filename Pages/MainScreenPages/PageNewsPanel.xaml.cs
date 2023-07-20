using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Online_hardware_store.Pages.MainScreenPages
{
    /// <summary>
    /// Логика взаимодействия для PageNewsPanel.xaml
    /// </summary>
    public partial class PageNewsPanel : Page
    {
        public PageNewsPanel()
        {
            InitializeComponent();
        }

        private void ImageMouseDown(object sender, MouseButtonEventArgs e)
        {
            var image = sender as Image;
            switch (image.Name)
            {
                case "ImageVK":
                    Process.Start(new ProcessStartInfo("https://vk.com/makklaud89") { UseShellExecute = true });
                    break;
                default:
                    Process.Start(new ProcessStartInfo("https://t.me/Makk1aud") { UseShellExecute = true });
                    break;
            }
        }
    }
}
