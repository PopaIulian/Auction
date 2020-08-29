using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionManagementTest.DomainModel
{

    using System;
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;

    public class AuctionHistoryTest
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
# Assert.IsTrue(isValid);
        }
    }
}