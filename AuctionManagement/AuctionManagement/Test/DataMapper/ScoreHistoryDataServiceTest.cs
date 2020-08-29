

namespace AuctionTests.DataMapper
{
    using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class ScoreHistoryDataServiceTest
    {

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

        [Test]
        public void GetAllScoreHistorysTest()
        {
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetAllScoreHistories());

            IScoreHistoryDataServices obj = mock.Object;
            obj.GetAllScoreHistories();

            mock.Verify(o => o.GetAllScoreHistories(), Times.Once());
        }

        [Test]
        public void GetScoreHistoryByIdTest()
        {
            Mock<IScoreHistoryDataServices> mock = new Mock<IScoreHistoryDataServices>();
            mock.Setup(m => m.GetScoreHistoryById(1));

            IScoreHistoryDataServices obj = mock.Object;
            obj.GetScoreHistoryById(1);

            mock.Verify(o => o.GetScoreHistoryById(1), Times.Once());
        }
    }
}
