// <copyright file="IAuctionDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IAuctionDataServices" />.
    /// </summary>
    public interface IAuctionDataServices
    {
        /// <summary>
        /// The AddAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        void AddAuction(Auction auction);

        /// <summary>
        /// The GetAuctionById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Auction"/>.</returns>
        Auction GetAuctionById(int id);

        /// <summary>
        /// The GetAllAuctions.
        /// </summary>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        IList<Auction> GetAllAuctions();

        /// <summary>
        /// The UpdateAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        void UpdateAuction(Auction auction);

        /// <summary>
        /// The DeleteAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        void DeleteAuction(Auction auction);

        /// <summary>
        /// The GetAllOpenAuction.
        /// </summary>
        /// <param name="userId">The userId<see cref="int"/>.</param>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        IList<Auction> GetAllOpenAuction(int userId);
    }
}
