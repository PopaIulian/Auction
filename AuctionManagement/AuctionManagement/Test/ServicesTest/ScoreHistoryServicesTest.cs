// <copyright file="ScoreHistoryServicesTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

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

    /// <summary>
    /// Defines the <see cref="ScoreHistoryServicesTest" />.
    /// </summary>
    internal class ScoreHistoryServicesTest
    {
        /// <summary>
        /// The TestAddAuctionWithValidData.
        /// </summary>
        [Test]
        public void TestAddAuctionWithValidData()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            };

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            bool result = scoreHistoryServices.AddScoreHistory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices readerServices = new ScoreHistoryServices();
            bool result = readerServices.AddScoreHistory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteAuctionWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteAuctionWithValidData()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            };

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.DeleteScoreHistory(test));

            ScoreHistoryServices.DataServices = mock.Object;
            bool result = scoreHistoryServices.DeleteScoreHistory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestDeleteAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            bool result = scoreHistoryServices.DeleteScoreHistory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            ScoreHistory test = new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56

            };

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            bool result = scoreHistoryServices.UpdateScoreHistory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            bool result = scoreHistoryServices.UpdateScoreHistory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfAuctions.
        /// </summary>
        [Test]
        public void TestGetListOfAuctions()
        {
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetAllScoreHistories()).Returns(
                new List<ScoreHistory>()
                {
                     new ScoreHistory()
            {
              IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56

            }
        });

            ScoreHistoryServices.DataServices = mock.Object;
            var result = scoreHistoryServices.GetListOfScoreHistories();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Auction>).Count, 1);
        }

        /// <summary>
        /// The TestGetAuctionById.
        /// </summary>
        [Test]
        public void TestGetAuctionById()
        {
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetScoreHistoryById(1)).Returns(

            new ScoreHistory()
            {
                IdScoreHistory = 1,
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            });

            ScoreHistoryServices.DataServices = mock.Object;
            var result = scoreHistoryServices.GetScoreHistoryById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as ScoreHistory).IdScoreHistory, 10);
        }

        /// <summary>
        /// The TestGetAuctionByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetAuctionByIdWithInvalidId()
        {
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetScoreHistoryById(10)).Returns(
            new ScoreHistory()
            {
                DateScore = DateTime.Now,
                PersonId = 2,
                Score = 56
            });

            ScoreHistoryServices.DataServices = mock.Object;
            var result = scoreHistoryServices.GetScoreHistoryById(1);

            Assert.AreEqual(result, null);
        }
    }
}
