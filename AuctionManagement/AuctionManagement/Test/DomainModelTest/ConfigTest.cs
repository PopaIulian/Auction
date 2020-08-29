
using AuctionManagement.Const;
using AuctionManagement.DomainModel;
using AuctionManagement.DomainModel.Validator;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AuctionTests.DomainModelTest
{
    class ConfigTest
    {
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
