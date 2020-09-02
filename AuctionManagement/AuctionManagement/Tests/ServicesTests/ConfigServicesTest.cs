// <copyright file="ConfigServicesTest.cs" company="Transilvania University of Brasov">
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
    /// Defines the <see cref="ConfigServicesTest" />.
    /// </summary>
    internal class ConfigServicesTest
    {
        /// <summary>
        /// The TestAddAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddConfigWithInvalidData()
        {
            Config test = new Config();

            IConfigServices readerServices = new ConfigServices();
            bool result = readerServices.AddConfig(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeleteAuctionWithValidData.
        /// </summary>
        [Test]
        public void TestDeleteConfigWithValidData()
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

        /// <summary>
        /// The TestDeleteAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeleteConfigWithInvalidData()
        {
            Config test = new Config();

            IConfigServices configServices = new ConfigServices();
            bool result = configServices.DeleteConfig(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 3
            };

            IConfigServices configServices = new ConfigServices();
            bool result = configServices.UpdateConfig(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdateAuctionWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdateConfigWithInvalidData()
        {
            Config test = new Config();

            IConfigServices configServices = new ConfigServices();
            bool result = configServices.UpdateConfig(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfAuctions.
        /// </summary>
        [Test]
        public void TestGetListOfConfigs()
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
            Assert.AreEqual((result as List<Config>).Count, 1);
        }

        /// <summary>
        /// The TestGetAuctionById.
        /// </summary>
        [Test]
        public void TestGetConfigById()
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
            Assert.AreEqual((result as Config).IdConfig, "text");
        }

        /// <summary>
        /// The TestAddNullConfig.
        /// </summary>
        [Test]
        public void TestAddNullConfig()
        {
            Config test = null;
            IConfigServices configServices = new ConfigServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { configServices.AddConfig(test); });
        }

        /// <summary>
        /// The TestDeleteNullConfig.
        /// </summary>
        [Test]
        public void TestDeleteNullConfig()
        {
            Config test = null;
            IConfigServices configServices = new ConfigServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { configServices.DeleteConfig(test); });
        }

        /// <summary>
        /// The TestUpdateNullConfig.
        /// </summary>
        [Test]
        public void TestUpdateNullConfig()
        {
            Config test = null;
            IConfigServices configServices = new ConfigServices();
            Assert.Throws(typeof(System.ArgumentNullException), delegate { configServices.UpdateConfig(test); });
        }
    }
}
