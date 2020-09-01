// <copyright file="ProductDataServiceTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="ProductDataServiceTest" />.
    /// </summary>
    internal class ProductDataServiceTest
    {
        /// <summary>
        /// The AddProductTest.
        /// </summary>
        [Test]
        public void AddProductTest()
        {
            Product product = new Mock<Product>().Object;

            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.AddObject(product));

            IProductDataServices obj = mock.Object;
            obj.AddObject(product);

            mock.Verify(o => o.AddObject(product), Times.Once());
        }

        /// <summary>
        /// The DeleteProductTest.
        /// </summary>
        [Test]
        public void DeleteProductTest()
        {
            Product product = new Mock<Product>().Object;

            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.DeleteObject(product));

            IProductDataServices obj = mock.Object;
            obj.DeleteObject(product);

            mock.Verify(o => o.DeleteObject(product), Times.Once());
        }

        /// <summary>
        /// The UpdateProductTest.
        /// </summary>
        [Test]
        public void UpdateProductTest()
        {
            Product product = new Mock<Product>().Object;

            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.UpdateObject(product));

            IProductDataServices obj = mock.Object;
            obj.UpdateObject(product);

            mock.Verify(o => o.UpdateObject(product), Times.Once());
        }

        /// <summary>
        /// The GetAllProductsTest.
        /// </summary>
        [Test]
        public void GetAllProductsTest()
        {
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetAllObjects());

            IProductDataServices obj = mock.Object;
            obj.GetAllObjects();

            mock.Verify(o => o.GetAllObjects(), Times.Once());
        }

        /// <summary>
        /// The GetProductByIdTest.
        /// </summary>
        [Test]
        public void GetProductByIdTest()
        {
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetObjectById(1));

            IProductDataServices obj = mock.Object;
            obj.GetObjectById(1);

            mock.Verify(o => o.GetObjectById(1), Times.Once());
        }

        /// <summary>
        /// The TestAllAuctionOperation.
        /// </summary>
        [Test]
        public void TestAllAuctionOperation()
        {
            Product product = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryId = 2
            };

            SqlProductDataServices service = new SqlProductDataServices();
            try
            {
                service.AddObject(product);
                product.ObjectName = "new_name";
                service.UpdateObject(product);
                var people = service.GetAllObjects();
                var sameProduct = service.GetObjectById(product.IdProduct);
                service.DeleteObject(product);
            }
            catch
            {
                throw;
            }
        }
    }
}
