
using System;
using JetSkiFleet.Interfaces;

namespace JetSkiFleet.Models
{
    public class UtilityJetSki : JetSki, IDriveable, IServiceable
    {
        public override double Speed { get; set; }
        public override double FuelLevel { get; set; }

        public double MaxSpeed { get; set; }
        public DateTime LastServiceDate { get; set; }

        public UtilityJetSki(string model, int year)
        {
            Model = model;
            Year = year;
            Speed = 60;
            FuelLevel = 85;
            MaxSpeed = 90;
            LastServiceDate = DateTime.Now.AddMonths(-1);
        }

        public override void StartEngine() => Console.WriteLine($"{Model} (utility) engine roars to life.");
        public override void PerformAction()
        {
            Drive();
            Service();
        }

        public void Drive() => Console.WriteLine($"{Model} (utility) driving at {MaxSpeed} km/h...");
        public void Service() => Console.WriteLine($"{Model} was serviced on {LastServiceDate.ToShortDateString()}");
    }
}
