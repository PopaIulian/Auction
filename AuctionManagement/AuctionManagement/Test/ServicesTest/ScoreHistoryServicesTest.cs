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

    class ScoreHistoryServicesTest
    {
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

            IScoreHistoryServices ScoreHistoryServices = new ScoreHistoryServices();
            bool result = ScoreHistoryServices.AddScoreHistory(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestAddAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices readerServices = new ScoreHistoryServices();
            bool result = readerServices.AddScoreHistory(test);

            Assert.IsFalse(result);
        }

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

        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices ScoreHistoryServices = new ScoreHistoryServices();
            bool result = ScoreHistoryServices.DeleteScoreHistory(test);

            Assert.IsFalse(result);
        }

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

            IScoreHistoryServices ScoreHistoryServices = new ScoreHistoryServices();
            bool result = ScoreHistoryServices.UpdateScoreHistory(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            ScoreHistory test = new ScoreHistory();

            IScoreHistoryServices ScoreHistoryServices = new ScoreHistoryServices();
            bool result = ScoreHistoryServices.UpdateScoreHistory(test);

            Assert.IsFalse(result);
        }

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
