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
using System.Windows.Shapes;

namespace ADZZ.Rozliczenia___okno_i_strony
{
    /// <summary>
    /// Logika interakcji dla klasy WydatkiPrzychody.xaml
    /// </summary>
    public partial class Rozliczenia : Window
    {
        public Rozliczenia()
        {
            InitializeComponent();
        }

        private void BtnWroc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Wyswietlam formularz rozliczen na zawartosci frame'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtDodaj_Click(object sender, RoutedEventArgs e)
        {
            
            FormularzDodaniaRozliczenia obj = new FormularzDodaniaRozliczenia();
            RamkaFormularzaRozliczen.Content = obj;
            


        }
        /// <summary>
        /// Metoda, która czyści "History stack" dzieki czemu strony nie układają sie na stosie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RamkaFormularzaRozliczen_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e) => RamkaFormularzaRozliczen.NavigationService.RemoveBackEntry();
        

        private void BtEdytuj_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void BtZarzadzajCenami_Click(object sender, RoutedEventArgs e)
        {
            ZarzadzanieCenami obj = new ZarzadzanieCenami();
            RamkaFormularzaRozliczen.Content = obj;
        }
    }
}
