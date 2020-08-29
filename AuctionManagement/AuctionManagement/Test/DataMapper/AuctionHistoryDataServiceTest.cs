using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Test.DataMapper
{
    using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class AuctionHistoryDataServiceTest
    {

        [Test]
        public void AddAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.AddAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.AddAuctionHistory(auctionHistory);

            mock.Verify(o => o.AddAuctionHistory(auctionHistory), Times.Once());
        }

        [Test]
        public void DeleteAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.DeleteAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.DeleteAuctionHistory(auctionHistory);

            mock.Verify(o => o.DeleteAuctionHistory(auctionHistory), Times.Once());
        }

        [Test]
        public void UpdateAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.UpdateAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.UpdateAuctionHistory(auctionHistory);

            mock.Verify(o => o.UpdateAuctionHistory(auctionHistory), Times.Once());
        }

        [Test]
        public void GetAllAuctionHistorysTest()
        {
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAllAuctionsHistory());

            IAuctionHistoryDataServices obj = mock.Object;
            obj.GetAllAuctionsHistory();

            mock.Verify(o => o.GetAllAuctionsHistory(), Times.Once());
        }

        [Test]
        public void GetAuctionHistoryByIdTest()
        {
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAuctionHistoryById(1));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.GetAuctionHistoryById(1);

            mock.Verify(o => o.GetAuctionHistoryById(1), Times.Once());
        }
    }
}