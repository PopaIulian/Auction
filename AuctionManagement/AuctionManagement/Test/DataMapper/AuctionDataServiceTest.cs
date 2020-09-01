// <copyright file="AuctionDataServiceTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="AuctionDataServiceTest" />.
    /// </summary>
    internal class AuctionDataServiceTest
    {
        /// <summary>
        /// The AddAuctionTest.
        /// </summary>
        [Test]
        public void AddAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.AddAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.AddAuction(auction);

            mock.Verify(o => o.AddAuction(auction), Times.Once());
        }

        /// <summary>
        /// The DeleteAuctionTest.
        /// </summary>
        [Test]
        public void DeleteAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.DeleteAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.DeleteAuction(auction);

            mock.Verify(o => o.DeleteAuction(auction), Times.Once());
        }

        /// <summary>
        /// The UpdateAuctionTest.
        /// </summary>
        [Test]
        public void UpdateAuctionTest()
        {
            Auction auction = new Mock<Auction>().Object;

            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.UpdateAuction(auction));

            IAuctionDataServices obj = mock.Object;
            obj.UpdateAuction(auction);

            mock.Verify(o => o.UpdateAuction(auction), Times.Once());
        }

        /// <summary>
        /// The GetAllAuctionsTest.
        /// </summary>
        [Test]
        public void GetAllAuctionsTest()
        {
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAllAuctions());

            IAuctionDataServices obj = mock.Object;
            obj.GetAllAuctions();

            mock.Verify(o => o.GetAllAuctions(), Times.Once());
        }

        /// <summary>
        /// The GetAllAuctionsOpenTest.
        /// </summary>
        [Test]
        public void GetAllAuctionsUserTest()
        {
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAllOpenAuction(1));

            IAuctionDataServices obj = mock.Object;
            obj.GetAllOpenAuction(1);

            mock.Verify(o => o.GetAllOpenAuction(1), Times.Once());
        }

        /// <summary>
        /// The GetAuctionByIdTest.
        /// </summary>
        [Test]
        public void GetAuctionByIdTest()
        {
            Mock<IAuctionDataServices> mock = new Mock<IAuctionDataServices>();
            mock.Setup(m => m.GetAuctionById(1));

            IAuctionDataServices obj = mock.Object;
            obj.GetAuctionById(1);

            mock.Verify(o => o.GetAuctionById(1), Times.Once());
        }

        /// <summary>
        /// The AddAuctionImplementationTest.
        /// </summary>
        [Test]
        public void AddAuctionImplementationTest()
        {
            Auction auction = new Auction()
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
            };

            SqlAuctionDataServices service = new SqlAuctionDataServices();
            try
            {
                service.AddAuction(auction);
                auction.Price = 40;
                service.UpdateAuction(auction);
                var people = service.GetAllAuctions();
                var samePerson = service.GetAuctionById(auction.IdAuction);
                service.DeleteAuction(auction);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// The AddAuctionImplementationTest.
        /// </summary>
        [Test]
        public void AddAuctionOoenUserImplementationTest()
        {
            Auction auction = new Auction()
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
            };

            SqlAuctionDataServices service = new SqlAuctionDataServices();
            try
            {
                service.AddAuction(auction);
                var sameAuction = service.GetAllOpenAuction(auction.UserId);
            }
            catch
            {
                throw;
            }
        }
    }
}
