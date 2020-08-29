// <copyright file="SqlPersonDataServices.cs" company="Transilvania University of Brasov">
// Popa Iulian
// </copyright>

namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    /// <summary>
    /// Defines the <see cref="SqlPersonDataServices" />.
    /// </summary>
    internal class SqlPersonDataServices : IPersonDataServices
    {
        /// <summary>
        /// The AddPerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        public void AddPerson(Person person)
        {
            using (Model1 context = new Model1())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The DeletePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        public void DeletePerson(Person person)
        {
            using (Model1 context = new Model1())
            {
                Person toBeDeleted = new Person { IdPerson = person.IdPerson };
                context.People.Attach(toBeDeleted);
                context.People.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// The GetPersonById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Person"/>.</returns>
        public Person GetPersonById(int id)
        {
            using (Model1 context = new Model1())
            {
                return context.People.Where(person => person.IdPerson == id).SingleOrDefault();
            }
        }

        /// <summary>
        /// The GetAllPersons.
        /// </summary>
        /// <returns>The <see cref="IList{Person}"/>.</returns>
        public IList<Person> GetAllPersons()
        {
            using (Model1 context = new Model1())
            {
                return context.People.Select(person => person).ToList();
            }
        }

        /// <summary>
        /// The UpdatePerson.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        public void UpdatePerson(Person person)
        {
            using (Model1 context = new Model1())
            {
                Person toBeUpdated = context.People.Find(person.IdPerson);

                if (toBeUpdated != null)
                {
                    context.Entry(toBeUpdated).CurrentValues.SetValues(person);
                    context.SaveChanges();
                }
            }
        }
    }
}
