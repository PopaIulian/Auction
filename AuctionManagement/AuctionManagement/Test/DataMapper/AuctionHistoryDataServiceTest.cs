// <copyright file="AuctionHistoryDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DataMapper
{
    using System;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DataMapper.SqlServerDAO;
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
        /// The GetAllAuctionHistoriesTest.
        /// </summary>
        [Test]
        public void GetAllAuctionHistoriesTest()
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

        /// <summary>
        /// The ImpAuctionHistoryTest.
        /// </summary>
        [Test]
        public void ImpAuctionHistoryTest()
        {
            AuctionHistory auction = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                Price = 34,
                AuctionDate = DateTime.Now,
                Currency = "ron",
                Person = new Person { IdPerson = 2, Username = "user", PersonRole = "bidder", Score = 34, DateWrongScore = DateTime.Now.AddDays(-39) },
                Auction = new Auction
                {
                    IdAuction = 1,
                    Price = 34,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(5),
                    Currency = "ron",
                    Person = new Person { IdPerson = 2, Username = "user", PersonRole = "bidder", Score = 34, DateWrongScore = DateTime.Now.AddDays(-39) },
                    Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryId = 2 },
                    ObjectId = 1,
                    UserId = 2,
                },
                AuctionId = 1,
                UserId = 2,
            };

            SqlAuctionHistoryDataServices service = new SqlAuctionHistoryDataServices();
            try
            {
                service.AddAuctionHistory(auction);
                auction.Price = 40;
                service.UpdateAuctionHistory(auction);
                var people = service.GetAllAuctionsHistory();
                var samePerson = service.GetAuctionHistoryById(auction.IdAuctionHistory);
                service.DeleteAuctionHistory(auction);
            }
            catch
            {
                throw;
            }
        }
    }
}
