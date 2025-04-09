using System;
using System.Collections.Generic;
using JetSkiFleet.Models;
using JetSkiFleet.Interfaces;

namespace JetSkiFleet
{
    class Program
    {
        static void Main(string[] args)
        {
            SportJetSki sport = new SportJetSki("Yamaha VXR", 2022);
            UtilityJetSki utility = new UtilityJetSki("Kawasaki Ultra LX", 2021);
            LuxuryJetSki luxury = new LuxuryJetSki("SeaDoo GTX", 2023);

            List<JetSki> allJetSkis = new List<JetSki> { sport, utility, luxury };
            Console.WriteLine("=== All Jet Skis Info ===");
            foreach (var jet in allJetSkis)
            {
                jet.DisplayInfo();
                jet.StartEngine();
                jet.PerformAction();
                Console.WriteLine();
            }

            List<IDriveable> driveables = new List<IDriveable> { sport, utility, luxury };
            Console.WriteLine("=== Driveable Jet Skis ===");
            foreach (var d in driveables)
            {
                d.Drive();
                Console.WriteLine($"Max Speed: {d.MaxSpeed} km/h\n");
            }

            List<IPurchasable> purchasables = new List<IPurchasable> { luxury };
            Console.WriteLine("=== Purchase Options ===");
            foreach (var p in purchasables)
            {
                p.Purchase(true);
                p.Purchase(false);
                Console.WriteLine();
            }

            List<IServiceable> serviceables = new List<IServiceable> { utility };
            Console.WriteLine("=== Service Check ===");
            foreach (var s in serviceables)
            {
                s.Service();
                Console.WriteLine($"Last service: {s.LastServiceDate.ToShortDateString()}\n");
            }

            List<ITrackable> trackables = new List<ITrackable> { sport, luxury };
            Console.WriteLine("=== Location Info ===");
            foreach (var t in trackables)
            {
                Console.WriteLine($"JetSki at: {t.GetLocation()}");
            }
        }
    }
}
