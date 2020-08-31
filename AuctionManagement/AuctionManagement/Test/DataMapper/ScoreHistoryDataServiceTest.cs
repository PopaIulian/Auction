﻿// <copyright file="ScoreHistoryDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DataMapper
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using Moq;
    using NUnit.Framework;

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
    }
}
