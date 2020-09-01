// <copyright file="PersonDataServiceTest.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionTests.DataMapper
{
    using System;
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

        /// <summary>
        /// The TestAllAPersonOperation.
        /// </summary>
        [Test]
        public void TestAllAPersonOperation()
        {
            Person person = new Person()
            {
                IdPerson = 1,
                Username = "name",
                PersonRole = "bidder",
                Score = 34,
                DateWrongScore = DateTime.Now.AddDays(-29)
            };

            SqlPersonDataServices service = new SqlPersonDataServices();
            try
            {
                service.AddPerson(person);
                person.Score = 7;
                service.UpdatePerson(person);
                var people = service.GetAllPersons();
                var samePerson = service.GetPersonById(person.IdPerson);
                service.DeletePerson(person);
            }
            catch
            {
                throw;
            }
        }
    }
}
