
using System;

namespace JetSkiFleet.Interfaces
{
    public interface IServiceable
    {
        DateTime LastServiceDate { get; set; }
        void Service();
    }
}
