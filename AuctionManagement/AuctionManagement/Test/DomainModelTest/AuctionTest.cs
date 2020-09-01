// <copyright file="AuctionTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AuctionTest" />.
    /// </summary>
    public class AuctionTest
    {
        /// <summary>
        /// The TestAuctionValidatorWithValidValues1.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues1()
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
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues2.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues2()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(7),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues3.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues3()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(-3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues4.
        /// </summary>
        [Test]
        public void TestFaildAddAuctionLowPrice()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                Currency = "ron",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 2
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues5.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues5()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                Currency = "ron",
                StartDate = DateTime.Now.AddDays(-1),
                EndDate = DateTime.Now.AddMonths(3),
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestPropPerson.
        /// </summary>
        [Test]
        public void TestPropPerson()
        {
            Auction auction = new Auction();
            Person person = new Person { IdPerson = 2, Username = "user", PersonRole = "bidder", Score = 34, DateWrongScore = DateTime.Now.AddDays(-39) };

            auction.Person = person;

            Assert.AreEqual(auction.Person.Username, "user");
            Assert.AreEqual(auction.Person.PersonRole, "bidder");
        }

        /// <summary>
        /// The TestPropProduct
        /// </summary>
        [Test]
        public void TestPropProduct()
        {
            Auction auction = new Auction();

                Product product= new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 };
            auction.Product = product;

            Assert.AreEqual(auction.Product.IdProduct, 1);
            Assert.AreEqual(auction.Product.ObjectName, "obj_name");

        }

        /// <summary>
        /// The TestAuctionValidatorWithInvalidValues6.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithInValidValues6()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                StartDate = DateTime.Now.AddDays(2),
                EndDate = DateTime.Now.AddDays(30),
                UserId = 20,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues6.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithInValidValues7()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Currency = "ron",
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                StartDate = DateTime.Now.AddDays(2),
                EndDate = DateTime.Now.AddDays(30),
                UserId = 20,
                Price = 34
            };

            IList<Auction> auctions = new List<Auction>() { test, test, test };

            test.ObjectId = 2;
            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(auctions);

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestAuctionValidatorWithValidValues7.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues7()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
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

        /// <summary>
        /// The TestAuctionValidatorWithValidValues8.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues8()
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

        /// <summary>
        /// The TestAuctionValidatorWithValidValues9.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues9()
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

        /// <summary>
        /// The TestAuctionValidatorWithValidValues10.
        /// </summary>
        [Test]
        public void TestAuctionValidatorWithValidValues10()
        {
            Auction test = new Auction()
            {
                IdAuction = 1,
                ObjectId = 1,
                Product = new Product { IdProduct = 1, ObjectName = "obj_name", CategoryName = 2 },
                Currency = "ron",
                UserId = 2,
                Price = 34
            };

            AuctionValidator validator = new AuctionValidator();
            validator.InsertAuctionValidator(new List<Auction>());

            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestAuctionProperties.
        /// </summary>
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
