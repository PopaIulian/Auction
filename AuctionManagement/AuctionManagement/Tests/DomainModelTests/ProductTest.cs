﻿// <copyright file="ProductTest.cs" company="Transilvania University of Brasov">
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
                CategoryName = 2
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
                CategoryName = 2
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
                CategoryName = 2
            };

            Assert.AreEqual(test.IdProduct, 1);
            Assert.AreEqual(test.ObjectName, "name");
            Assert.AreEqual(test.CategoryName, 2);
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
                CategoryName = 2
            };
            Assert.AreNotEqual(test.IdProduct, 45);
            Assert.AreNotEqual(test.ObjectName, "name_v2");
            Assert.AreNotEqual(test.CategoryName, 5);
        }

        /// <summary>
        /// The TestProductProperty3.
        /// </summary>
        [Test]
        public void TestProductProperty3()
        {
            Product test = new Product();
            Category category = new Category() { IdCategory = 2, CategoryName = "cat_name" };
            test.Category = category;

            Assert.AreEqual(test.Category.IdCategory, 2);
            Assert.AreEqual(test.Category.CategoryName, "cat_name");
        }

        /// <summary>
        /// The TestProductProperty5.
        /// </summary>
        [Test]
        public void TestProductProperty5()
        {
            Product test = new Product();
            Category category = new Category() { IdCategory = 5, CategoryName = "cat_name" };
            test.Category = category;

            Assert.AreNotEqual(test.Category.IdCategory, 6);
            Assert.AreNotEqual(test.Category.CategoryName, "another_cat_name");
        }
    }
}
