

namespace AuctionManagement.Test.ServicesTest
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    class CategoryServicesTest
    {
        [Test]
        public void TestAddAuctionWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            };

            ICategoryServices CategoryServices = new CategoryServices();
            bool result = CategoryServices.AddCategory(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestAddAuctionWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices readerServices = new CategoryServices();
            bool result = readerServices.AddCategory(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestDeleteAuctionWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            };

            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.DeleteCategory(test));

            CategoryServices.DataServices = mock.Object;
            bool result = categoryServices.DeleteCategory(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices CategoryServices = new CategoryServices();
            bool result = CategoryServices.DeleteCategory(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            };

            ICategoryServices CategoryServices = new CategoryServices();
            bool result = CategoryServices.UpdateCategory(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices CategoryServices = new CategoryServices();
            bool result = CategoryServices.UpdateCategory(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestGetListOfAuctions()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetAllCategories()).Returns(
                new List<Category>()
                {
                     new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            }
        });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetListOfCategories();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Auction>).Count, 1);
        }

        [Test]
        public void TestGetAuctionById()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(1)).Returns(

            new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,
            });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetCategoryById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Category).IdCategory, 10);
        }

        [Test]
        public void TestGetAuctionByIdWithInvalidId()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(10)).Returns(
            new Category()
            {
                CategoryName = "name",
                ParentId = 2,
            });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetCategoryById(1);

            Assert.AreEqual(result, null);
        }
    }
}