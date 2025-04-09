
using System;
using JetSkiFleet.Interfaces;

namespace JetSkiFleet.Models
{
    public class SportJetSki : JetSki, IDriveable, ITrackable
    {
        public override double Speed { get; set; }
        public override double FuelLevel { get; set; }

        public double MaxSpeed { get; set; }
        public string CurrentLocation { get; set; }

        public SportJetSki(string model, int year)
        {
            Model = model;
            Year = year;
            Speed = 80;
            FuelLevel = 100;
            MaxSpeed = 120;
            CurrentLocation = "Marina Bay";
        }

        public override void StartEngine() => Console.WriteLine($"{Model} engine started!");
        public override void PerformAction() => Drive();
        public void Drive() => Console.WriteLine($"{Model} is speeding up to {MaxSpeed} km/h!");
        public string GetLocation() => CurrentLocation;
    }
}
