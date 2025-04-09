
using System;
using JetSkiFleet.Interfaces;

namespace JetSkiFleet.Models
{
    public class LuxuryJetSki : JetSki, IDriveable, ITrackable, IPurchasable
    {
        public override double Speed { get; set; }
        public override double FuelLevel { get; set; }

        public double MaxSpeed { get; set; }
        public string CurrentLocation { get; set; }

        public decimal FullPrice { get; set; }
        public decimal MonthlyInstallment { get; set; }

        public LuxuryJetSki(string model, int year)
        {
            Model = model;
            Year = year;
            Speed = 70;
            FuelLevel = 90;
            MaxSpeed = 100;
            CurrentLocation = "Blue Lagoon";

            FullPrice = 20000m;
            MonthlyInstallment = 850m;
        }

        public override void StartEngine() => Console.WriteLine($"{Model} (luxury) welcomes you aboard.");
        public override void PerformAction()
        {
            Drive();
            Console.WriteLine($"Current location: {GetLocation()}");
            StartSafari("Crystal Island");
        }

        public void Drive() => Console.WriteLine($"{Model} (luxury) glides over the water at {MaxSpeed} km/h.");
        public string GetLocation() => CurrentLocation;
        public void Purchase(bool isInstallment)
        {
            if (isInstallment)
                Console.WriteLine($"{Model} purchased with monthly payment of {MonthlyInstallment:C}.");
            else
                Console.WriteLine($"{Model} purchased for {FullPrice:C}.");
        }

        public void StartSafari(string destination) => Console.WriteLine($"{Model} is starting safari to {destination}!");
    }
}
