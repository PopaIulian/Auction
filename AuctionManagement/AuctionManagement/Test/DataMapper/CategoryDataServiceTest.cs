

namespace AuctionTests.DataMapper
{
      using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class CategoryDataServiceTest
    {

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

        [Test]
        public void GetAllCategorysTest()
        {
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetAllCategories());

            ICategoryDataServices obj = mock.Object;
            obj.GetAllCategories();

            mock.Verify(o => o.GetAllCategories(), Times.Once());
        }

        [Test]
        public void GetCategoryByIdTest()
        {
            Mock<ICategoryDataServices> mock = new Mock<ICategoryDataServices>();
            mock.Setup(m => m.GetCategoryById(1));

            ICategoryDataServices obj = mock.Object;
            obj.GetCategoryById(1);

            mock.Verify(o => o.GetCategoryById(1), Times.Once());
        }
    }
}
