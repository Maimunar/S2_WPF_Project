﻿using MediaBazaarApplicationWPF.ViewModels;
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

namespace MediaBazaarApplicationWPF.Views
{
    /// <summary>
    /// Interaction logic for PreferencesView.xaml
    /// </summary>
    public partial class PreferencesView : Window
    {
        public PreferencesView()
        {
            InitializeComponent();
            var ViewModel = new PreferencesViewModel();
            DataContext = ViewModel;

            ViewModel.CloseWindowEvent += new PreferencesViewModel.CloseWindowHandler(CloseWindow_Event);
        }

        private void CloseWindow_Event(string message)
        {
            MessageBox.Show(message);
            this.Close();
        }
    }
}
