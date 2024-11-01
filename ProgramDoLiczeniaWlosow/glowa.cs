namespace HairCalculator 
{
    public class Glowa
    {
        private const double DomyslnaGestosc = 100;
        private const double DomyslnyObwod = 55;
        private const double DomyslnaWysokoscCzola = 15;

        public double Gestosc { get; set; }
        public double ObwodGlowy { get; set; }
        public double WysokoscCzola { get; set; }

        public Glowa()
        {
            Gestosc = DomyslnaGestosc;
            ObwodGlowy = DomyslnyObwod;
            WysokoscCzola = DomyslnaWysokoscCzola;
        }

        public double ObliczLiczbeWlosow()
        {
            double powierzchniaGlowy = ObliczPowierzchnieGlowy();
            return powierzchniaGlowy * Gestosc;
        }

        private double ObliczPowierzchnieGlowy()
        {
            return ObwodGlowy * WysokoscCzola;
        }
    }
}