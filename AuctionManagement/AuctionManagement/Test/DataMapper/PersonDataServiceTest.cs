// <copyright file="PersonDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DataMapper
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DataMapper.SqlServerDAO;
    using AuctionManagement.DomainModel;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="PersonDataServiceTest" />.
    /// </summary>
    internal class PersonDataServiceTest
    {
        /// <summary>
        /// The AddPersonTest.
        /// </summary>
        [Test]
        public void AddPersonTest()
        {
            Person person = new Mock<Person>().Object;

            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.AddPerson(person));

            IPersonDataServices obj = mock.Object;
            obj.AddPerson(person);

            mock.Verify(o => o.AddPerson(person), Times.Once());
        }

        /// <summary>
        /// The DeletePersonTest.
        /// </summary>
        [Test]
        public void DeletePersonTest()
        {
            Person person = new Mock<Person>().Object;

            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.DeletePerson(person));

            IPersonDataServices obj = mock.Object;
            obj.DeletePerson(person);

            mock.Verify(o => o.DeletePerson(person), Times.Once());
        }

        /// <summary>
        /// The UpdatePersonTest.
        /// </summary>
        [Test]
        public void UpdatePersonTest()
        {
            Person person = new Mock<Person>().Object;

            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.UpdatePerson(person));

            IPersonDataServices obj = mock.Object;
            obj.UpdatePerson(person);

            mock.Verify(o => o.UpdatePerson(person), Times.Once());
        }

        /// <summary>
        /// The GetAllPersonsTest.
        /// </summary>
        [Test]
        public void GetAllPersonsTest()
        {
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.GetAllPersons());

            IPersonDataServices obj = mock.Object;
            obj.GetAllPersons();

            mock.Verify(o => o.GetAllPersons(), Times.Once());
        }

        /// <summary>
        /// The GetPersonByIdTest.
        /// </summary>
        [Test]
        public void GetPersonByIdTest()
        {
            Mock<IPersonDataServices> mock = new Mock<IPersonDataServices>();
            mock.Setup(m => m.GetPersonById(1));

            IPersonDataServices obj = mock.Object;
            obj.GetPersonById(1);

            mock.Verify(o => o.GetPersonById(1), Times.Once());
        }

        [Test]
        public void TestAllAuctionOperation()
        {
            Person test = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder"
            };

            IPersonDataServices service = new SqlPersonDataServices();

            service.AddPerson(test);

            Person elem = service.GetPersonById(1);
            Assert.AreEqual(elem.Username, test.Username);

            var elems = service.GetAllPersons();
            Assert.IsNotEmpty(elems);

            Person newElem = new Person()
            {
                IdPerson = 1,
                Username = "new_name"
            };
            service.UpdatePerson(newElem);
            service.DeletePerson(test);
        }
    }
}
