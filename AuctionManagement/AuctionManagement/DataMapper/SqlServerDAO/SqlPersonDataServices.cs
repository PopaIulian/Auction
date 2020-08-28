
namespace AuctionManagement.DataMapper.SqlServerDAO
{
    using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    class SqlPersonDataServices : IPersonDataServices
    {
        public void AddPerson(Person person)
        {
            using (Context context = new Context())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

        public void DeletePerson(Person person)
        {
            using (Context context = new Context())
            {
                Person toBeDeleted = new Person { IdPerson = person.IdPerson };
                context.Persons.Attach(toBeDeleted);
                context.Persons.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public Person GetPersonById(int id)
        {
            using (Context context = new Context())
            {
                return context.Persons.Where(person => person.IdPerson == id).SingleOrDefault();
            }
        }

        public IList<Person> GettAllPersons()
        {
            using (Context context = new Context())
            {
                return context.Persons.Select(person => person).ToList();
            }
        }

        public void UpdatePerson(Person person)
        {
            using (Context context = new Context())
            {
                Person toBeUpdated = context.Persons.Find(person.IdPerson);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(person);
                context.SaveChanges();
            }
        }
    }
}

