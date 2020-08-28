

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;
    class SqlAuctionDataServices : IAuctionDataServices
    {
        public void AddAuction(Auction auction)
        {
            using (Context context = new Context())
            {
                context.Auctions.Add(auction);
                context.SaveChanges();
            }
        }

        public void DeleteAuction(Auction auction)
        {
            using (Context context = new Context())
            {
                Auction toBeDeleted = new Auction { IdAuction = auction.IdAuction };
                context.Auctions.Attach(toBeDeleted);
                context.Auctions.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public Auction GetAuctionById(int id)
        {
            using (Context context = new Context())
            {
                return context.Auctions.Where(auction => auction.IdAuction == id).SingleOrDefault();
            }
        }

        public IList<Auction> GettAllAuctions()
        {
            using (Context context = new Context())
            {
                return context.Auctions.Select(auction => auction).ToList();
            }
        }

        public void UpdateAuction(Auction auction)
        {
            using (Context context = new Context())
            {
                Auction toBeUpdated = context.Auctions.Find(auction.IdAuction);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(auction);
                context.SaveChanges();
            }
        }
    }
}

