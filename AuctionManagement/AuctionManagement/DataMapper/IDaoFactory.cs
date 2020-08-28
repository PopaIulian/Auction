
namespace AuctionManagement.DataMapper
{
    public interface IDaoFactory
    {
        IAuctionHistoryDataServices AuctionHistoryDataServices { get; }

        IAuctionDataServices AuctionDataServices { get; }

        ICategoryDataServices CategoryDataServices { get; }

        IConfigDataServices ConfigDataServices { get; }

        IProductDataServices ObjectDataServices { get; }

        IPersonDataServices PersonDataServices { get; }
    }
}
