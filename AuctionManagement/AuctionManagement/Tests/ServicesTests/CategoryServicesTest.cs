﻿// <copyright file="CategoryServicesTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="CategoryServicesTest" />.
    /// </summary>
    internal class CategoryServicesTest
    {
        /// <summary>
        /// The TestAddCategoryWithValidData.
        /// </summary>
        [Test]
        public void TestAddCategoryWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            };

            ICategoryServices categoryServices = new CategoryServices();
            bool result = categoryServices.AddCategory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddCategoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddCategoryWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices readerServices = new CategoryServices();
            bool result = readerServices.AddCategory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteCategoryWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteCategoryWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            };

            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.DeleteCategory(test));

            CategoryServices.DataServices = mock.Object;
            bool result = categoryServices.DeleteCategory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestDeleteCategoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteCategoryWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices categoryServices = new CategoryServices();
            bool result = categoryServices.DeleteCategory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            };

            ICategoryServices categoryServices = new CategoryServices();
            bool result = categoryServices.UpdateCategory(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateCategoryWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateCategoryWithInvalidData()
        {
            Category test = new Category();

            ICategoryServices categoryServices = new CategoryServices();
            bool result = categoryServices.UpdateCategory(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfCategories.
        /// </summary>
        [Test]
        public void TestGetListOfCategories()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetAllCategories()).Returns(
                new List<Category>()
                {
                     new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            }
        });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetListOfCategories();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Category>).Count, 1);
        }

        /// <summary>
        /// The TestGetCategoryById.
        /// </summary>
        [Test]
        public void TestGetCategoryById()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(1)).Returns(
            new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetCategoryById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Category).IdCategory, 1);
        }

        /// <summary>
        /// The TestGetCategoryByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetCategoryByIdWithInvalidId()
        {
            ICategoryServices categoryServices = new CategoryServices();
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(10)).Returns(
            new Category()
            {
                CategoryName = "name"
            });

            CategoryServices.DataServices = mock.Object;
            var result = categoryServices.GetCategoryById(1);

            Assert.AreEqual(result, null);
        }

        /// <summary>
        /// The TestAddNullCategory.
        /// </summary>
        [Test]
        public void TestAddNullCategory()
        {
            Category test = null;
            ICategoryServices categoryServices = new CategoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { categoryServices.AddCategory(test); });
        }

        /// <summary>
        /// The TestDeleteNullCategory.
        /// </summary>
        [Test]
        public void TestDeleteNullCategory()
        {
            Category test = null;
            ICategoryServices categoryServices = new CategoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { categoryServices.DeleteCategory(test); });
        }

        /// <summary>
        /// The TestUpdateNullCategory.
        /// </summary>
        [Test]
        public void TestUpdateNullCategory()
        {
            Category test = null;
            ICategoryServices categoryServices = new CategoryServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { categoryServices.UpdateCategory(test); });
        }
    }
}
