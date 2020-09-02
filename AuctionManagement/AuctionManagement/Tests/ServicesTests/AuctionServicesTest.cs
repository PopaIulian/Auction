// <copyright file="AuctionServicesTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.ServicesTest
{
    using System;
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="AuctionServicesTest" />.
    /// </summary>
    internal class AuctionServicesTest
    {
        /// <summary>
        /// The TestDeleteAuctionWithValidData.
        /// </summary>
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

        /// <summary>
        /// The TestDeleteAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            Auction auction = new Auction();

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.DeleteAuction(auction);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
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

        /// <summary>
        /// The TestUpdateAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            Auction auction = new Auction();

            IAuctionServices auctionServices = new AuctionServices();
            bool result = auctionServices.UpdateAuction(auction);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfAuctions.
        /// </summary>
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

        /// <summary>
        /// The TestGetAuctionById.
        /// </summary>
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
            Assert.AreEqual((result as Auction).IdAuction, 1);
        }

        /// <summary>
        /// The TestGetAuctionByIdWithInvalidId.
        /// </summary>
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

        /// <summary>
        /// The TestAddNullAuction.
        /// </summary>
        [Test]
        public void TestAddNullAuction()
        {
            Auction test = null;
            IAuctionServices auctionServices = new AuctionServices();
            Assert.Throws(typeof(NullReferenceException), delegate { auctionServices.AddAuction(test); });
        }

        /// <summary>
        /// The TestDeleteNullAuction.
        /// </summary>
        [Test]
        public void TestDeleteNullAuction()
        {
            Auction test = null;
            IAuctionServices auctionServices = new AuctionServices();
            Assert.Throws(typeof(ArgumentNullException), delegate { auctionServices.DeleteAuction(test); });
        }

        /// <summary>
        /// The TestUpdateNullDomain.
        /// </summary>
        [Test]
        public void TestUpdateNullDomain()
        {
            Auction test = null;
            IAuctionServices auctionServices = new AuctionServices();
            Assert.Throws(typeof(ArgumentNullException), delegate { auctionServices.UpdateAuction(test); });
        }
    }
}
