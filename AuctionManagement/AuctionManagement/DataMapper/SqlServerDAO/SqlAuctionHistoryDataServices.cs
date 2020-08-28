

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;
    class SqlAuctionHistoryDataServices : IAuctionHistoryDataServices
    {
        public void AddAuctionHistory(AuctionHistory auctionHistory)
        {
            using (Context context = new Context())
            {
                context.AuctionsHistory.Add(auctionHistory);
                context.SaveChanges();
            }
        }

        public void DeleteAuctionHistory(AuctionHistory auctionHistory)
        {
            using (Context context = new Context())
            {
                AuctionHistory toBeDeleted = new AuctionHistory { IdAuctionHistory = auctionHistory.IdAuctionHistory };
                context.AuctionsHistory.Attach(toBeDeleted);
                context.AuctionsHistory.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public AuctionHistory GetAuctionHistoryById(int id)
        {
            using (Context context = new Context())
            {
                return context.AuctionsHistory.Where(auctionHistory => auctionHistory.IdAuctionHistory == id).SingleOrDefault();
            }
        }

        public IList<AuctionHistory> GettAllAuctionsHistory()
        {
            using (Context context = new Context())
            {
                return context.AuctionsHistory.Select(auctionHistory => auctionHistory).ToList();
            }
        }

        public void UpdateAuctionHistory(AuctionHistory auctionHistory)
        {
            using (Context context = new Context())
            {
                AuctionHistory toBeUpdated = context.AuctionsHistory.Find(auctionHistory.IdAuctionHistory);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(auctionHistory);
                context.SaveChanges();
            }
        }
    }
}
