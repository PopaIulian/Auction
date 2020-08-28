using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IAuctionDataServices
    {
        void AddAuction(Auction auction);

        Auction GetAuctionById(int id);

        IList<Auction> GettAllAuctions();

        void UpdateAuction(Auction auction);

        void DeleteAuction(Auction auction);
    }
}
