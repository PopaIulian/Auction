// <copyright file="ConfigTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.Const;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ConfigTest" />.
    /// </summary>
    internal class ConfigTest
    {
        /// <summary>
        /// The TestConfigWithValidValues1.
        /// </summary>
        [Test]
        public void TestConfigWithValidValues1()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 3

            };

            ConfigValidator validator = new ConfigValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestConfigWithValidValues2.
        /// </summary>
        [Test]
        public void TestConfigWithValidValues2()
        {
            Config test = new Config()
            {
                IdConfig = "text toooooooooooooooooooooooooooooooooooooo long",
                ValueConfig = 3

            };

            ConfigValidator validator = new ConfigValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestConfigWithValidValues3.
        /// </summary>
        [Test]
        public void TestConfigWithValidValues3()
        {
            Config test = new Config()
            {
                IdConfig = "text"

            };

            ConfigValidator validator = new ConfigValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestConfigValues1.
        /// </summary>
        [Test]
        public void TestConfigValues1()
        {
            Config test = new Config()
            {
                IdConfig = "avg_number_score",
                ValueConfig = 3

            };
            IList<Config> list = new List<Config>();
            list.Add(test);

            int value = Configuration.GetConfigValue(list, Configuration.AVERAGE_NUMBER_SCORE);

            Assert.AreEqual(value, test.ValueConfig);
        }

        /// <summary>
        /// The TestConfigValues2.
        /// </summary>
        [Test]
        public void TestConfigValues2()
        {
            Config test = new Config()
            {
                IdConfig = "random text",
                ValueConfig = 3

            };
            IList<Config> list = new List<Config>();
            list.Add(test);

            int value = Configuration.GetConfigValue(list, Configuration.AVERAGE_NUMBER_SCORE);

            Assert.AreEqual(value, 0);
        }

        /// <summary>
        /// The TestConfigValues3.
        /// </summary>
        public void TestConfigValues3()
        {
            Config test = new Config()
            {
                IdConfig = "min_score",
                ValueConfig = 3

            };
            IList<Config> list = new List<Config>();
            list.Add(test);

            int value = Configuration.GetConfigValue(list, Configuration.AVERAGE_NUMBER_SCORE);

            Assert.AreNotEqual(value, 0);
        }

        /// <summary>
        /// The TestConfigValues4.
        /// </summary>
        [Test]
        public void TestConfigValues4()
        {
            Config test = new Config()
            {
                IdConfig = "bidder",
                ValueConfig = 3

            };
            IList<Config> list = new List<Config>();
            list.Add(test);

            int value = Configuration.GetConfigValue(list, Configuration.INITIAL_SCORE);

            Assert.AreEqual(value, 0);
        }

        /// <summary>
        /// The TestConfigValues5.
        /// </summary>
        [Test]
        public void TestConfigValues5()
        {
            Config test = new Config()
            {
                IdConfig = "max_auction",
                ValueConfig = 30

            };
            IList<Config> list = new List<Config>();
            list.Add(test);

            int value = Configuration.GetConfigValue(list, Configuration.MAX_RANGE_AUCTION_PERSON);

            Assert.AreEqual(value, test.ValueConfig);
        }

        /// <summary>
        /// The TestConfigProperty1.
        /// </summary>
        [Test]
        public void TestConfigProperty1()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 5
            };

            Assert.AreEqual(test.IdConfig, "text");
            Assert.AreEqual(test.ValueConfig, 5);
        }

        /// <summary>
        /// The TestConfigProperty2.
        /// </summary>
        [Test]
        public void TestConfigProperty2()
        {
            Config test = new Config()
            {
                IdConfig = "text",
                ValueConfig = 5

            };
            Assert.AreNotEqual(test.IdConfig, "t");
            Assert.AreNotEqual(test.ValueConfig, 7);
        }
    }
}
