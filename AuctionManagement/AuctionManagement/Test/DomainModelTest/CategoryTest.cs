// <copyright file="CategoryTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="CategoryTest" />.
    /// </summary>
    internal class CategoryTest
    {
        /// <summary>
        /// The TestCategoryWithValidValues1.
        /// </summary>
        [Test]
        public void TestCategoryWithValidValues1()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            };

            CategoryValidator validator = new CategoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestCategoryWithValidValues2.
        /// </summary>
        [Test]
        public void TestCategoryWithValidValues2()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "nametooooooooooooooooooooooooooooooooooooooooooooolong",
                ParentId = 2,

            };

            CategoryValidator validator = new CategoryValidator();
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
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name"

            };

            CategoryValidator validator = new CategoryValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            NUnit.Framework.Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestCategoryWithValidValues4.
        /// </summary>
        [Test]
        public void TestCategoryWithValidValues4()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                ParentId = 2,

            };

            CategoryValidator validator = new CategoryValidator();
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
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,
            };

            Assert.AreEqual(test.IdCategory, 1);
            Assert.AreEqual(test.CategoryName, "name");
            Assert.AreEqual(test.ParentId, 2);
        }

        /// <summary>
        /// The TestCategoryProperty2.
        /// </summary>
        [Test]
        public void TestCategoryProperty2()
        {
            Category test = new Category()
            {
                IdCategory = 1,
                CategoryName = "name",
                ParentId = 2,

            };
            Assert.AreNotEqual(test.IdCategory, 45);
            Assert.AreNotEqual(test.CategoryName, "name_v2");
            Assert.AreNotEqual(test.ParentId, 24);
        }
    }
}
