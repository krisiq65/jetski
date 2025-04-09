
namespace JetSkiFleet.Interfaces
{
    public interface IPurchasable
    {
        decimal FullPrice { get; set; }
        decimal MonthlyInstallment { get; set; }
        void Purchase(bool isInstallment);
    }
}
