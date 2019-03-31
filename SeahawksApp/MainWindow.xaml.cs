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

namespace SeahawksApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Home();
           // MenuSlider.Height = HomeButton.Height;
            
        }

        private void Home(object sender, RoutedEventArgs e)
        {

        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Home();

        }

        private void History(object sender, RoutedEventArgs e)
        {
            DataContext = new History();
            // MenuSlider.Height = HistoryButton.Height;
        }

        private void PlayersClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Players();

            // MenuSlider.Height = PlayersButton.Height;
        }

        private void PhotoClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Photos();
        }

        private void ResultsClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Results();
        }
    }
}
