﻿// <copyright file="AuctionHistoryTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;
    using System;

    /// <summary>
    /// Defines the <see cref="AuctionHistoryTest" />.
    /// </summary>
    public class AuctionHistoryTest
    {
        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues1.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues2.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues3.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues4.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues5.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryValidatorWithValidValues6.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryPropery1.
        /// </summary>
        [Test]
        public void TestAuctionHistoryPropery1()
        {
            AuctionHistory test = new AuctionHistory()
            {
                IdAuctionHistory = 1
            };

            Assert.AreEqual(test.IdAuctionHistory, 1);
        }

        /// <summary>
        /// The TestAuctionHistoryProperties2.
        /// </summary>
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

        /// <summary>
        /// The TestAuctionHistoryProperties3.
        /// </summary>
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
