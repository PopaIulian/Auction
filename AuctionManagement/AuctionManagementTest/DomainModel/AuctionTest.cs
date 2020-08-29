using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionManagementTest.DomainModel
{
    using System;
    using NUnit.Framework;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    public class AuctionTest
    {

        [Test]
        public void TestAuthorValidatorWithValidValues1()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        [Test]
        public void TestAuthorValidatorWithValidValues2()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(7),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuthorValidatorWithValidValues3()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(-3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }
        [Test]
        public void TestAuthorValidatorWithValidValues4()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 2
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator();

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuthorValidatorWithValidValues5()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now.AddDays(-1),
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator();

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuthorValidatorWithValidValues6()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                StartDate = DateTime.Now.AddDays(2),
                EndDate = DateTime.Now.AddDays(30),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator();

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        [Test]
        public void TestAuthorValidatorWithValidValues7()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }
        [Test]
        public void TestAuthorValidatorWithValidValues8()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
            };

            AuctionValidator validator = new AuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }
        [Test]
        public void TestAuthorValidatorWithValidValues9()
        {
            Auction test = new Auction()
            {
                IdAuction = 1
            };

            AuctionValidator validator = new AuctionValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        [Test]
        public void TestAuctionProperties()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                UserId = 2,
                Price = 34
            };

            NUnit.Framework.Assert.AreEqual(test.IdAuction, 1);
            NUnit.Framework.Assert.AreEqual(test.ObjectId, 1);
            NUnit.Framework.Assert.AreEqual(test.UserId, 2);
            NUnit.Framework.Assert.AreEqual(test.Price, 34);
        }
    }
}

 