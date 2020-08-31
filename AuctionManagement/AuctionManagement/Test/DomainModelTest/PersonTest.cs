// <copyright file="PersonTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DomainModelTest
{
    using AuctionManagement.DomainModel;
    using AuctionManagement.DomainModel.Validator;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="PersonTest" />.
    /// </summary>
    internal class PersonTest
    {
        /// <summary>
        /// The TestPersonWithValidValues1.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues1()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"

            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestPersonWithValidValues2.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues2()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "nametoooooooooooooooooooo long",
                PersonRole = "bidder"

            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestPersonWithValidValues3.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues3()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name"

            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestPersonWithValidValues4.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues4()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "anything"


            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestPersonWithValidValues5.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues5()
        {
            Person test = new Person()
            {
                IdPerson = 1

            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsFalse(isValid);
        }

        /// <summary>
        /// The TestPersonWithValidValues6.
        /// </summary>
        [Test]
        public void TestPersonWithValidValues6()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "applicant"

            };

            PersonValidator validator = new PersonValidator();
            var results = validator.Validate(test);

            bool isValid = results.IsValid;
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// The TestPersonProperty1.
        /// </summary>
        [Test]
        public void TestPersonProperty1()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "applicant"
            };

            Assert.AreEqual(test.IdPerson, 1);
            Assert.AreEqual(test.Username, "name");
            Assert.AreEqual(test.PersonRole, "applicant");
        }

        /// <summary>
        /// The TestPersonProperty2.
        /// </summary>
        [Test]
        public void TestPersonProperty2()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "role"

            };
            Assert.AreNotEqual(test.IdPerson, 45);
            Assert.AreNotEqual(test.Username, "name_v2");
            Assert.AreNotEqual(test.PersonRole, "jcr");
        }
    }
}
