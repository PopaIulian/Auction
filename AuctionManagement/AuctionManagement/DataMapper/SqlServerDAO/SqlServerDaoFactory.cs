// <copyright file="SqlServerDaoFactory.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    /// <summary>
    /// Defines the <see cref="SqlServerDaoFactory" />.
    /// </summary>
    public class SqlServerDaoFactory : IDaoFactory
    {
        /// <summary>
        /// Gets the AuctionHistoryDataServices.
        /// </summary>
        public IAuctionHistoryDataServices AuctionHistoryDataServices { get => new SqlAuctionHistoryDataServices(); }

        /// <summary>
        /// Gets the AuctionDataServices.
        /// </summary>
        public IAuctionDataServices AuctionDataServices { get => new SqlAuctionDataServices(); }

        /// <summary>
        /// Gets the CategoryDataServices.
        /// </summary>
        public ICategoryDataServices CategoryDataServices { get => new SqlCategoryDataServices(); }

        /// <summary>
        /// Gets the ConfigDataServices.
        /// </summary>
        public IConfigDataServices ConfigDataServices { get => new SqlConfigDataServices(); }

        /// <summary>
        /// Gets the ObjectDataServices.
        /// </summary>
        public IProductDataServices ProductDataServices { get => new SqlProductDataServices(); }

        /// <summary>
        /// Gets the PersonDataServices.
        /// </summary>
        public IPersonDataServices PersonDataServices { get => new SqlPersonDataServices(); }

        public IScoreHistoryDataServices ScoreHistoryServices { get => new SqlScoreHistoryServices(); }
    }
}
