// <copyright file="PersonServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PersonServices" />.
    /// </summary>
    public class PersonServices : IPersonServices
    {
        /// <summary>
        /// Defines the Log.
        /// </summary>
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(PersonServices));

        /// <summary>
        /// Gets or sets the DataServices.
        /// </summary>
        public static IPersonDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.PersonDataServices;

        /// <summary>
        /// The AddPerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool AddPerson(Person person)
        {
           
            return true;
        }

        /// <summary>
        /// The DeletePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetListOfPersons.
        /// </summary>
        /// <returns>The <see cref="IList{Person}"/>.</returns>
        public IList<Person> GetListOfPersons()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetPersonById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Person"/>.</returns>
        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The UpdatePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}