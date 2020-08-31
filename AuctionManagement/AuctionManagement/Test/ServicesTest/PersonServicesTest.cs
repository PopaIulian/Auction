// <copyright file="PersonServicesTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace PersonManagement.Test.ServicesTest
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PersonServicesTest" />.
    /// </summary>
    internal class PersonServicesTest
    {
        /// <summary>
        /// The TestAddPersonWithValidData.
        /// </summary>
        [Test]
        public void TestAddPersonWithValidData()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"
            };

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.AddPerson(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestAddPersonWithInvalidData.
        /// </summary>
        [Test]
        public void TestAddPersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices readerServices = new PersonServices();
            bool result = readerServices.AddPerson(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestDeletePersonWithValidData.
        /// </summary>
        [Test]
        public void TestDeletePersonWithValidData()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"
            };

            IPersonServices personServices = new PersonServices();
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.DeletePerson(test));

            PersonServices.DataServices = mock.Object;
            bool result = personServices.DeletePerson(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestDeletePersonWithInvalidData.
        /// </summary>
        [Test]
        public void TestDeletePersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.DeletePerson(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestUpdateReaderWithValidData.
        /// </summary>
        [Test]
        public void TestUpdateReaderWithValidData()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"

            };

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.UpdatePerson(test);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// The TestUpdatePersonWithInvalidData.
        /// </summary>
        [Test]
        public void TestUpdatePersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.UpdatePerson(test);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// The TestGetListOfPersons.
        /// </summary>
        [Test]
        public void TestGetListOfPersons()
        {
            IPersonServices personServices = new PersonServices();
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.GetAllPersons()).Returns(
                new List<Person>()
                {
                     new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"
            }
        });

            PersonServices.DataServices = mock.Object;
            var result = personServices.GetListOfPersons();

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as List<Person>).Count, 1);
        }

        /// <summary>
        /// The TestGetPersonById.
        /// </summary>
        [Test]
        public void TestGetPersonById()
        {
            IPersonServices personServices = new PersonServices();
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.GetPersonById(1)).Returns(

            new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"
            });

            PersonServices.DataServices = mock.Object;
            var result = personServices.GetPersonById(1);

            Assert.AreNotEqual(result, null);
            Assert.AreEqual((result as Person).IdPerson, 1);
        }

        /// <summary>
        /// The TestGetPersonByIdWithInvalidId.
        /// </summary>
        [Test]
        public void TestGetPersonByIdWithInvalidId()
        {
            IPersonServices personServices = new PersonServices();
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.GetPersonById(10)).Returns(
            new Person()
            {
                Username = "name",
                PersonRole = "bidder"
            });

            PersonServices.DataServices = mock.Object;
            var result = personServices.GetPersonById(1);

            Assert.AreEqual(result, null);
        }
    }
}
