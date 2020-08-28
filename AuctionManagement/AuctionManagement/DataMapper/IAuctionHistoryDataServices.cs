using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;
    public interface IAuctionHistoryDataServices
    {
        void AddAuctionHistory(AuctionHistory auctionHistory);

        AuctionHistory GetAuctionHistoryById(int id);

        IList<AuctionHistory> GettAllAuctionsHistory();

        void UpdateAuctionHistory(AuctionHistory auctionHistory);

        void DeleteAuctionHistory(AuctionHistory auctionHistory);
    }
}
