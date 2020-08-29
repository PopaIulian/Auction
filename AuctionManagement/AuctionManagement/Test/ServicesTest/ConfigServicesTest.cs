using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class ConfigServicesTest
    {
        [Test]
        public void TestAddAuctionWithValidData()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 3

            };

            IConfigServices ConfigServices = new ConfigServices();
            bool result = ConfigServices.AddConfig(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestAddAuctionWithInvalidData()
        {
            Config test = new Config();

            IConfigServices readerServices = new ConfigServices();
            bool result = readerServices.AddConfig(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestDeleteAuctionWithValidData()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 3

            };

            IConfigServices configServices = new ConfigServices();
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.DeleteConfig(test));

            ConfigServices.DataServices = mock.Object;
            bool result = configServices.DeleteConfig(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestDeleteAuctionWithInvalidData()
        {
            Config test = new Config();

            IConfigServices ConfigServices = new ConfigServices();
            bool result = ConfigServices.DeleteConfig(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 3

            };

            IConfigServices ConfigServices = new ConfigServices();
            bool result = ConfigServices.UpdateConfig(test);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestUpdateAuctionWithInvalidData()
        {
            Config test = new Config();

            IConfigServices ConfigServices = new ConfigServices();
            bool result = ConfigServices.UpdateConfig(test);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestGetListOfAuctions()
        {
            IConfigServices configServices = new ConfigServices();
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetAllConfigurations()).Returns(
                new List<Config>()
                {
                     new Config()
            {
                IdConfig = "text",
                ValueConfig = 3

            }
        });

            ConfigServices.DataServices = mock.Object;
            var result = configServices.GetListOfConfigurations();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Auction>).Count, 1);
        }

        [Test]
        public void TestGetAuctionById()
        {
            IConfigServices configServices = new ConfigServices();
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetConfigById("id")).Returns(

            new Config()
            {
                IdConfig = "text",
                ValueConfig = 3
            });

            ConfigServices.DataServices = mock.Object;
            var result = configServices.GetConfigById("id");

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Config).IdConfig, 10);
        }

        [Test]
        public void TestGetAuctionByIdWithInvalidId()
        {
            IConfigServices configServices = new ConfigServices();
            Mock<IConfigDataServices> mock = new Mock<IConfigDataServices>();
            mock.Setup(m => m.GetConfigById("id")).Returns(
            new Config()
            {
                ValueConfig = 3
            });

            ConfigServices.DataServices = mock.Object;
            var result = configServices.GetConfigById("id");

            Assert.AreEqual(result, null);
        }
    }
}
