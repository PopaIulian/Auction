using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionTests.DomainModelTest
{

    using System;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;

    public class AuctionHistoryTest
    {

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues1()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2,
                Auctiondate = DateTime.Now,
                AuctionId = 1,
                Price = 100,
                Currency = "ron"
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues2()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 2,
                UserId = 2,
                Auctiondate = DateTime.Now,
                AuctionId = 1,
                Price = 1000,
                Currency = "euro"
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues3()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2,
                AuctionId = 1,
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues4()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues5()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuctionHistoryValidatorWithValidValues6()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 5,
                UserId = 6,
                Auctiondate = DateTime.Now.AddDays(3),
                AuctionId = 1,
                Price = 1030,
                Currency = "euro"
            };

            AuctionHistoryValidator validator = new AuctionHistoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        [Test]
        public void TestAuctionHistoryPropery1()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1
            };

            Assert.AreEqual(test.IdAuctionHistory, 1);
        }

        [Test]
        public void TestAuctionHistoryProperties2()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2,
                Auctiondate = DateTime.Now,
                AuctionId = 1,
                Price = 100,
                Currency = "ron"
            };

            
            Assert.AreEqual(test.AuctionId, 1);
            Assert.AreEqual(test.Price, 100);
            Assert.AreEqual(test.Currency, "ron");
        }

        [Test]
        public void TestAuctionHistoryProperties3()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1,
                UserId = 2,
                Auctiondate = DateTime.Now,
                AuctionId = 1,
                Price = 100,
                Currency = "ron"
            };


            Assert.AreNotEqual(test.AuctionId, 10);
            Assert.AreNotEqual(test.Price, 1004);
            Assert.AreNotEqual(test.Currency, "euro");
        }
    }
}