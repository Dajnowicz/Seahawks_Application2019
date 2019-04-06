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
    /// Logika interakcji dla klasy OffPlayers.xaml
    /// </summary>
    public partial class OffPlayers : UserControl
    {
        int numberOfClicks = 1;
        public OffPlayers()
        {
            InitializeComponent();
        }
        
        private void Next(object sender, RoutedEventArgs e)
        {
            numberOfClicks++;
            if (numberOfClicks==27)
            {
                numberOfClicks = 1;
            }
            
            changePlayers(numberOfClicks);          
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            numberOfClicks--;
            if (numberOfClicks ==0)
            {
                numberOfClicks = 26;
            }
            
            changePlayers(numberOfClicks);
        }

        private void changePlayers(int numberOfClicks)
        {
            switch (numberOfClicks)
            {
                case 1:
                    name.Text = "Philip Juhlin";
                    pos.Text = "QuarterBack";
                    var uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/2.png", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    numberOfClicks = 0;
                    break;
                case 2:
                    name.Text = "Mateusz Kroc";
                    pos.Text = "Quarterback";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/3.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 3:
                    name.Text = "Adam Gorczynski";
                    pos.Text = "Running Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/7.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 4:
                    name.Text = "Piotr Rudnicki";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/8.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 5:
                    name.Text = "Szymon Syposz";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/10.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 6:
                    name.Text = "Mateusz Miotke";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/16.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 7:
                    name.Text = "Jakub Mazan";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/23.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 8:
                    name.Text = "Jakub Kozlowski";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/34.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 9:
                    name.Text = "Dariusz Peplinski";
                    pos.Text = "Running Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/40.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 10:
                    name.Text = "Milosz Goralski";
                    pos.Text = "Running Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/44.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 11:
                    name.Text = "Pawel Wodkowski";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/46.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 12:
                    name.Text = "Michal Wojewodka";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/61.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 13:
                    name.Text = "Bartosz Klechowicz";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/65.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 14:
                    name.Text = "Jan Stenka";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/68.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 15:
                    name.Text = "Mateusz Piernicki";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/69.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 16:
                    name.Text = "Pawel Glodowski";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/71.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 17:
                    name.Text = "Jakub Krystecki";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/73.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 18:
                    name.Text = "Tomasz Peciak";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/77.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 19:
                    name.Text = "Jan Chojnowski";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/78.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 20:
                    name.Text = "Maciej Suchanowski";
                    pos.Text = "Offensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/79.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 21:
                    name.Text = "Zbyszek Jost";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/81.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 22:
                    name.Text = "Wojciech Szubert";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/84.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 23:
                    name.Text = "Michal Jarocki";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/86.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 24:
                    name.Text = "Filip Pikiel";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/87.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 25:
                    name.Text = "Pawel Fabich";
                    pos.Text = "Tight End";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/89.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 26:
                    name.Text = "Tymoteusz Dubinski";
                    pos.Text = "Wide Reciver";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/OFF/94.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
               

            }
        }

       
    }
}
