using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Online_hardware_store.DataApp
{
    static class WindowsClass
    {
        public static Window mainWindow {get; set;}
        public static Window subcategoriesWindow { get; set;}

        public static void TransitionMainWindow()
        {
            if (Application.Current.MainWindow.Equals(mainWindow))
                return;
            Application.Current.MainWindow.Hide();
            mainWindow.Owner = null;
            Application.Current.MainWindow.Owner = mainWindow;
            mainWindow.Show();
        }
    }
}
