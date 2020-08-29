using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTests.DataMapper
{
          using Moq;
    using NUnit.Framework;
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class ConfigDataServiceTest
    {

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

        [Test]
        public void GetAllConfigsTest()
        {
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetAllConfigurations());

            IConfigDataServices obj = mock.Object;
            obj.GetAllConfigurations();

            mock.Verify(o => o.GetAllConfigurations(), Times.Once());
        }

        [Test]
        public void GetConfigByIdTest()
        {
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetConfigById("initial_score"));

            IConfigDataServices obj = mock.Object;
            obj.GetConfigById("initial_score");

            mock.Verify(o => o.GetConfigById("initial_score"), Times.Once());
        }
    }
}
