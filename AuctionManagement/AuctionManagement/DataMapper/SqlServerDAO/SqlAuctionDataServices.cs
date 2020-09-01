// <copyright file="SqlAuctionDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlAuctionDataServices" />.
    /// </summary>
    internal class SqlAuctionDataServices : IAuctionDataServices
    {
        /// <summary>
        /// The AddAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        public void AddAuction(Auction auction)
        {
            using (Model1 context = new Model1())
            {
                context.Auctions.Add(auction);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        public void DeleteAuction(Auction auction)
        {
            using (Model1 context = new Model1())
            {
                Auction toBeDeleted = new Auction { IdAuction = auction.IdAuction };
                context.Auctions.Attach(toBeDeleted);
                context.Auctions.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetAuctionById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Auction"/>.</returns>
        public Auction GetAuctionById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.Auctions.Where(auction => auction.IdAuction == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllAuctions.
        /// </summary>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        public IList<Auction> GetAllAuctions()
        {
            using (Model1 context = new Model1())
            {
                return context.Auctions.Select(auction => auction).ToList();
            }
        }

        /// <summary>
        /// The UpdateAuction.
        /// </summary>
        /// <param name="auction">The auction<see cref="Auction"/>.</param>
        public void UpdateAuction(Auction auction)
        {
            using (Model1 context = new Model1())
            {
                Auction toBeUpdated = context.Auctions.Find(auction.IdAuction);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(auction);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// The GetAllOpenAuction.
        /// </summary>
        /// <param name="userId">The userId<see cref="int"/>.</param>
        /// <returns>The <see cref="IList{Auction}"/>.</returns>
        public IList<Auction> GetAllOpenAuction(int userId)
        {
            using (Model1 context = new Model1())
            {
                return context.Auctions.Where(auction => auction.UserId == userId && auction.EndDate != null && auction.EndDate > DateTime.Now).ToList();
            }
        }
    }
}
