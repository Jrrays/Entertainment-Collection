﻿using System;
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

namespace Ohjelmointi4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GameMenuWindow gameMenuWindow = new GameMenuWindow(this);
            gameMenuWindow.ShowDialog();
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SettingMenuWindow settingMenuWindow = new(this);
            settingMenuWindow.ShowDialog();
        }

        private void ProfilesButton_Click(object sender, RoutedEventArgs e)
        {
            ProfilesWindow profilesWindow = new(this);
            this.Hide();
            profilesWindow.ShowDialog();

        }
    }
}
