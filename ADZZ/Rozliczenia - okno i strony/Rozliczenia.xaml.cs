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
            RamkaFormularzaRozliczen.NavigationService.RemoveBackEntry();
        }

        private void BtnWroc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            FormularzDodaniaRozliczenia obj = new FormularzDodaniaRozliczenia();
            RamkaFormularzaRozliczen.Content = obj;
            


        }

        private void RamkaFormularzaRozliczen_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            RamkaFormularzaRozliczen.NavigationService.RemoveBackEntry();
        }
    }
}
