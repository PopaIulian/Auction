// <copyright file="AuctionHistoryServicesTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Test.ServicesTest
{
    using System;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AuctionHistoryServicesTest" />.
    /// </summary>
    internal class AuctionHistoryServicesTest
    {
        /// <summary>
        /// The TestAddAuctionHistoryWithValidData.
        /// </summary>
        [Test]
        public void TestAddAuctionHistoryWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                AuctionDate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.AddAuctionHistory(auctionHistory);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddAuctionHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddAuctionHistoryWithInvalidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory();

            IAuctionHistoryServices readerServices = new AuctionHistoryServices();
            bool result = readerServices.AddAuctionHistory(auctionHistory);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteAuctionHistoryWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteAuctionHistoryWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                AuctionDate = DateTime.Now.AddDays(3),
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

        /// <summary>
        /// The TestDeleteAuctionHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteAuctionHistoryWithInvalidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory();

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.DeleteAuctionHistory(auctionHistory);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                AuctionDate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.UpdateAuctionHistory(auctionHistory);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateAuctionHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateAuctionHistoryWithInvalidData()
        {
            AuctionHistory auctionHistory = new AuctionHistory();

            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            bool result = auctionHistoryServices.UpdateAuctionHistory(auctionHistory);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfAuctionHistories.
        /// </summary>
        [Test]
        public void TestGetListOfAuctionHistories()
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
                AuctionDate = DateTime.Now.AddDays(3),
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

        /// <summary>
        /// The TestGetAuctionHistoryById.
        /// </summary>
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
                AuctionDate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            });

            AuctionHistoryServices.DataServices = mock.Object;
            var result = auctionHistoryServices.GetAuctionHistoryById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as AuctionHistory).IdAuctionHistory, 5);
        }

        /// <summary>
        /// The TestGetAuctionHistoryByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetAuctionHistoryByIdWithInvalidId()
        {
            IAuctionHistoryServices auctionHistoryServices = new AuctionHistoryServices();
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAuctionHistoryById(10)).Returns(
            new AuctionHistory()
            {
                UserId = 6,
                AuctionDate = DateTime.Now.AddDays(3),
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
