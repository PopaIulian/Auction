using AuctionManagement.DomainModel;
using AuctionManagement.Services;
using AuctionManagement.Services.ServicesImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuctionHistoryServices service = new AuctionHistoryServices();
            Auction auction = new Auction();
            auction.IdAuction = 4;
            auction.ObjectId = 3;
            auction.Price = 30;
            auction.UserId = 1;
            auction.Currency = "ebfu3";
            auction.StartDate = DateTime.Now;
            auction.EndDate = DateTime.Now;
// service.AddAuction(auction);
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2,
                AuctionId = 1,

                Auctiondate = DateTime.Now,
                Price = 100,
                Currency = "ron"
            };
            service.AddAuctionHistory(test);

       
            Console.Read();
        }
    }
}
