using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Test.ServicesTest
{
       using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using AuctionManagement.Services;
    using AuctionManagement.Services.ServicesImplementation;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    class PersonServicesTest
    {
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

        [Test]
        public void TestAddPersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices readerServices = new PersonServices();
            bool result = readerServices.AddPerson(test);

            Assert.IsFalse(result);
        }

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

        [Test]
        public void TestDeletePersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.DeletePerson(test);

            Assert.IsFalse(result);
        }

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

        [Test]
        public void TestUpdatePersonWithInvalidData()
        {
            Person test = new Person();

            IPersonServices PersonServices = new PersonServices();
            bool result = PersonServices.UpdatePerson(test);

            Assert.IsFalse(result);
        }

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
            Assert.AreEqual((result as Person).IdPerson, 10);
        }

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
