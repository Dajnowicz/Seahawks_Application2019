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

namespace SeahawksApp
{
    /// <summary>
    /// Logika interakcji dla klasy Players.xaml
    /// </summary>
    public partial class Players : UserControl
    {
        public Players()
        {
            InitializeComponent();
            DataContext = new DefPlayers();

        }

        private void DefPlayersClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Players();
            

        }

    }
}
