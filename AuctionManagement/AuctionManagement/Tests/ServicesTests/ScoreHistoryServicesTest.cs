// <copyright file="ScoreHistoryServicesTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="ScoreHistoryServicesTest" />.
    /// </summary>
    internal class ScoreHistoryServicesTest
    {
        /// <summary>
        /// The TestAddScoreHistoryWithValidData.
        /// </summary>
        [Test]
        public void TestAddScoreHistoryWithValidData()
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
        /// The TestAddScoreHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddScoreHistoryWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices readerServices = new ScoreHistoryServices();
            bool result = readerServices.AddScoreHistory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteScoreHistoryWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteScoreHistoryWithValidData()
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
        /// The TestDeleteScoreHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteScoreHistoryWithInvalidData()
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
        /// The TestUpdateScoreHistoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateScoreHistoryWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            bool result = scoreHistoryServices.UpdateScoreHistory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfScoreHistories.
        /// </summary>
        [Test]
        public void TestGetListOfScoreHistories()
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
            Assert.AreEqual((result as List<ScoreHistory>).Count, 1);
        }

        /// <summary>
        /// The TestGetScoreHistoryById.
        /// </summary>
        [Test]
        public void TestGetScoreHistoryById()
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
            Assert.AreEqual((result as ScoreHistory).IdScoreHistory, 1);
        }

        /// <summary>
        /// The TestGetScoreHistoryByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetScoreHistoryByIdWithInvalidId()
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

        /// <summary>
        /// The TestAddNullScoreHistory.
        /// </summary>
        [Test]
        public void TestAddNullScoreHistory()
        {
            ScoreHistory test = null;
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { scoreHistoryServices.AddScoreHistory(test); });
        }

        /// <summary>
        /// The TestDeleteNullScoreHistory.
        /// </summary>
        [Test]
        public void TestDeleteNullScoreHistory()
        {
            ScoreHistory test = null;
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { scoreHistoryServices.DeleteScoreHistory(test); });
        }

        /// <summary>
        /// The TestUpdateNullScoreHistory.
        /// </summary>
        [Test]
        public void TestUpdateNullScoreHistory()
        {
            ScoreHistory test = null;
            IScoreHistoryServices scoreHistoryServices = new ScoreHistoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { scoreHistoryServices.UpdateScoreHistory(test); });
        }
    }
}
