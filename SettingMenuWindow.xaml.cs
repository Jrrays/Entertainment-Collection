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

namespace Ohjelmointi4
{
    /// <summary>
    /// Interaction logic for SettingMenuWindow.xaml
    /// </summary>
    public partial class SettingMenuWindow : Window
    {
        private MainWindow mainWindow;

        public SettingMenuWindow()
        {
            InitializeComponent();
        }

        public SettingMenuWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }
    }
}