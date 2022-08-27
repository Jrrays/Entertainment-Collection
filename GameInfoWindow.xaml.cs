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
    /// Interaction logic for GameInfoWindow.xaml
    /// </summary>
    public partial class GameInfoWindow : Window
    {
        private GameInstructions GameInstructions;

        public GameInfoWindow()
        {
            InitializeComponent();
        }

        public GameInfoWindow(GameInstructions gameInstructions)
        {
            InitializeComponent();
            this.GameInstructions = gameInstructions;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void howToPlay_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GameInstructions.Show();
        }
    }
}
