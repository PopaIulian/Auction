﻿

namespace AuctionTests.ServicesTest
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    class AuctionServicesTest
    {
        [Test]
        public void TestAddAuctionWithValidData()
        {
            Auction auction = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.AddAuction(auction);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestAddAuctionWithInvalidData()
        {
            Auction auction = new Auction();

            IAuctionServices readerServices = new AuctionServices();
            bool result = readerServices.AddAuction(auction);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestDeleteAuctionWithValidData()
        {
            Auction auction = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            IAuctionServices auctionServices = new AuctionServices();
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.DeleteAuction(auction));

            AuctionServices.DataServices = mock.Object;
            bool result = auctionServices.DeleteAuction(auction);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            Auction Auction = new Auction();

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.DeleteAuction(Auction);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Auction auction = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.UpdateAuction(auction);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            Auction auction = new Auction();

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.UpdateAuction(auction);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestGetListOfAuctions()
        {
            IAuctionServices auctionServices = new AuctionServices();
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAllAuctions()).Returns(
                new List<Auction>()
                {
                    new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            }
        });

            AuctionServices.DataServices = mock.Object;
            var result = auctionServices.GetListOfAuctions();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Auction>).Count, 1);
        }

        [Test]
        public void TestGetAuctionById()
        {
            IAuctionServices auctionServices = new AuctionServices();
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAuctionById(1)).Returns(

            new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            });

            AuctionServices.DataServices = mock.Object;
            var result = auctionServices.GetAuctionById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Auction).IdAuction, 10);
        }

        [Test]
        public void TestGetAuctionByIdWithInvalidId()
        {
            IAuctionServices auctionServices = new AuctionServices();
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAuctionById(10)).Returns(
            new Auction()
            {
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            });

            AuctionServices.DataServices = mock.Object;
            var result = auctionServices.GetAuctionById(1);

            Assert.AreEqual(result, null);
        }

    }
}
