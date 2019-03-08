using System;

namespace _08_03_Classes
{
    class Auto
    {
        public string meno;
        public double spotreba;
        double palivoVNadrzi;
        double prejdeneKm;

        public Auto(string meno, double spotreba, double palivoVNadrzi)
        {
            this.meno = meno;
            this.spotreba = spotreba;
            this.palivoVNadrzi = palivoVNadrzi;
            prejdeneKm = 0;
        }

        public void DlzkaCesty(double numberOfKm)
        {
            SpotrebaPaliva(numberOfKm);
            prejdeneKm = prejdeneKm + numberOfKm;
        }

        private void SpotrebaPaliva(double numberOfKm)
        {
            //vypocet spotreby paliva
            double consumedFuel = (numberOfKm / 100) * spotreba;
            // ubratie paliva z nadrze
            palivoVNadrzi = palivoVNadrzi - consumedFuel;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Auto: {meno}. Km travelled: {prejdeneKm}. State of fuel: {palivoVNadrzi}.");
        }
    }
}