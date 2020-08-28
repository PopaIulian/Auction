using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.Services.ServicesImplementation
{
    using AuctionManagement.DataMapper;
    using AuctionManagement.DomainModel;

    class ConfigServices : IConfigServices
    {

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ConfigServices));

        public static IConfigDataServices DataServices { get; set; } = DaoFactoryMethod.CurrentDAOFactory.ConfigDataServices;

        public bool AddConfig(Config config)
        {
            DataServices.AddConfig(config);
            return true;
        }

        public bool DeleteConfig(Config config)
        {
            DataServices.DeleteConfig(config);
            return true;
        }

        public Config GetConfigById(string id)
        {
            return DataServices.GetConfigById(id);
        }

        public IList<Config> GetListOfConfigurations()
        {
            return DataServices.GettAllConfigurations();
        }

        public bool UpdateConfig(Config config)
        {
            DataServices.UpdateConfig(config);
            return true;
        }
    }
}

