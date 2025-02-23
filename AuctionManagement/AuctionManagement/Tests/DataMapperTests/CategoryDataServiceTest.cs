﻿// <copyright file="CategoryDataServiceTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="CategoryDataServiceTest" />.
    /// </summary>
    internal class CategoryDataServiceTest
    {
        /// <summary>
        /// The AddCategoryTest.
        /// </summary>
        [Test]
        public void AddCategoryTest()
        {
            Category category = new Mock<Category>().Object;

            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.AddCategory(category));

            ICategoryDataServices obj = mock.Object;
            obj.AddCategory(category);

            mock.Verify(o => o.AddCategory(category), Times.Once());
        }

        /// <summary>
        /// The DeleteCategoryTest.
        /// </summary>
        [Test]
        public void DeleteCategoryTest()
        {
            Category category = new Mock<Category>().Object;

            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.DeleteCategory(category));

            ICategoryDataServices obj = mock.Object;
            obj.DeleteCategory(category);

            mock.Verify(o => o.DeleteCategory(category), Times.Once());
        }

        /// <summary>
        /// The UpdateCategoryTest.
        /// </summary>
        [Test]
        public void UpdateCategoryTest()
        {
            Category category = new Mock<Category>().Object;

            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.UpdateCategory(category));

            ICategoryDataServices obj = mock.Object;
            obj.UpdateCategory(category);

            mock.Verify(o => o.UpdateCategory(category), Times.Once());
        }

        /// <summary>
        /// The GetAllCategoriesTest.
        /// </summary>
        [Test]
        public void GetAllCategoriesTest()
        {
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetAllCategories());

            ICategoryDataServices obj = mock.Object;
            obj.GetAllCategories();

            mock.Verify(o => o.GetAllCategories(), Times.Once());
        }

        /// <summary>
        /// The GetCategoryByIdTest.
        /// </summary>
        [Test]
        public void GetCategoryByIdTest()
        {
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(1));

            ICategoryDataServices obj = mock.Object;
            obj.GetCategoryById(1);

            mock.Verify(o => o.GetCategoryById(1), Times.Once());
        }

        /// <summary>
        /// The TestAllCategoryOperation.
        /// </summary>
        [Test]
        public void TestAllCategoryOperation()
        {
            Category category = new Category()
            {
                IdCategory = 3,
                CategoryName = "cat_name"
            };

            SqlCategoryDataServices service = new SqlCategoryDataServices();
            try
            {
                service.AddCategory(category);
                category.CategoryName = "new_name";
                service.UpdateCategory(category);
                var people = service.GetAllCategories();
                var samePerson = service.GetCategoryById(category.IdCategory);
                service.DeleteCategory(category);
            }
            catch
            {
                throw;
            }
        }
    }
}
