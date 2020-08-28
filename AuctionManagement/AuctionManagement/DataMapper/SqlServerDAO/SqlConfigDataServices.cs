

namespace AuctionManagement.DataMapper.SqlServerDAO
{
  using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    class SqlConfigDataServices : IConfigDataServices
    {
        public void AddConfig(Config config)
        {
            using (Context context = new Context())
            {
                context.Configs.Add(config);
                context.SaveChanges();
            }
        }

        public void DeleteConfig(Config config)
        {
            using (Context context = new Context())
            {
                Config toBeDeleted = new Config { IdConfig = config.IdConfig };
                context.Configs.Attach(toBeDeleted);
                context.Configs.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public Config GetConfigById(string id)
        {
            using (Context context = new Context())
            {
                return context.Configs.Where(config => config.IdConfig == id).SingleOrDefault();
            }
        }

        public IList<Config> GettAllConfigurations()
        {
            using (Context context = new Context())
            {
                return context.Configs.Select(config => config).ToList();
            }
        }

        public void UpdateConfig(Config config)
        {
            using (Context context = new Context())
            {
                Config toBeUpdated = context.Configs.Find(config.IdConfig);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(config);
                context.SaveChanges();
            }
        }
    }
}
