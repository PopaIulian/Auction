// <copyright file="CategoryParentServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Test.ServicesTest
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CategoryParentParentServiceTest" />.
    /// </summary>
    internal class CategoryParentParentServiceTest
    {
        /// <summary>
        /// The TestAddCategoryParentWithValidData.
        /// </summary>
        [Test]
        public void TestAddCategoryParentWithValidData()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            bool result = categoryParentServices.AddCategoryParent(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddCategoryParentWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddCategoryParentWithInvalidData()
        {
            CategoryParent test = new CategoryParent();

            ICategoryParentServices readerServices = new CategoryParentServices();
            bool result = readerServices.AddCategoryParent(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteCategoryParentWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteCategoryParentWithValidData()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.DeleteCategoryParent(test));

            CategoryParentServices.DataServices = mock.Object;
            bool result = categoryParentServices.DeleteCategoryParent(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestDeleteCategoryParentWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteCategoryParentWithInvalidData()
        {
            CategoryParent test = new CategoryParent();

            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            bool result = categoryParentServices.DeleteCategoryParent(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            bool result = categoryParentServices.UpdateCategoryParent(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateCategoryParentWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateCategoryParentWithInvalidData()
        {
            CategoryParent test = new CategoryParent();

            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            bool result = categoryParentServices.UpdateCategoryParent(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfCategoryParents.
        /// </summary>
        [Test]
        public void TestGetListOfCategories()
        {
            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.GetAllCategoriesParent()).Returns(
                new List<CategoryParent>()
                {
                     new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            }
        });

            CategoryParentServices.DataServices = mock.Object;
            var result = categoryParentServices.GetListOfCategories();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<CategoryParent>).Count, 1);
        }

        /// <summary>
        /// The TestGetCategoryParentById.
        /// </summary>
        [Test]
        public void TestGetCategoryParentById()
        {
            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.GetCategoryParentById(1)).Returns(

            new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            });

            CategoryParentServices.DataServices = mock.Object;
            var result = categoryParentServices.GetCategoryParentById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as CategoryParent).IdCategoryParent, 1);
        }

        /// <summary>
        /// The TestGetCategoryParentByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetCategoryParentByIdWithInvalidId()
        {
            ICategoryParentServices categoryParentServices = new CategoryParentServices();
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.GetCategoryParentById(10)).Returns(
            new CategoryParent()
            {
                CategoryId = 2,
                ParentId = 3
            });

            CategoryParentServices.DataServices = mock.Object;
            var result = categoryParentServices.GetCategoryParentById(1);

            Assert.AreEqual(result, null);
        }
    }
}
