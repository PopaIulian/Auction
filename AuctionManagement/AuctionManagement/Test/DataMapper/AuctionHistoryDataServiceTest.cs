// <copyright file="AuctionHistoryDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Test.DataMapper
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="AuctionHistoryDataServiceTest" />.
    /// </summary>
    internal class AuctionHistoryDataServiceTest
    {
        /// <summary>
        /// The AddAuctionHistoryTest.
        /// </summary>
        [Test]
        public void AddAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.AddAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.AddAuctionHistory(auctionHistory);

            mock.Verify(o => o.AddAuctionHistory(auctionHistory), Times.Once());
        }

        /// <summary>
        /// The DeleteAuctionHistoryTest.
        /// </summary>
        [Test]
        public void DeleteAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.DeleteAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.DeleteAuctionHistory(auctionHistory);

            mock.Verify(o => o.DeleteAuctionHistory(auctionHistory), Times.Once());
        }

        /// <summary>
        /// The UpdateAuctionHistoryTest.
        /// </summary>
        [Test]
        public void UpdateAuctionHistoryTest()
        {
            AuctionHistory auctionHistory = new Mock<AuctionHistory>().Object;

            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.UpdateAuctionHistory(auctionHistory));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.UpdateAuctionHistory(auctionHistory);

            mock.Verify(o => o.UpdateAuctionHistory(auctionHistory), Times.Once());
        }

        /// <summary>
        /// The GetAllAuctionHistorysTest.
        /// </summary>
        [Test]
        public void GetAllAuctionHistorysTest()
        {
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAllAuctionsHistory());

            IAuctionHistoryDataServices obj = mock.Object;
            obj.GetAllAuctionsHistory();

            mock.Verify(o => o.GetAllAuctionsHistory(), Times.Once());
        }

        /// <summary>
        /// The GetAuctionHistoryByIdTest.
        /// </summary>
        [Test]
        public void GetAuctionHistoryByIdTest()
        {
            Mock<IAuctionHistoryDataServices> mock = new Mock<IAuctionHistoryDataServices>();
            mock.Setup(m => m.GetAuctionHistoryById(1));

            IAuctionHistoryDataServices obj = mock.Object;
            obj.GetAuctionHistoryById(1);

            mock.Verify(o => o.GetAuctionHistoryById(1), Times.Once());
        }
    }
}
