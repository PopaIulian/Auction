
namespace AuctionManagement.DataMapper.SqlServerDAO
{
    public class SqlServerDaoFactory : IDaoFactory
    {
        public IAuctionHistoryDataServices AuctionHistoryDataServices { get => new SqlAuctionHistoryDataServices(); }

        public IAuctionDataServices AuctionDataServices { get => new SqlAuctionDataServices(); }

        public ICategoryDataServices CategoryDataServices { get => new SqlCategoryDataServices(); }

        public IConfigDataServices ConfigDataServices { get => new SqlConfigDataServices(); }

        public IProductDataServices ObjectDataServices { get => new SqlProductDataServices(); }

        public IPersonDataServices PersonDataServices { get => new SqlPersonDataServices(); }
    }
}
