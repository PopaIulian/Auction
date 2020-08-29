// <copyright file="IPersonDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IPersonDataServices" />.
    /// </summary>
    public interface IPersonDataServices
    {
        /// <summary>
        /// The AddPerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        void AddPerson(Person person);

        /// <summary>
        /// The GetPersonById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Person"/>.</returns>
        Person GetPersonById(int id);

        /// <summary>
        /// The GetAllPersons.
        /// </summary>
        /// <returns>The <see cref="IList{Person}"/>.</returns>
        IList<Person> GetAllPersons();

        /// <summary>
        /// The UpdatePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        void UpdatePerson(Person person);

        /// <summary>
        /// The DeletePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        void DeletePerson(Person person);
    }
}
