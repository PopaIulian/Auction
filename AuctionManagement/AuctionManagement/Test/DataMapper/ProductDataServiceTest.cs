

namespace AuctionTests.DataMapper
{
   
       using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class ProductDataServiceTest
    {
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

        [Test]
        public void GetAllProductsTest()
        {
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetAllObjects());

            IProductDataServices obj = mock.Object;
            obj.GetAllObjects();

            mock.Verify(o => o.GetAllObjects(), Times.Once());
        }

        [Test]
        public void GetProductByIdTest()
        {
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetObjectById(1));

            IProductDataServices obj = mock.Object;
            obj.GetObjectById(1);

            mock.Verify(o => o.GetObjectById(1), Times.Once());
        }
    }
}
