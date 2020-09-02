// <copyright file="ProductServicesTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.ServicesTest
{
    using System.Collections.Generic;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="ProductServicesTest" />.
    /// </summary>
    internal class ProductServicesTest
    {
        /// <summary>
        /// The TestAddProductWithValidData.
        /// </summary>
        [Test]
        public void TestAddProductWithValidData()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryName = 2
            };

            IProductServices productServices = new ProductServices();
            bool result = productServices.AddProduct(test);

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

            IProductServices productServices = new ProductServices();
            bool result = productServices.DeleteProduct(test);

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

            IProductServices productServices = new ProductServices();
            bool result = productServices.UpdateProduct(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateProductWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateProductWithInvalidData()
        {
            Product test = new Product();

            IProductServices productServices = new ProductServices();
            bool result = productServices.UpdateProduct(test);

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

        /// <summary>
        /// The TestAddNullProduct.
        /// </summary>
        [Test]
        public void TestAddNullProduct()
        {
            Product test = null;
            IProductServices productServices = new ProductServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { productServices.AddProduct(test); });
        }

        /// <summary>
        /// The TestDeleteNullProduct.
        /// </summary>
        [Test]
        public void TestDeleteNullProduct()
        {
            Product test = null;
            IProductServices productServices = new ProductServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { productServices.DeleteProduct(test); });
        }

        /// <summary>
        /// The TestUpdateNullProduct.
        /// </summary>
        [Test]
        public void TestUpdateNullProduct()
        {
            Product test = null;
            IProductServices productServices = new ProductServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { productServices.UpdateProduct(test); });
        }
    }
}
