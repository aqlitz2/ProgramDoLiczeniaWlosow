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
            try
            {
                _glowa.Gestosc = double.Parse(PoleGestosc.Text);
                _glowa.ObwodGlowy = double.Parse(PoleObwodGlowy.Text);
                _glowa.WysokoscCzola = double.Parse(PoleWysokoscCzola.Text);
                double procentowaRoznica = _glowa.ObliczProcentowaRoznica();

                double liczbaWlosow = _glowa.ObliczLiczbeWlosow();
                TekstWynik.Text = $"Szacowana liczba włosów: {liczbaWlosow:F0}";
                TekstProcentowaRoznica.Text = $"Różnica w porównaniu do średniej: {procentowaRoznica:F2}%";
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd danych wejściowych: " + ex.Message);
            }
        }
            private void PrzyciskResetuj_Click(object sender, RoutedEventArgs e)
            {
            PoleGestosc.Text = string.Empty;
            PoleObwodGlowy.Text = string.Empty;
            PoleWysokoscCzola.Text = string.Empty;
            TekstWynik.Text = string.Empty;
            TekstProcentowaRoznica.Text = string.Empty;
        }
        }
    }

