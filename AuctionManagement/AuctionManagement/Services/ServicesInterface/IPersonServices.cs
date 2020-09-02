// <copyright file="IPersonServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.Services
{
    using System.Collections.Generic;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="IPersonServices" />.
    /// </summary>
    public interface IPersonServices
    {
        /// <summary>
        /// The AddPerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool AddPerson(Person person);

        /// <summary>
        /// The GetPersonById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Person"/>.</returns>
        Person GetPersonById(int id);

        /// <summary>
        /// The GetListOfPersons.
        /// </summary>
        /// <returns>The <see cref="IList{Person}"/>.</returns>
        IList<Person> GetListOfPersons();

        /// <summary>
        /// The UpdatePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool UpdatePerson(Person person);

        /// <summary>
        /// The DeletePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool DeletePerson(Person person);
    }
}
