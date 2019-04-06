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
    /// Logika interakcji dla klasy DefPlayers.xaml
    /// </summary>
    public partial class DefPlayers : UserControl
    {
        int numberOfClicks = 1;
        public DefPlayers()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            numberOfClicks++;
            if (numberOfClicks == 28)
            {
                numberOfClicks = 1;
            }

            changePlayers(numberOfClicks);
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            numberOfClicks--;
            if (numberOfClicks == 0)
            {
                numberOfClicks = 27;
            }

            changePlayers(numberOfClicks);
        }

        private void changePlayers(int numberOfClicks)
        {
            switch (numberOfClicks)
            {
                case 1:
                    name.Text = "Barron Miller";
                    pos.Text = "Linebacker";
                    var uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/1.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    numberOfClicks = 0;
                    break;
                case 2:
                    name.Text = "Hubert Chudy";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/5.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 3:
                    name.Text = "Kacper Rokicinski";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/9.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 4:
                    name.Text = "Maciej Siemaszko";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/11.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 5:
                    name.Text = "Bartosz Sitarz";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/15.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 6:
                    name.Text = "Grzegorz Piotrowski";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/17.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 7:
                    name.Text = "Grzegorz Terlecki";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/18.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 8:
                    name.Text = "Maicej Cwiklinski";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/21.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 9:
                    name.Text = "Dawid Magrean";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/27.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 10:
                    name.Text = "Maciek Halbis";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/29.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 11:
                    name.Text = "Kacper Karwowski";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/32.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 12:
                    name.Text = "Wojciech Przysowa";
                    pos.Text = "Defensive Back";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/36.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 13:
                    name.Text = "Arkadiusz Sobierski";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/37.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 14:
                    name.Text = "Karol Mazajlo";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/39.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 15:
                    name.Text = "Pawel Probierz";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/41.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 16:
                    name.Text = "Rafal Michon";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/42.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 17:
                    name.Text = "Karol Rudzki";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/43.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 18:
                    name.Text = "Marcin Dubicki";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/47.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 19:
                    name.Text = "Marcin Banbura";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/50.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 20:
                    name.Text = "Szymon Wica";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/52.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 21:
                    name.Text = "Kacper Ruczynski";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/53.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 22:
                    name.Text = "Marcin Rynkowski";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/57.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 23:
                    name.Text = "Arkadiusz Cieslok";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/75.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 24:
                    name.Text = "Jaroslaw Wolnik";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/91.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 25:
                    name.Text = "Wojtek Daniszewski";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/93.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 26:
                    name.Text = "Dariusz Ankiewicz";
                    pos.Text = "Defensive Line";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/98.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;
                case 27:
                    name.Text = "Bartosz Domzalski";
                    pos.Text = "Linebacker";
                    uriSource = new Uri(@"/SeahawksApp;component/Files/Players/DEF/99.jpg", UriKind.Relative);
                    image.Source = new BitmapImage(uriSource);
                    break;


            }
        }


    }
}

