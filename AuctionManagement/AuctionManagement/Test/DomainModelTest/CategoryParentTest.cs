using AuctionManagement.DomainModel;
using AuctionManagement.DomainModel.Validator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTests.DomainModelTest
{
    internal class CategoryParentTest
    {
        /// <summary>
        /// The TestCategoryWithValidValues1.
        /// </summary>
        [Test]
        public void TestCategoryParentWithValidValues1()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            CategoryParentValidator validator = new CategoryParentValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        [Test]
        public void TestCategoryWithValidValues2()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                ParentId = 2
            };

            CategoryParentValidator validator = new CategoryParentValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestCategoryWithValidValues3.
        /// </summary>
        [Test]
        public void TestCategoryWithValidValues3()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2
            };

            CategoryParentValidator validator = new CategoryParentValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsFalse(isValid);
        }



        /// <summary>
        /// The TestCategoryProperty1.
        /// </summary>
        [Test]
        public void TestCategoryProperty1()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };

            Assert.AreEqual(test.IdCategoryParent, 1);
            Assert.AreEqual(test.CategoryId, 2);
            Assert.AreEqual(test.ParentId, 3);
        }

        /// <summary>
        /// The TestCategoryProperty2.
        /// </summary>
        [Test]
        public void TestCategoryProperty2()
        {
            CategoryParent test = new CategoryParent()
            {
                IdCategoryParent = 1,
                CategoryId = 2,
                ParentId = 3
            };
            Assert.AreNotEqual(test.IdCategoryParent, 45);
            Assert.AreNotEqual(test.CategoryId, 75);
            Assert.AreNotEqual(test.ParentId, 82);
        }
    }
}

