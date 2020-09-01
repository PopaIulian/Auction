// <copyright file="CategoryParentDataServiceTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="CategoryParentDataServiceTest" />.
    /// </summary>
    internal class CategoryParentDataServiceTest
    {
        /// <summary>
        /// The AddCategoryParentTest.
        /// </summary>
        [Test]
        public void AddCategoryParentTest()
        {
            CategoryParent categoryParent = new Mock<CategoryParent>().Object;

            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.AddCategoryParent(categoryParent));

            ICategoryParentDataServices obj = mock.Object;
            obj.AddCategoryParent(categoryParent);

            mock.Verify(o => o.AddCategoryParent(categoryParent), Times.Once());
        }

        /// <summary>
        /// The DeleteCategoryParentTest.
        /// </summary>
        [Test]
        public void DeleteCategoryParentTest()
        {
            CategoryParent categoryParent = new Mock<CategoryParent>().Object;

            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.DeleteCategoryParent(categoryParent));

            ICategoryParentDataServices obj = mock.Object;
            obj.DeleteCategoryParent(categoryParent);

            mock.Verify(o => o.DeleteCategoryParent(categoryParent), Times.Once());
        }

        /// <summary>
        /// The UpdateCategoryParentTest.
        /// </summary>
        [Test]
        public void UpdateCategoryParentTest()
        {
            CategoryParent categoryParent = new Mock<CategoryParent>().Object;

            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.UpdateCategoryParent(categoryParent));

            ICategoryParentDataServices obj = mock.Object;
            obj.UpdateCategoryParent(categoryParent);

            mock.Verify(o => o.UpdateCategoryParent(categoryParent), Times.Once());
        }

        /// <summary>
        /// The GetAllCategoryParentsTest.
        /// </summary>
        [Test]
        public void GetAllCategoryParentsTest()
        {
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.GetAllCategoriesParent());

            ICategoryParentDataServices obj = mock.Object;
            obj.GetAllCategoriesParent();

            mock.Verify(o => o.GetAllCategoriesParent(), Times.Once());
        }

        /// <summary>
        /// The GetCategoryParentByIdTest.
        /// </summary>
        [Test]
        public void GetCategoryParentByIdTest()
        {
            Mock<ICategoryParentDataServices> mock = new Mock<ICategoryParentDataServices>();
            mock.Setup(m => m.GetCategoryParentById(1));

            ICategoryParentDataServices obj = mock.Object;
            obj.GetCategoryParentById(1);

            mock.Verify(o => o.GetCategoryParentById(1), Times.Once());
        }

        /// <summary>
        /// The TestAllAuctionOperation.
        /// </summary>
        [Test]
        public void TestAllAuctionOperation()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            SqlCategoryParentDataServices service = new SqlCategoryParentDataServices();

            service.AddCategoryParent(test);

            CategoryParent elem = service.GetCategoryParentById(1);
            Assert.AreEqual(elem.CategoryId, test.CategoryId);

            var elems = service.GetAllCategoriesParent();
            Assert.IsNotEmpty(elems);

            CategoryParent newElem = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 4
            };
            service.UpdateCategoryParent(newElem);
            service.UpdateCategoryParent(test);
        }

        /// <summary>
        /// The TestAllCategoryParentOperation.
        /// </summary>
        [Test]
        public void TestAllCategoryParentOperation()
        {
            CategoryParent category = new CategoryParent
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3,
                Category = new Category { IdCategory = 2, CategoryName = "cat_name" },
                Category1 = new Category { IdCategory = 3, CategoryName = "parent_name" },
            };

            SqlCategoryParentDataServices service = new SqlCategoryParentDataServices();
            try
            {
                service.AddCategoryParent(category);
                category.CategoryId = 7;
                service.UpdateCategoryParent(category);
                var people = service.GetAllCategoriesParent();
                var samePerson = service.GetCategoryParentById(category.IdCategoryParent);
                service.DeleteCategoryParent(category);
            }
            catch
            {
                throw;
            }
        }
    }
}
