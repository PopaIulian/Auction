using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Test.ServicesTest
{

    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    class AuctionHistoryServicesTest
    { 
        [Test]
        public void TestAddAuctionHistoryWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.AddAuctionHistory(auctionHistory);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestAddAuctionHistoryWithInvalidData()
        {
            AuctionHistory AuctionHistory = new AuctionHistory();

            IAuctionHistoryServices readerServices = new AuctionHistoryServices();
            bool result = readerServices.AddAuctionHistory(AuctionHistory);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestDeleteAuctionHistoryWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.DeleteAuctionHistory(auctionHistory));

            AuctionHistoryServices.DataServices = mock.Object;
            bool result = auctionHistoryServices.DeleteAuctionHistory(auctionHistory);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestDeleteAuctionHistoryWithInvalidData()
        {
            AuctionHistory AuctionHistory = new AuctionHistory();

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.DeleteAuctionHistory(AuctionHistory);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestUpdateReaderWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.UpdateAuctionHistory(auctionHistory);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestUpdateAuctionHistoryWithInvalidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory();

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.UpdateAuctionHistory(auctionHistory);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestGetListOfAuctionHistorys()
        {
            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAllAuctionsHistory()).Returns(
                new List<AuctionHistory>()
                {
                    new AuctionHistory()
            {
                 IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            }
        });

            AuctionHistoryServices.DataServices = mock.Object;
            var result = auctionHistoryServices.GetListOfAuctionHistory();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<AuctionHistory>).Count, 1);
        }

        [Test]
        public void TestGetAuctionHistoryById()
        {
            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAuctionHistoryById(1)).Returns(

            new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            });

            AuctionHistoryServices.DataServices = mock.Object;
            var result = auctionHistoryServices.GetAuctionHistoryById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as AuctionHistory).IdAuctionHistory, 10);
        }

        [Test]
        public void TestGetAuctionHistoryByIdWithInvalidId()
        {
            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAuctionHistoryById(10)).Returns(
            new AuctionHistory()
            {
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            });

            AuctionHistoryServices.DataServices = mock.Object;
            var result = auctionHistoryServices.GetAuctionHistoryById(1);

            Assert.AreEqual(result, null);
        }

    }
}
