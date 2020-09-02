// <copyright file="IAuctionServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IAuctionServices" />.
    /// </summary>
    public interface IAuctionServices
    {
        /// <summary>
        /// The AddAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddAuction(Auction auction);

        /// <summary>
        /// The GetAuctionById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Auction"/>.</returns>
        Auction GetAuctionById(int id);

        /// <summary>
        /// The GetListOfAuctions.
        /// </summary>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        IList<Auction> GetListOfAuctions();

        /// <summary>
        /// The UpdateAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdateAuction(Auction auction);

        /// <summary>
        /// The DeleteAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeleteAuction(Auction auction);
    }
}
