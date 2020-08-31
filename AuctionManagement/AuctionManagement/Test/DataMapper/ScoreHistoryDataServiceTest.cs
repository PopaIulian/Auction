// <copyright file="ScoreHistoryDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace ScoreHistoryTests.DataMapper
{
    using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="ScoreHistoryDataServiceTest" />.
    /// </summary>
    internal class ScoreHistoryDataServiceTest
    {
        /// <summary>
        /// The AddScoreHistoryTest.
        /// </summary>
        [Test]
        public void AddScoreHistoryTest()
        {
            ScoreHistory scoreHistory = new Mock<ScoreHistory>().Object;

            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.AddScoreHistory(scoreHistory));

            IScoreHistoryDataServices obj = mock.Object;
            obj.AddScoreHistory(scoreHistory);

            mock.Verify(o => o.AddScoreHistory(scoreHistory), Times.Once());
        }

        /// <summary>
        /// The DeleteScoreHistoryTest.
        /// </summary>
        [Test]
        public void DeleteScoreHistoryTest()
        {
            ScoreHistory scoreHistory = new Mock<ScoreHistory>().Object;

            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.DeleteScoreHistory(scoreHistory));

            IScoreHistoryDataServices obj = mock.Object;
            obj.DeleteScoreHistory(scoreHistory);

            mock.Verify(o => o.DeleteScoreHistory(scoreHistory), Times.Once());
        }

        /// <summary>
        /// The UpdateScoreHistoryTest.
        /// </summary>
        [Test]
        public void UpdateScoreHistoryTest()
        {
            ScoreHistory scoreHistory = new Mock<ScoreHistory>().Object;

            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.UpdateScoreHistory(scoreHistory));

            IScoreHistoryDataServices obj = mock.Object;
            obj.UpdateScoreHistory(scoreHistory);

            mock.Verify(o => o.UpdateScoreHistory(scoreHistory), Times.Once());
        }

        /// <summary>
        /// The GetAllScoreHistoriesTest.
        /// </summary>
        [Test]
        public void GetAllScoreHistoriesTest()
        {
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetAllScoreHistories());

            IScoreHistoryDataServices obj = mock.Object;
            obj.GetAllScoreHistories();

            mock.Verify(o => o.GetAllScoreHistories(), Times.Once());
        }

        /// <summary>
        /// The GetScoreHistoryByIdTest.
        /// </summary>
        [Test]
        public void GetScoreHistoryByIdTest()
        {
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetScoreHistoryById(1));

            IScoreHistoryDataServices obj = mock.Object;
            obj.GetScoreHistoryById(1);

            mock.Verify(o => o.GetScoreHistoryById(1), Times.Once());
        }

        //[Test]
        //public void TestAllScoreHistoryOperation()
        //{
        //    ScoreHistory test = new ScoreHistory()
        //    {
        //        IdScoreHistory = 1,
        //        DateScore = DateTime.Now,
        //        PersonId = 2,
        //        Score = 56
        //    };

        //    IScoreHistoryDataServices service = new SqlScoreHistoryServices();

        //    service.AddScoreHistory(test);

        //    ScoreHistory elem = service.GetScoreHistoryById(1);
        //    Assert.AreEqual(elem.PersonId, test.PersonId);

        //    var elems = service.GetAllScoreHistories();
        //    Assert.IsNotEmpty(elems);

        //    ScoreHistory newElem = new ScoreHistory()
        //    {
        //        IdScoreHistory = 1,
        //        Score = 59
        //    };
        //    service.UpdateScoreHistory(newElem);
        //    service.DeleteScoreHistory(test);
        //}
    }
}
