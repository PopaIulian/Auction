

namespace AuctionManagement.Test.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;
    internal class ProductTest
    {
        
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

    }
}
