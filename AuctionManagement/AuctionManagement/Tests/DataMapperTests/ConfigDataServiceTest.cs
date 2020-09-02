// <copyright file="ConfigDataServiceTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="ConfigDataServiceTest" />.
    /// </summary>
    internal class ConfigDataServiceTest
    {
        /// <summary>
        /// The AddConfigTest.
        /// </summary>
        [Test]
        public void AddConfigTest()
        {
            Config config = new Mock<Config>().Object;

            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.AddConfig(config));

            IConfigDataServices obj = mock.Object;
            obj.AddConfig(config);

            mock.Verify(o => o.AddConfig(config), Times.Once());
        }

        /// <summary>
        /// The DeleteConfigTest.
        /// </summary>
        [Test]
        public void DeleteConfigTest()
        {
            Config config = new Mock<Config>().Object;

            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.DeleteConfig(config));

            IConfigDataServices obj = mock.Object;
            obj.DeleteConfig(config);

            mock.Verify(o => o.DeleteConfig(config), Times.Once());
        }

        /// <summary>
        /// The UpdateConfigTest.
        /// </summary>
        [Test]
        public void UpdateConfigTest()
        {
            Config config = new Mock<Config>().Object;

            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.UpdateConfig(config));

            IConfigDataServices obj = mock.Object;
            obj.UpdateConfig(config);

            mock.Verify(o => o.UpdateConfig(config), Times.Once());
        }

        /// <summary>
        /// The Get all configurations Test.
        /// </summary>
        [Test]
        public void GetAllConfigsTest()
        {
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetAllConfigurations());

            IConfigDataServices obj = mock.Object;
            obj.GetAllConfigurations();

            mock.Verify(o => o.GetAllConfigurations(), Times.Once());
        }

        /// <summary>
        /// The GetConfigByIdTest.
        /// </summary>
        [Test]
        public void GetConfigByIdTest()
        {
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetConfigById("initial_score"));

            IConfigDataServices obj = mock.Object;
            obj.GetConfigById("initial_score");

            mock.Verify(o => o.GetConfigById("initial_score"), Times.Once());
        }

        /// <summary>
        /// The TestAllConfigOperation.
        /// </summary>
        [Test]
        public void TestAllConfigOperation()
        {
            Config config = new Config()
            {
                IdConfig = "initial_number",
                ValueConfig = 5
            };

            SqlConfigDataServices service = new SqlConfigDataServices();
            try
            {
                service.AddConfig(config);
                var people = service.GetAllConfigurations();
                var samePerson = service.GetConfigById(config.IdConfig);
                service.DeleteConfig(config);
            }
            catch
            {
                throw;
            }
        }
    }
}
