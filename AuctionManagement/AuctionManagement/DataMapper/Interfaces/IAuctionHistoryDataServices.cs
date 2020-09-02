// <copyright file="IAuctionHistoryDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IAuctionHistoryDataServices" />.
    /// </summary>
    public interface IAuctionHistoryDataServices
    {
        /// <summary>
        /// The AddAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        void AddAuctionHistory(AuctionHistory auctionHistory);

        /// <summary>
        /// The GetAuctionHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        AuctionHistory GetAuctionHistoryById(int id);

        /// <summary>
        /// The GetAllAuctionsHistory.
        /// </summary>
        /// <returns>The <see cref="IList{AuctionHistory}"/>.</returns>
        IList<AuctionHistory> GetAllAuctionsHistory();

        /// <summary>
        /// The UpdateAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        void UpdateAuctionHistory(AuctionHistory auctionHistory);

        /// <summary>
        /// The DeleteAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        void DeleteAuctionHistory(AuctionHistory auctionHistory);

        /// <summary>
        /// The GetLastAuctionInfo.
        /// </summary>
        /// <param name="auctionId">The auctionId<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        AuctionHistory GetLastAuctionInfo(int auctionId);
    }
}
