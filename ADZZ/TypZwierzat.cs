﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel;

namespace ADZZ
{   /// <summary>
/// Klasa ktora bedzie kontrolowala wybor zwierzat przy wprowadzaniu danych. Zawsze trzeba dokonać wyboru czy chcemy zarządzać pojedynczym zwierzeciem czy stadem
/// </summary>
    class TypZwierzat
    {
        enum Typy
        {          
            Pojedyncze_zwierze = 1, 
            Stado = 2,
        }

        private int wybor;  //Wybor bedzie 0, 1, 2 i w zaleznosci od dokonanego wyboru w comboboxie bedzie wystawietlana odpowiednia strona dla stada lub pojedynczego zwierzecia

        static List<string> ListaTypow = new List<string>();
        /// <summary>
        /// Uzupelnia liste typow o stale typy zwierzat
        /// </summary>
        public static void UzupelnijTypy()
        {
            ListaTypow.Add("Pojedyncze Zwierze");
            ListaTypow.Add("Stado");
        }
        
        /// <summary>
        /// Ustawia zawartosc ComboBoxa
        /// </summary>
        /// <param name="ListaTypow">Kontrolka typu ComboBox</param>
        public static void UstawListeTypow(ComboBox ListaTypowBox)
        {

            ListaTypowBox.ItemsSource = ListaTypow;
            //ListaTypow.ItemsSource = Enum.GetValues(typeof(Typy));
        }
     
    }
}
