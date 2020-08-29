using AuctionManagement.DataMapper;
using AuctionManagement.DomainModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTests.DataMapper
{
    class AuctionDataServiceTest
    {

        [Test]
        public void AddAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.AddAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.AddAuction(auction);

            mock.Verify(o => o.AddAuction(auction), Times.Once());
        }

        [Test]
        public void DeleteAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.DeleteAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.DeleteAuction(auction);

            mock.Verify(o => o.DeleteAuction(auction), Times.Once());
        }

        [Test]
        public void UpdateAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.UpdateAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.UpdateAuction(auction);

            mock.Verify(o => o.UpdateAuction(auction), Times.Once());
        }

        [Test]
        public void GetAllAuctionsTest()
        {
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAllAuctions());

            IAuctionDataServices obj = mock.Object;
            obj.GetAllAuctions();

            mock.Verify(o => o.GetAllAuctions(), Times.Once());
        }

        [Test]
        public void GetAuctionByIdTest()
        {
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAuctionById(1));

            IAuctionDataServices obj = mock.Object;
            obj.GetAuctionById(1);

            mock.Verify(o => o.GetAuctionById(1), Times.Once());
        }
    }
}
