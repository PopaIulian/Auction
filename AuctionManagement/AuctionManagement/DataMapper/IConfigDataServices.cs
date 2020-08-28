using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DataMapper
{
    using AuctionManagement.DomainModel;
    using System.Collections.Generic;

    public interface IConfigDataServices
    {
        void AddConfig(Config config);

        Config GetConfigById(string id);

        IList<Config> GettAllConfigurations();

        void UpdateConfig(Config config);

        void DeleteConfig(Config config);
    }
}
