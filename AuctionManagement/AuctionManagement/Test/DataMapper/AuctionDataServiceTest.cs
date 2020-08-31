// <copyright file="AuctionDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DataMapper
{
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
        /// The TestAllAuctionOperation.
        /// </summary>
        [Test]
        public void TestAllAuctionOperation()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                UserId = 2,
                Price = 34
            };

            SqlAuctionDataServices service = new SqlAuctionDataServices();

            service.AddAuction(test);

            Auction elem = service.GetAuctionById(1);
            Assert.AreEqual(elem.Price, test.Price);

            var elems = service.GetAllAuctions();
            Assert.IsNotEmpty(elems);

            Auction newElem = new Auction()
            {
                IdAuction = 1,
                ObjectId = 2
            };
            service.UpdateAuction(newElem);
            service.DeleteAuction(test);
        }
    }
}
