// <copyright file="ProductTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="ProductTest" />.
    /// </summary>
    internal class ProductTest
    {
        /// <summary>
        /// The TestProductWithValidValues1.
        /// </summary>
        [Test]
        public void TestProductWithValidValues1()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryId = 2
            };

            ProductValidator validator = new ProductValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestProductWithValidValues2.
        /// </summary>
        [Test]
        public void TestProductWithValidValues2()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name toooooooooooooooooooo long",
                CategoryId = 2
            };

            ProductValidator validator = new ProductValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestProductWithValidValues3.
        /// </summary>
        [Test]
        public void TestProductWithValidValues3()
        {
            Product test = new Product()
            {
                IdProduct = 1
            };

            ProductValidator validator = new ProductValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestProductProperty1.
        /// </summary>
        [Test]
        public void TestProductProperty1()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryId = 2
            };

            Assert.AreEqual(test.IdProduct, 1);
            Assert.AreEqual(test.ObjectName, "name");
            Assert.AreEqual(test.CategoryId, 2);
        }

        /// <summary>
        /// The TestProductProperty2.
        /// </summary>
        [Test]
        public void TestProductProperty2()
        {
            Product test = new Product()
            {
                IdProduct = 1,
                ObjectName = "name",
                CategoryId = 2
            };
            Assert.AreNotEqual(test.IdProduct, 45);
            Assert.AreNotEqual(test.ObjectName, "name_v2");
            Assert.AreNotEqual(test.CategoryId, 5);
        }
    }
}
