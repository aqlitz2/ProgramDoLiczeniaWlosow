using System;
using System.Windows;
using HairCalculator;

namespace HairCalculator
{
    public partial class MainWindow : Window
    {
        private Glowa _glowa;

        public MainWindow()
        {
            InitializeComponent();
            _glowa = new Glowa();
        }

        private void PrzyciskOblicz_Click(object sender, RoutedEventArgs e)
        {

        }
            private void PrzyciskResetuj_Click(object sender, RoutedEventArgs e)
            {

            }
        }
    }

