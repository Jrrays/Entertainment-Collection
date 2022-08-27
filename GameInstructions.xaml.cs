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
    /// Interaction logic for GameInstructions.xaml
    /// </summary>
    public partial class GameInstructions : Window
    {
        private GameInfoWindow gameInfoWindow;

        public GameInstructions()
        {
            InitializeComponent();
        }

        public GameInstructions(GameInfoWindow gameInfoWindow)
        {
            InitializeComponent();
            this.gameInfoWindow = gameInfoWindow;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
         
                this.Hide();
                GameInfoWindow gameInfoWindow = new(this);
                gameInfoWindow.Show();
        }
    }
}
