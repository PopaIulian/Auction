using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IPersonDataServices
    {
        void AddPerson(Person person);

        Person GetPersonById(int id);

        IList<Person> GettAllPersons();

        void UpdatePerson(Person person);

        void DeletePerson(Person person);
    }
}
