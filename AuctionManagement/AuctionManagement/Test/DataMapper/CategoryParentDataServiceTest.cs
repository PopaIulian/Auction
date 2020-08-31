
namespace AuctionManagement.Test.DataMapper
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DataMapper.SqlServerDAO;
    using AuctionManagement.DomainModel;
    using Moq;
    using NUnit.Framework;

    internal class CategoryParentParentDataServiceTest
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
    }
}
