// <copyright file="IDaoFactory.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    /// <summary>
    /// Defines the <see cref="IDaoFactory" />.
    /// </summary>
    public interface IDaoFactory
    {
        /// <summary>
        /// Gets the AuctionHistoryDataServices.
        /// </summary>
        IAuctionHistoryDataServices AuctionHistoryDataServices { get; }

        /// <summary>
        /// Gets the AuctionDataServices.
        /// </summary>
        IAuctionDataServices AuctionDataServices { get; }

        /// <summary>
        /// Gets the CategoryDataServices.
        /// </summary>
        ICategoryDataServices CategoryDataServices { get; }

        /// <summary>
        /// Gets the ConfigDataServices.
        /// </summary>
        IConfigDataServices ConfigDataServices { get; }

        /// <summary>
        /// Gets the ProductDataServices.
        /// </summary>
        IProductDataServices ProductDataServices { get; }

        /// <summary>
        /// Gets the PersonDataServices.
        /// </summary>
        IPersonDataServices PersonDataServices { get; }

        /// <summary>
        /// Gets the ScoreHistoryServices.
        /// </summary>
        IScoreHistoryDataServices ScoreHistoryServices { get; }
    }
}
