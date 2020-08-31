

namespace ProductManagement.Test.ServicesTest
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    internal class ProductServicesTest
    {


        [Test]
        public void TestAddProductWithValidData()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2
            };

            IProductServices ProductServices = new ProductServices();
            bool result = ProductServices.AddProduct(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddProductWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddProductWithInvalidData()
        {
            Product test = new Product();

            IProductServices readerServices = new ProductServices();
            bool result = readerServices.AddProduct(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteProductWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteProductWithValidData()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2
            };

            IProductServices productServices = new ProductServices();
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.DeleteObject(test));

            ProductServices.DataServices = mock.Object;
            bool result = productServices.DeleteProduct(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestDeleteProductWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteProductWithInvalidData()
        {
            Product test = new Product();

            IProductServices ProductServices = new ProductServices();
            bool result = ProductServices.DeleteProduct(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2

            };

            IProductServices ProductServices = new ProductServices();
            bool result = ProductServices.UpdateProduct(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateProductWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateProductWithInvalidData()
        {
            Product test = new Product();

            IProductServices ProductServices = new ProductServices();
            bool result = ProductServices.UpdateProduct(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfProducts.
        /// </summary>
        [Test]
        public void TestGetListOfProducts()
        {
            IProductServices productServices = new ProductServices();
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetAllObjects()).Returns(
                new List<Product>()
                {
                     new Product()
            {
                 IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2
            }
        });

            ProductServices.DataServices = mock.Object;
            var result = productServices.GetListOfProducts();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Product>).Count, 1);
        }

        /// <summary>
        /// The TestGetProductById.
        /// </summary>
        [Test]
        public void TestGetProductById()
        {
            IProductServices productServices = new ProductServices();
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetObjectById(1)).Returns(

            new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2
            });

            ProductServices.DataServices = mock.Object;
            var result = productServices.GetProductById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Product).IdProduct, 1);
        }

        /// <summary>
        /// The TestGetProductByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetProductByIdWithInvalidId()
        {
            IProductServices productServices = new ProductServices();
            Mock<IProductDataServices> mock = new Mock<IProductDataServices>();
            mock.Setup(m => m.GetObjectById(10)).Returns(
            new Product()
            {
                ObjectName = "name",
                CategoryName = 2
            });

            ProductServices.DataServices = mock.Object;
            var result = productServices.GetProductById(1);

            Assert.AreEqual(result, null);
        }
    }
}


