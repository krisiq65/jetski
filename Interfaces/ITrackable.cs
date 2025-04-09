
namespace JetSkiFleet.Interfaces
{
    public interface ITrackable
    {
        string CurrentLocation { get; set; }
        string GetLocation();
    }
}
