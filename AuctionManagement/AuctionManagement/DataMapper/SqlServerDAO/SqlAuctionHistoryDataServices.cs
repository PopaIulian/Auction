// <copyright file="SqlAuctionHistoryDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlAuctionHistoryDataServices" />.
    /// </summary>
    internal class SqlAuctionHistoryDataServices : IAuctionHistoryDataServices
    {
        /// <summary>
        /// The AddAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        public void AddAuctionHistory(AuctionHistory auctionHistory)
        {
            using (AppContext context = new AppContext())
            {
                context.AuctionHistories.Add(auctionHistory);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeleteAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        public void DeleteAuctionHistory(AuctionHistory auctionHistory)
        {
            using (AppContext context = new AppContext())
            {
                AuctionHistory toBeDeleted = new AuctionHistory { IdAuctionHistory = auctionHistory.IdAuctionHistory };
                context.AuctionHistories.Attach(toBeDeleted);
                context.AuctionHistories.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetAuctionHistoryById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        public AuctionHistory GetAuctionHistoryById(int id)
        {
            using (AppContext context = new AppContext())
            {
                return context.AuctionHistories.Where(auctionHistory => auctionHistory.IdAuctionHistory == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllAuctionsHistory.
        /// </summary>
        /// <returns>The <see cref="IList{AuctionHistory}"/>.</returns>
        public IList<AuctionHistory> GetAllAuctionsHistory()
        {
            using (AppContext context = new AppContext())
            {
                return context.AuctionHistories.Select(auctionHistory => auctionHistory).ToList();
            }
        }

        /// <summary>
        /// The UpdateAuctionHistory.
        /// </summary>
        /// <param name="auctionHistory">The auctionHistory<see cref="AuctionHistory"/>.</param>
        public void UpdateAuctionHistory(AuctionHistory auctionHistory)
        {
            using (AppContext context = new AppContext())
            {
                AuctionHistory toBeUpdated = context.AuctionHistories.Find(auctionHistory.IdAuctionHistory);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(auctionHistory);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// The GetLastAuctionInfo.
        /// </summary>
        /// <param name="auctionId">The auctionId<see cref="int"/>.</param>
        /// <returns>The <see cref="AuctionHistory"/>.</returns>
        public AuctionHistory GetLastAuctionInfo(int auctionId)
        {
            using (AppContext context = new AppContext())
            {
                var auctionList = context.AuctionHistories.Select(auctionHistory => auctionHistory).ToList();
                AuctionHistory lastAuction = auctionList[0];
                foreach (var auctionHistory in auctionList)
                {
                    if (auctionHistory.AuctionId == auctionId && lastAuction.AuctionDate > auctionHistory.AuctionDate)
                    {
                        lastAuction = auctionHistory;
                    }
                }
                return lastAuction;
              
                /*var res2= context.AuctionHistories.Where(auctionHistory => auctionHistory.AuctionId == auctionId);
                return res.Last();*/
            }
        }
    }
}
