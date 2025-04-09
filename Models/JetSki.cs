
using System;

namespace JetSkiFleet.Models
{
    public abstract class JetSki
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public abstract double Speed { get; set; }
        public abstract double FuelLevel { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Model} ({Year}) - Speed: {Speed} km/h, Fuel: {FuelLevel}%");
        }

        public abstract void StartEngine();
        public abstract void PerformAction();
    }
}
