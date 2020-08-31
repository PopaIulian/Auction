// <copyright file="CategoryDataServiceTest.cs" company="Transilvania University of Brasov">
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
        /// The TestAllAuctionOperation.
        /// </summary>
        [Test]
        public void TestAllAuctionOperation()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name"
            };

            SqlCategoryDataServices service = new SqlCategoryDataServices();

            service.AddCategory(test);

            Category elem = service.GetCategoryById(1);
            Assert.AreEqual(elem.CategoryName, test.CategoryName);

            var elems = service.GetAllCategories();
            Assert.IsNotEmpty(elems);

            Category newElem = new Category()
            {
                IdCategory = 1,
                CategoryName = "new_name"
            };
            service.UpdateCategory(newElem);
            service.UpdateCategory(test);
        }
    }
}
