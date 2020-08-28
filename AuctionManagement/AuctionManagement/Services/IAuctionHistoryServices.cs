// <copyright file="IAuctionHistoryServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IAuctionHistoryServices" />.
    /// </summary>
    public interface IAuctionHistoryServices
    {
        /// <summary>
        /// The AddAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddAuctionHistory(AuctionHistory auctionHistory);

        /// <summary>
        /// The GetAuctionHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        AuctionHistory GetAuctionHistoryById(int id);

        /// <summary>
        /// The GetListOfAuctionHistory.
        /// </summary>
        /// <returns>The <see cref="IList{AuctionHistory}"/>.</returns>
        IList<AuctionHistory> GetListOfAuctionHistory();

        /// <summary>
        /// The UpdateAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateAuctionHistory(AuctionHistory auctionHistory);

        /// <summary>
        /// The DeleteAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteAuctionHistory(AuctionHistory auctionHistory);

        AuctionHistory GetLastAuctionInfo(int auctionId);
    }
}
